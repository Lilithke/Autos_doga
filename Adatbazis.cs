using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Autos_doga
{
    internal class Adatbazis
    {
        MySqlConnection connection = null;
        MySqlCommand sql = null;

        public Adatbazis()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "autok";
            builder.CharacterSet = "utf8";
            
            connection = new MySqlConnection(builder.ConnectionString);
            sql = connection.CreateCommand();
            try
            {
                kapcsolatnyit();
            }
            catch(MySqlException ex)
            { 
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
            finally
            {
                kapcsolatZar();
            }
            





        }

        private void kapcsolatZar()
        {
            if (connection.State != System.Data.ConnectionState.Closed)connection.Close();
        }

        private void kapcsolatnyit()
        {
            if(connection.State != System.Data.ConnectionState.Open)connection.Open();
        }

        internal List<Auto> getAllautok()
        {
            List<Auto> autok = new List<Auto>();
            sql.CommandText = "SELECT * FROM `auto` ORDER BY `marka`";
            try
            {
                kapcsolatnyit();
                using (MySqlDataReader reader = sql.ExecuteReader())
                {
                    while (reader.Read())
                    //`rendszam`,`marka`,`modell`,`gyartasiev`,`forgalmiErvenyesseg`,`vetelar`,`kmallas`,`hengerurtartalom`,`tomeg`,`teljesitmeny`
                    {
                        string rend = reader.GetString("rendszam");
                        string mark = reader.GetString("marka");
                        string model =reader.GetString("modell");
                        int gyartasev = reader.GetInt32("gyartasiev");
                        DateTime forgalmiErvenyesseg = reader.GetDateTime("forgalmiErvenyesseg");
                        int kmAllas = reader.GetInt32("kmallas");
                        int hengerurt = reader.GetInt32("hengerurtartalom");
                        int tomeg = reader.GetInt32("tomeg");
                        int teljesitmeny = reader.GetInt32("teljesitmeny");
                        decimal vetelAr = reader.GetDecimal("vetelar");
                        autok.Add(new Auto(rend, mark, model, gyartasev, forgalmiErvenyesseg, kmAllas, hengerurt, tomeg, teljesitmeny, vetelAr));
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show (ex.Message);
            }
            finally
            {
                kapcsolatZar();
            }
            return autok;
        }

        internal void updateAuto(Auto auto)
        {
            sql.CommandText = "UPDATE `auto` SET " +
                "`marka`= @marka,`modell`= @modell,`gyartasiev`=@gyartasiev," +
                "`forgalmiErvenyesseg`= @forgalmiErvenyesseg,`vetelar`= @vetelar,`kmallas`= @kmallas," +
                "`hengerurtartalom`= @hengerurtartalom,`tomeg`= @tomeg," +
                "`teljesitmeny`= @teljesitmeny WHERE `rendszam`= @rendszam";
            sql.Parameters.Clear();
            sql.Parameters.AddWithValue("@marka", auto.Mark);
            try
            {
                kapcsolatnyit();
                sql.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            { 
                MessageBox.Show(ex.Message);
            }
            finally
            {
                kapcsolatZar();
            }
        }
    }
}
