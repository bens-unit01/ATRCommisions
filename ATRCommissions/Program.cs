using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AgenceVoyage
{
    static class Program
    {
        
        public static User user;
        public static Splash SplashRef; // ref vers l'ecran splash
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DialogResult result ;
           

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
          
         
         using (var mainScreen = new EmptyView())
         {
            mainScreen.Show();
            LoginScreen loginScreen = new LoginScreen();
            result = loginScreen.ShowDialog();
          }
        SplashRef = new Splash();
        SplashRef.Show();   

        if (result == DialogResult.OK)  // bloc non executé si on clique sur "Annuler"
        {
            if((user.Profile == Profile.Admin) || ( user.Profile == Profile.Agent))
            ViewFactory.getViewInstance(user.Profile).Show();
        }
           

        }

        // ecran de chargement 
        
    }
}