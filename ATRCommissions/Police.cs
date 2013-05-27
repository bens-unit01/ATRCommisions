using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgenceVoyage
{
    public class Police
    {
        //propriétés 
        public decimal PoliceId { get; set; }
        public string Etat { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public DateTime DateAchat { get; set; }
        public DateTime DateAnnulation { get; set; }
        public decimal MontantCommission { get; set; }
        public string FrequencePaiement { get; set; }
        public decimal MontantPaiement { get; set; }
        public decimal TypeId { get; set; }
        public decimal ClientId { get; set; }
        public decimal AgentId { get; set; }

        // constructeur 
        public Police() { }

    }
}
