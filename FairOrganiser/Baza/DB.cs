﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Baza
{
    public class DB
    {
        private SqlConnection _conn;
        private static DB _instance;
        private string _connString;
        


        public static DB Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new DB();
                }
                return _instance;
            }
            
        }


        public string ConnectionString
        {
            get
            {
                return _connString;
            }
            private set
            {
               _connString = value;
            }
        }


        public SqlConnection Connection
        {
            get
            {
                return _conn;
            }
            private set
            {
                _conn = value;
            }
        }

        private DB()
        {
            ConnectionString = @"Data Source=31.147.204.119\PISERVER,1433;Initial Catalog=16057_DB;Persist Security Info=True;User ID=16057_User;Password=7yDsyGQs";
            Connection = new SqlConnection(ConnectionString);
            Connection.Open();
        }

        ~DB()
        {
            try {
                Connection.Close();
                Connection = null;
            }
            catch (InvalidOperationException)
            {
                //i don't even know
            }
        }

        // vise redova/stupaca
        public SqlDataReader GetDataReader(string query)
        {
            SqlCommand command = new SqlCommand(query, Connection);
            return command.ExecuteReader();
        }

        // samo jedna vrijednost
        public object GetValue (string query)
        {
            SqlCommand command = new SqlCommand(query, Connection);
            return command.ExecuteScalar();
        }

        // update,delete, iz nekog razloga ne radi za insert ako ima datetime, za to treba druge funkcije
        public int ExecQuery(string query)
        {
            SqlCommand command = new SqlCommand(query, Connection);
            return command.ExecuteNonQuery();
        }

        // ovo radi, ono gore nece, samo c/p za drugu tablicu, mozda napravim da radi za vise tablica sa parametrima al dunno
        public int Insert(string name, DateTime dtmOd, DateTime dtmDo, float cijena)
        {
            SqlCommand command = new SqlCommand("Insert into Dogadaj (naziv, datumOd, datumDo, cijenaKarte) values (@naziv,@datumOd, @datumDo, @cijenaKarte)",Connection);
            command.Parameters.AddWithValue("@naziv", name);
            command.Parameters.AddWithValue("@datumOd", dtmOd);
            command.Parameters.AddWithValue("@datumDo", dtmDo);
            command.Parameters.AddWithValue("@cijenaKarte", cijena);
            return command.ExecuteNonQuery();
        }

        public int Insert(DateTime vrijediOd, DateTime vrijediDo)
        {
            SqlCommand command = new SqlCommand("Insert into CjenikDogadaja (vrijediOd, vrijediDo) values (@vrijediOd, @vrijediDo)", Connection);
            command.Parameters.AddWithValue("@vrijediOd", vrijediOd);
            command.Parameters.AddWithValue("@vrijediDo", vrijediDo);
            return command.ExecuteNonQuery();
        }

        // Popraviti insert za Kartu, dodati vanjske ključeve nakon što napravimo upite
        public int Insert(DateTime datum)
        {
            SqlCommand command = new SqlCommand("Insert into Karta (datum) values (@datum)", Connection);
            command.Parameters.AddWithValue("@datum", datum);
            return command.ExecuteNonQuery();
        }

        //Popraviti insert za Racun, dodati vanjske ključeve nakon što napravimo upite
        public int Insert(string operater, DateTime vrijeme, string nazivTvrtke, string sjediste, string oib, float ukupno, string nazivKupca)
        {
            SqlCommand command = new SqlCommand("Insert into Racun (operater, vrijeme, nazivTvrtke, sjediste, oib, ukupno, nazivKupca) values (@operater,@vrijeme, @nazivTvrtke, @sjediste, @oib, @ukupno, @nazivKupca)", Connection);
            command.Parameters.AddWithValue("@operater", operater);
            command.Parameters.AddWithValue("@vrijeme", vrijeme);
            command.Parameters.AddWithValue("@nazivTvrtke", nazivTvrtke);
            command.Parameters.AddWithValue("@sjediste", sjediste);
            command.Parameters.AddWithValue("@oib", oib);
            command.Parameters.AddWithValue("@ukupno", ukupno);
            command.Parameters.AddWithValue("@nazivKupca", nazivKupca);
            return command.ExecuteNonQuery();
        }

        /* ZA IGRANJE
        public int PozoviFunkcije(string name, DateTime datumOd, DateTime datumDo)
        {
            int res;

            SqlCommand command = new SqlCommand("BrojKarte", Connection) { CommandType = CommandType.StoredProcedure};
            SqlParameter p1 = new SqlParameter("@naziv", SqlDbType.VarChar);
            SqlParameter p2 = new SqlParameter("@datumOd", SqlDbType.DateTime2);
            SqlParameter p3 = new SqlParameter("@datumDo", SqlDbType.DateTime2);
            SqlParameter p4 = new SqlParameter("@broj", SqlDbType.Int);
            p1.Direction = ParameterDirection.Input;
            p2.Direction = ParameterDirection.Input;
            p3.Direction = ParameterDirection.Input;
            p4.Direction = ParameterDirection.Output;

            p1.Value = name;
            p2.Value = datumOd;
            p3.Value = datumDo;

            command.Parameters.Add(p1);
            command.Parameters.Add(p2);
            command.Parameters.Add(p3);
            command.Parameters.Add(p4);

            command.ExecuteNonQuery();

            res = Convert.ToInt32(p4);

            return res;
        }
        */
    }
}
