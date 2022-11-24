using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrainement1.Modeles
{
    public class VenteEcommerce : Vente
    {
        #region Attributes
        private string _adresseLivraison;
        private string _optionLivraison;
        #endregion

        #region Constructor
        //pour créer le constructeur quand il y a un héritage il faut faire un :base et mettre dedans
        //les valeurs qui correspondent à la classe mère
        public VenteEcommerce(/* rentrer les attributs pour la classe mère et fille*/) 
            : base(/* rentrer les attributs de la classe mère déclarée juste au dessus */)
        {
            //attribuer les valeurs de la classe fille dans les attributs
        }
        #endregion

        #region Getters/Setters
        public string AdresseLivraison { get => _adresseLivraison; set => _adresseLivraison = value; }
        public string OptionLivraison { get => _optionLivraison; set => _optionLivraison = value; }
        #endregion

        #region Methods
        #endregion
    }
}
