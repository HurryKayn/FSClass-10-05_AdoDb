using System.Data.SqlClient;

namespace ADOes01.adoDb
{
    internal class AdoDb
    {
        private string GetCon()
        {
            string con = "Data Source=LAPTOP_MARCO\\SQLEXPRESS;Initial Catalog=Negozio;Integrated Security=True;";
            return con;
        }
        
        public void ClientiUpdate()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(GetCon()))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();
                    try
                    {
                        {
                            int i = 0;
                            string query = "UPDATE Clienti Set Nome='Fausto' where ClienteID=1";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            i = cmd.ExecuteNonQuery();
                        }


                        {
                            string query = "Update Clienti Set ZonaID='14' where ClienteID=4";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            int i = cmd.ExecuteNonQuery();
                        }

                        {
                            string query = "Update Clienti Set Nome='Ugo' where ClienteID=3";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            int i = cmd.ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Intercetta errore, esegue rollback");
                        transaction.Rollback();
                    }
                }
                        
            }
            catch(Exception e) 
            {
            }
        }
        public void ClientiRead()
        {
            //Creazione oggetto di Connessione
           
            try
            {
                using (SqlConnection connection = new SqlConnection(GetCon()))
                {
                    connection.Open();
                    string query = "Select nome,Cognome,Email FROM Clienti";

                    using (SqlCommand cmd = new SqlCommand(query, connection)) { 
                    SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            string nome = reader["Nome"].ToString();
                            string cognome = reader["Cognome"].ToString();
                            string email = reader["email"].ToString();

                            string s = $"Nome Cliente : {nome} Cognome : {cognome} Email : {email}";

                            Console.WriteLine(s);

                        }
                            }
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
  

        }
    }
}
