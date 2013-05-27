using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OracleClient;
using System.Diagnostics;

namespace AgenceVoyage
{
    public class DAO
    {

        
        // proprietés 
        public User Utilisateur { get; set; }
        public static readonly string DateFormat = "yyyy-MM-dd";

        // constructeur 
        public DAO() { }



        #region méthodes de services

        public CommErrors Login()
        {
            decimal agentId = this.Utilisateur.AgentId;
            string password = this.Utilisateur.Password;
            CommErrors returnValue = CommErrors.ConnectionError;

            OracleConnection connection = GetConnection();

            try
            {
                Debug.WriteLine("DAO Login - Connexion vers Oracle ...");
                connection.Open();

                string query = "SELECT * from agents where agent_id=" + agentId + " and  mot_passe ='" + password + "'";

                OracleDataReader reader = SelectNatif(query, connection);

                string profile = "";
                while (reader.Read())
                {

                    profile = (string)reader[1];

                }

                // vérification du résultat  

                if (profile.Equals(""))
                {
                    returnValue = CommErrors.LoginFailed;
                }
                else
                {
                    this.Utilisateur.Profile = profile.Equals("agent") ? Profile.Agent : Profile.Admin;
                    returnValue = CommErrors.Success;
                }


            }
            catch (Exception e)
            {
                Debug.WriteLine("DAO Login - bloc catch :" + e.Message);
                returnValue = CommErrors.ConnectionError;

            }
            finally
            {
                connection.Close();
            }

            Debug.WriteLine("DAO - Login  returnValue: " + returnValue);
            return returnValue;

        }


        public static DateTime GetCurrentDate(out CommErrors err)
        {
            DateTime currentDate = new DateTime();
            OracleConnection connection = GetConnection();
            try
            {
                connection.Open();
                string query = "SELECT * FROM t_timemachine where id_date = 1";
                OracleDataReader reader = SelectNatif(query, connection);


                while (reader.Read())
                {

                    currentDate = (DateTime)reader[1];

                }

                err = CommErrors.Success;

            }
            catch (Exception e)
            {

                Debug.WriteLine("DAO GetCurrentDate() - bloc catch :" + e.Message);
                err = CommErrors.ConnectionError;
            }
            finally
            {
                connection.Close();
            }

            return currentDate;
        }


        // change la date du système  (qui est sauvegardée dans t_timemachine) et lui ajoute 1 jour
        public static CommErrors SetNextDay()
        {
            CommErrors err;

            DateTime currentDate = new DateTime();
            currentDate = GetCurrentDate(out err);

            if (err != CommErrors.ConnectionError)
            {
                DateTime newDate = currentDate.AddDays(1);                  // on ajoute 1 jour 
                err = SetNewDate(newDate);

            }
            
          
            return err;

        }




        // change la date du système  (qui est sauvegardée dans t_timemachine) et met celle du 1er du mois suivant

        public static CommErrors SetNextMonth()
        {
            CommErrors err;

            DateTime currentDate = new DateTime();
            currentDate = GetCurrentDate(out err);

            if (err != CommErrors.ConnectionError)
            {
                DateTime nextMonth = currentDate.AddMonths(1);  // mois suivant 
                DateTime newDate = new DateTime(nextMonth.Year, nextMonth.Month, 1);  // 1er jour du mois suivant 
                err = SetNewDate(newDate);

            }


            return err;
        }



        public static decimal GetSequence(string table, out CommErrors err)
        {



            decimal returnValue = 0;
            err = CommErrors.ConnectionError;

            OracleConnection connection = GetConnection();

            try
            {
                Debug.WriteLine("DAO GetSequence- Connexion vers Oracle ...");
                connection.Open();

                string query = "SELECT TO_CHAR("+table+"_seq.nextval) FROM DUAL";

                OracleDataReader reader = SelectNatif(query, connection);

                string sequence = "";
                while (reader.Read())
                {

                    sequence = (string)reader[0];

                }


                 returnValue = decimal.Parse(sequence);
                 err = CommErrors.Success;
                


            }
            catch (Exception e)
            {
                Debug.WriteLine("DAO GetSequence - bloc catch :" + e.Message);
                err = CommErrors.ConnectionError;

            }
            finally
            {
                connection.Close();
            }

            Debug.WriteLine("DAO - GetSequence  returnValue: " + returnValue);
           
            return returnValue;

        
        }

        public static void UpdateTable(Police police) {

            OracleCommand sql = new OracleCommand();
            OracleConnection connection = GetConnection();
            /*police.Etat = "vendu";
            police.FrequencePaiement = frequencePaiement[cmbFrequencePmt.SelectedIndex];
            police.MontantPaiement = decimal.Parse(txtMontantPaiement.Text);
            police.ClientId = clientId;
            police.DateAchat = AgentView.SystemDate;
            police.DateDebut = dtpDateDebut.Value;
            police.DateFin = dtpDateFin.Value;*/

            string query = "UPDATE polices SET etat = '" + police.Etat + "', fequence_paiement_client = '"+
                police.FrequencePaiement + "', montant_paiement_client = " + police.MontantPaiement + ", client_id ='"+
                police.ClientId + "', date_achat = to_date('"
                    + police.DateAchat.ToString(DateFormat) + "','" + DateFormat + "'), date_debut = to_date('"
                    + police.DateDebut.ToString(DateFormat) + "','" + DateFormat + "'), date_fin = to_date('"
                    + police.DateFin.ToString(DateFormat) + "','" + DateFormat + "')"+
                    "WHERE police_id = "+police.PoliceId;
            try
            {
                connection.Open();
                sql.Connection = connection;
                sql.CommandText = query;
                sql.CommandType = System.Data.CommandType.Text;

                sql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("DAO - UpdateTable :"+ex.Message);
                throw;
            }
            finally
            {
                connection.Close();
            }


             

        
        }

      

       

        #endregion



        #region méthodes utilitaires
        // fonction executant une recherche selon la requete  "query" entrée en parametre
        private static OracleDataReader SelectNatif(string query, OracleConnection connection)
        {
            OracleCommand sql = new OracleCommand();

            try
            {
                sql.Connection = connection;
                sql.CommandText = query;
                sql.CommandType = System.Data.CommandType.Text;
            }
            catch (Exception)
            {

                throw;
            }


            return sql.ExecuteReader();
        }

        // établit une connection à la BD Oracle
        private static OracleConnection GetConnection()
        {
            string cs = "Data Source=gdna10; User Id=username; Password=pwd;";
            OracleConnection connection = new OracleConnection();
            connection.ConnectionString = cs;
            return connection;
        }

        private static CommErrors SetNewDate(DateTime newDate)
        {

            OracleConnection connection = GetConnection();
            CommErrors err = CommErrors.ConnectionError;
            string query;
            try
            {
                connection.Open();


                query = "UPDATE t_timemachine SET date_courante =  to_date('"
                    + newDate.ToString(DateFormat) + "','" + DateFormat + "')";

                Debug.WriteLine("DAO - SetNewDate()- currentDate:" + newDate.ToString(DateFormat));
                OracleCommand sql = new OracleCommand();
                sql.Connection = connection;
                sql.CommandText = query;
                sql.CommandType = System.Data.CommandType.Text;
                sql.ExecuteNonQuery();
                err = CommErrors.Success;



            }
            catch (Exception e)
            {

                Debug.WriteLine("DAO SetNextDay() - bloc catch :" + e.Message);
                err = CommErrors.ConnectionError;

            }
            finally
            {
                connection.Close();
            }


            return err;
        }
        #endregion

    } // --  fin Classe DAO



}
