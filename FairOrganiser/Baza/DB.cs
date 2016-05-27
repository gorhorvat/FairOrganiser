using System;
using System.Collections.Generic;
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
        public int Insert(string name, DateTime dtm)
        {
            SqlCommand command = new SqlCommand("Insert into Dogadaj (naziv,datum) values (@naziv,@datum)",Connection);
            command.Parameters.AddWithValue("@naziv", name);
            command.Parameters.AddWithValue("@datum", dtm);
            return command.ExecuteNonQuery();
        }

    }
}
