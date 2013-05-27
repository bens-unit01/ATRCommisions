using ATRCommissions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.OracleClient;

namespace UnitTestDAO
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

        #region Attributs de tests supplémentaires
        // 
        //Vous pouvez utiliser les attributs supplémentaires suivants lorsque vous écrivez vos tests :
        //
        //Utilisez ClassInitialize pour exécuter du code avant d'exécuter le premier test dans la classe
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Utilisez ClassCleanup pour exécuter du code après que tous les tests ont été exécutés dans une classe
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Utilisez TestInitialize pour exécuter du code avant d'exécuter chaque test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Utilisez TestCleanup pour exécuter du code après que chaque test a été exécuté
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Test pour GetConnection
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ATRCommissions.exe")]
        public void GetConnectionTest()
        {
            OracleConnection expected = null; // TODO: initialisez à une valeur appropriée
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
            CommErrors expected = CommErrors.Success;
            CommErrors actual;
            DateTime currentDate = DAO.GetCurrentDate(out actual);
            Assert.AreEqual(expected, actual);
          
        }

        /// <summary>
        ///Test pour Login
        ///</summary>
        [TestMethod()]
        public void LoginTest()
        {
            DAO target = new DAO(); // TODO: initialisez à une valeur appropriée
            target.Utilisateur = new User(1, "1111");
            CommErrors expected = CommErrors.Success; // TODO: initialisez à une valeur appropriée
            CommErrors actual;
            actual = target.Login();
            Assert.AreEqual(expected, actual);
           
        }
    }
}
