using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrainement1.Modeles
{
    public class Statistique
    {
        #region Attributes
        #endregion

        #region Constructor
        #endregion

        #region Getters/Setters
        #endregion

        #region Methods
        //pour savoir à quoi sert cette liste on regarde ce qu'elle retourne
        //là on voit que on renvoit un pourcentage car c'est un nb de ventes sur un total de ventes et *100 donc c'est un pourcentage
        public static double statVente(List<Vente> lesVentesDuJour)
        {
            int nbVenteFidele = 0;
            //avec le foreach on parcourt la liste des ventes du jour
            foreach (Vente uneVente in lesVentesDuJour)
            {
                //on récupére le consommateur de la vente 
                Conso c = uneVente.GetConso();
                //puis on vérifie si il est fidèle avec la méthode et s'il l'est
                //on augmente le nombre de vente par des consommateurs fidèles
                if (c.estFidele())
                {
                    nbVenteFidele++;
                }
            }
            return nbVenteFidele * 100 / lesVentesDuJour.Count;
        }

        //niveau dur
        //ici on doit vérifier si parmi les ventes des consommateurs ils les ont fait en magasin ou en ligne
        public static double compareLieuVente(List<ConsoFidele> lesConsos)
        {
            double totalEcom = 0; //montants des ventes ecommerce
            double totalMag = 0;  //montants des ventes en magasin
            foreach(ConsoFidele consoFidele in lesConsos)
            {
                // on va commencer par faire un foreach pour parcourir les ventes des consommateurs donc consoFidele.LesVentes
                // pour savoir si c'est une vente ecommerce dans le type on va pouvoir mettre VenteEcommerce car il y a un héritage
                //puis on ajoutera le montant de cette vente dans le totalEcom avec vente.montant



            }
            return totalMag / totalEcom; //renvoie le montant des ventes en magasin sur le montant des ventes en ligne
        }
        #endregion
    }
}
