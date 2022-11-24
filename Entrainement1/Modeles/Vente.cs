using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrainement1.Modeles
{
    public class Vente
    {
        #region Attributes
        private DateTime _dateVente;
        private Conso _leConso;
        private double _montant;
        #endregion

        #region Constructor
        public Vente(DateTime dateVente, Conso leConso, double montant)
        {
            DateVente = dateVente;
            LeConso = leConso;
            Montant = montant;
        }
        #endregion

        #region Getters/Setters
        public DateTime DateVente { get => _dateVente; set => _dateVente = value; }
        public Conso LeConso { get => _leConso; set => _leConso = value; }
        public double Montant { get => _montant; set => _montant = value; }
        #endregion

        #region Methods
        public Conso GetConso()
        {
            return _leConso;
        }
        #endregion
    }
}
