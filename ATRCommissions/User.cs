using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgenceVoyage
{
    public class User
    {
       
       

        // propriétés 
        public decimal AgentId { get; set; }
        public Profile Profile { get; set; }
        public string Password { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        // constructeurs 

        public User() { } 

        public User(decimal agentId, string password)
        {
            AgentId = agentId;
            Password = password;
        }

        public class Admin : User
        {
        
        }

        public class Agent : User 
        {
        
        }

       

    }
}
