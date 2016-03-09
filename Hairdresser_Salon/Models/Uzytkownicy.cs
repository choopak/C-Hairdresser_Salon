using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MySql.Data.MySqlClient;
using System.Configuration;


namespace Hairdresser_Salon.Models
{
    public class Uzytkownicy
    {
        #region parametry z bazy

        public int IDPackgage { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string NrTelefonu { get; set; }
        public string Email { get; set; }
        public string Plec { get; set; }
        public int IDRezerwacji { get; set; }

        #endregion

        private bool connection_open;
        private MySqlConnection connection;

        #region konstruktory
        public Uzytkownicy()
        {

        }

        public Uzytkownicy(int arg_id)
        {
            Get_Connection();
            IDPackgage = arg_id;

            try
            {


                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText =
                string.Format("select concat (IDPackgage, imie, nazwisko) from uzytkownicy where IDPackgage = '{0}'",
                                              IDPackgage);

                MySqlDataReader reader = cmd.ExecuteReader();
                int a;
            }
            catch (MySqlException e)
            {
                //blad
                Imie = "blad";
                Nazwisko = "blad";
            }
        }

        #endregion

        #region Polaczenie z baza danych

        private void Get_Connection()
        {
            connection_open = false;

            connection = new MySqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;

            if (Open_Connection())
            {
                connection_open = true;
            }
            else
            {
                //blad
            }

        }

        private bool Open_Connection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        #endregion
    }

}