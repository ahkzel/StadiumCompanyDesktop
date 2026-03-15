namespace forms1
{
    partial class Troll_window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            bt_oui = new Button();
            bt_non = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 46);
            label1.Name = "label1";
            label1.Size = new Size(381, 20);
            label1.TabIndex = 0;
            label1.Text = "nan ça marche pas gros fils de pute de merde, réessaye :";
            // 
            // bt_oui
            // 
            bt_oui.Location = new Point(138, 97);
            bt_oui.Name = "bt_oui";
            bt_oui.Size = new Size(94, 29);
            bt_oui.TabIndex = 1;
            bt_oui.Text = "Oui";
            bt_oui.UseVisualStyleBackColor = true;
            bt_oui.Click += bt_oui_Click;
            // 
            // bt_non
            // 
            bt_non.Location = new Point(238, 97);
            bt_non.Name = "bt_non";
            bt_non.Size = new Size(94, 29);
            bt_non.TabIndex = 2;
            bt_non.Text = "Non";
            bt_non.UseVisualStyleBackColor = true;
            bt_non.Click += bt_non_Click;
            // 
            // Troll_window
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 176);
            ControlBox = false;
            Controls.Add(bt_non);
            Controls.Add(bt_oui);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Troll_window";
            Text = "GROS CACA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button bt_oui;
        private Button bt_non;
    }
}