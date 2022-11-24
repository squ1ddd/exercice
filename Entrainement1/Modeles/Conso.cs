using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrainement1.Modeles
{
    public class Conso
    {
        #region Attributes
        private string _nom;
        private string _prenom;
        private string _mail;
        private string _tel;
        private List<Vente> _lesVentes;
        #endregion

        #region Constructor
        public Conso(string nom, string prenom, string mail, string tel)
        {
            Nom = nom;
            Prenom = prenom;
            Mail = mail;
            Tel = tel;
        }
        #endregion

        #region Getters/Setters
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public string Mail { get => _mail; set => _mail = value; }
        public string Tel { get => _tel; set => _tel = value; }
        public List<Vente> LesVentes { get => _lesVentes; set => _lesVentes = value; }
        #endregion

        #region Methods
        // cette méthode doit renvoyer le nombre de ventes qu'il y a pour ce consommateur,
        // sachant que pour avoir la taille d'une liste on doit faire le nom de la liste.Count
        public int getNbVentes() 
        {

        }
        public virtual Boolean estFidele()
        {
            return false;
        }
        //on veut la liste des ventes avec un montant supérieur à celui en paramètre
        public List<Vente> VenteSuperieur(double montant) 
        {
            //vu qu'on doit renvoyer une liste on la déclare avant
            List<Vente> list = new List<Vente>();
            //on va donc parcourir notre liste de vente avec un foreach
            //puis si(utilisation d'un if) la valeur du montant de la vente (uneVente.montant) est supérieure à notre montant en param
            //alors on l'ajoute à notre liste avec un list.Add(de la valeur)



            return list;
        }
        #endregion
    }
}
