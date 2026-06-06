using System;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Fonts;
using PdfSharp.Pdf;
using PdfSharp.Quality;
using PdfSharp.Snippets.Font;
namespace forms1.controllers
{
    public class Main_controller
    {
        private MySqlConnection conn;
        private User_controller user_controller;
        private Quizz_controller quizz_controller;
        private Theme_controller theme_controller;
        private Question_controller question_controller;
        private Answer_controller answer_controller;

        public Main_controller(MySqlConnection Conn)
        {
            conn = Conn;
            user_controller = new User_controller(conn);
            quizz_controller = new Quizz_controller(conn);
            theme_controller = new Theme_controller(conn);
            question_controller = new Question_controller(conn);
            answer_controller = new Answer_controller(conn);
        }
        public MySqlConnection Conn
        { get { return conn; } set { conn = value; } }
        public User_controller User_controller
        { get { return user_controller; } set { user_controller = value; } }
        public Quizz_controller Quizz_controller
        { get { return quizz_controller; } set { quizz_controller = value; } }
        public Theme_controller Theme_controller
        { get { return theme_controller; } set { theme_controller = value; } }
        public Question_controller Question_controller
        { get { return question_controller; } set { question_controller = value; } }
        public Answer_controller Answer_controller
        { get { return answer_controller; } set { answer_controller = value; } }


        public void generate_pdf(string name_quizz, string theme_quizz)
        {
            int id_quizz = quizz_controller.get_id_quizz_from_name(name_quizz);
            List<List<string>> questions = question_controller.get_all_questions_from_quizz(id_quizz);

            PdfDocument document = new PdfDocument();
            GlobalFontSettings.UseWindowsFontsUnderWindows = true;
            document.Info.Title = "Questionnaire_" + name_quizz;

            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont titleFont = new XFont("Arial", 20, XFontStyleEx.Bold, new XPdfFontOptions(PdfFontEmbedding.EmbedCompleteFontFile));
            XFont textFont = new XFont("Arial", 12, XFontStyleEx.Regular, new XPdfFontOptions(PdfFontEmbedding.EmbedCompleteFontFile));
            int y_var = 40;

            gfx.DrawString(name_quizz, titleFont, XBrushes.Black, new XRect(0, y_var, page.Width, 30), XStringFormats.TopCenter);
            y_var += 50;
            gfx.DrawString("Thème : " + theme_quizz, textFont, XBrushes.Black, new XRect(40, y_var, page.Width, 20), XStringFormats.TopLeft);
            y_var += 30;

            foreach (List<string> question in questions)
            {
                string question_name = question[1];
                string question_type = question[2];
                string question_weight = question[3];
                List<string> answers = answer_controller.get_answer_from_question_quizz(question_name, id_quizz);

                if (y_var + 20*(answers.Count() + 1) > page.Height - 50)
                {
                    page = document.AddPage();
                    gfx = XGraphics.FromPdfPage(page);
                    y_var = 40;
                }

                gfx.DrawString("- " + question_name + " (" + question_type + ")", textFont, XBrushes.Black, new XRect(60, y_var, page.Width, 20), XStringFormats.TopLeft);
                gfx.DrawString(question_weight, textFont, XBrushes.Black, new XRect(40, y_var, page.Width - 80, 20), XStringFormats.TopRight);
                y_var += 15;

                foreach (string answer in answers)
                {
                    gfx.DrawString("- " + answer, textFont, XBrushes.Black, new XRect(80, y_var, page.Width - 80, 20), XStringFormats.TopLeft);
                    y_var += 15;
                }
                y_var += 20;
            }
            string downloads_folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            string safe_name = string.Concat(name_quizz.Split(Path.GetInvalidFileNameChars()));
            string full_path = Path.Combine(downloads_folder, "Questionnaire_" + safe_name + ".pdf");

            document.Save(full_path);
            Process.Start(new ProcessStartInfo(full_path) { UseShellExecute = true });
        }
    }
}
