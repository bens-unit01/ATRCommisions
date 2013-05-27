using ATRCommissions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.OracleClient;

namespace TestATRCommissions
{
    
    
    /// <summary>
    ///Classe de test pour DAOTest, destinée à contenir tous
    ///les tests unitaires DAOTest
    ///</summary>
    [TestClass()]
    public class DAOTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Obtient ou définit le contexte de test qui fournit
        ///des informations sur la série de tests active ainsi que ses fonctionnalités.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

       


        /// <summary>
        ///Test pour GetConnection
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ATRCommissions.exe")]
        public void GetConnectionTest()
        {
            OracleConnection expected = null; 
            OracleConnection actual;
            actual = DAO_Accessor.GetConnection();
            Assert.AreNotEqual(expected, actual);
            
        }

        /// <summary>
        ///Test pour GetCurrentDate
        ///</summary>
        [TestMethod()]
        public void GetCurrentDateTest()
        {
            CommErrors err = new CommErrors(); 
            CommErrors errExpected = CommErrors.Success; 
            DateTime actual;
            actual = DAO.GetCurrentDate(out err);
            Assert.AreEqual(errExpected, err);
          
        }

        /// <summary>
        ///Test pour Login
        ///</summary>
        [TestMethod()]
        public void LoginTest()
        {
            DAO target = new DAO(); 
            target.Utilisateur = new User(1, "1111"); 
            CommErrors expected = CommErrors.Success; 
            CommErrors actual;
            actual = target.Login();
            Assert.AreEqual(expected, actual);
           
        }

      

        /// <summary>
        ///Test pour SetNextDay
        ///</summary>
        [TestMethod()]
        public void SetNextDayTest()
        {
            CommErrors expected = CommErrors.Success;
            CommErrors actual;
            actual = DAO.SetNextDay();
            Assert.AreEqual(expected, actual);
            
        }

        /// <summary>
        ///Test pour SetNextMonth
        ///</summary>
        [TestMethod()]
        public void SetNextMonthTest()
        {
            CommErrors expected = CommErrors.Success;
            CommErrors actual;
            actual = DAO.SetNextMonth();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Test pour SetNewDate
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ATRCommissions.exe")]
        public void SetNewDateTest()
        {
            DateTime newDate = new DateTime(); // TODO: initialisez à une valeur appropriée
            CommErrors expected = CommErrors.Success; // TODO: initialisez à une valeur appropriée
            CommErrors actual;
            actual = DAO_Accessor.SetNewDate(newDate);
            Assert.AreEqual(expected, actual);
       
        }

        /// <summary>
        ///Test pour SelectNatif
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ATRCommissions.exe")]
        public void SelectNatifTest()
        {
            string query = "SELECT * FROM agents";
            OracleConnection connection = DAO_Accessor.GetConnection(); 
            OracleDataReader notExpected = null; 
            OracleDataReader actual;
            actual = DAO_Accessor.SelectNatif(query, connection);
            Assert.AreNotEqual(notExpected, actual);
          
        }

        /// <summary>
        ///Test pour GetSequence
        ///</summary>
        [TestMethod()]
        public void GetSequenceTest()
        {
            
            string table = "polices"; 
            CommErrors err = new CommErrors(); 
            CommErrors errExpected = CommErrors.Success; 
            Decimal notExpected = 0; 
            Decimal actual;
            actual = DAO.GetSequence(table, out err);
            Assert.AreEqual(errExpected, err);
            Assert.AreNotEqual(notExpected, actual);
         
        }
    }
}
