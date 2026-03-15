using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forms1.models
{
    public class Type_model
    {
        private MySqlConnection conn;

        public Type_model(MySqlConnection Conn)
        {
            conn = Conn;
        }

        public string get_type_from_id(int id_type)
        {
            string query = "SELECT label_type FROM type_question WHERE id = @id_type";
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id_type", id_type);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader.GetString("label_type");
                    }
                }
            }
            return "";
        }

        public int get_id_from_type(string label_type)
        {
            string query = "SELECT id FROM type_question WHERE label_type = @label_type";
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@label_type", label_type);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader.GetInt32("id");
                    }
                }
            }
            return -1;
        }
    }
}
