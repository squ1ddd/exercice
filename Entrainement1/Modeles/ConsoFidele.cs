using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrainement1.Modeles
{
    public class ConsoFidele : Conso
    {
        #region Attributes
        private DateTime _dateNaiss;
        private double _pointsFidelite;
        private DateTime _dateInscription;
        #endregion

        #region Constructor
        public ConsoFidele(DateTime dateNaiss, double pointsFidelite, DateTime dateInscription, string nom, string prenom, string mail, string tel) 
            : base(nom,prenom,mail,tel)
        {
            DateNaiss = dateNaiss;
            PointsFidelite = pointsFidelite;
            DateInscription = dateInscription;
        }
        #endregion

        #region Getters/Setters
        public DateTime DateNaiss { get => _dateNaiss; set => _dateNaiss = value; }
        public double PointsFidelite { get => _pointsFidelite; set => _pointsFidelite = value; }
        public DateTime DateInscription { get => _dateInscription; set => _dateInscription = value; }
        #endregion

        #region Methods
        public override Boolean estFidele()
        {
            return false;
        }
        public void addFidelite(int typeFidelite, double montant)
        {

        }
        
        #endregion
    }
}
