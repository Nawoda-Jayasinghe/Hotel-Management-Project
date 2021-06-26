using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotel_Management_System
{
    public partial class Test : Form
    {
       // MySqlConnection con = null;
        public Test()
        {
            
        }

        

        private void buttonOk_Click(object sender, EventArgs e){
                runQuery();
        }

        private void runQuery(){
                string qu = "insert into guest(id, name,age) values('" + textID.Text + "', '" + textName.Text + "' + '" + textAge.Text + "');";
                // string qu = "SELECT * FROM guest;";
                MySqlConnection databaseConnection1 = DatabaseConnection.Connectdb();
                // String MYSQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=test;";
                // MySqlConnection databaseConnection = new MySqlConnection(databaseConnection1) ;

                MySqlCommand commandDatabase = new MySqlCommand(qu, databaseConnection1);

                try
                {
                    databaseConnection1.Open();
                    MySqlDataReader myReader = commandDatabase.ExecuteReader();

                    if (myReader.HasRows)
                    {
                        while (myReader.Read())
                        {
                            Console.WriteLine(myReader.GetString(0) + " - " + myReader.GetString(1));
                        }
                    }

                    //MySqlCommand cm = new MySqlCommand(qu, con);
                    // cm.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex);

                }

                databaseConnection1.Close();
            }
        }
    }

