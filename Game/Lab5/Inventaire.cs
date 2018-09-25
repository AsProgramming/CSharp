using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Inventaire
    {
        private int Argent;
        private SortedList<Sorte, int> Ceuilli;
        private SortedList<Sorte, int> Acheter;

        public Inventaire()
        {
            Argent = 250;
            LesLists();
        }

        public int Solde
        {
            get { return Argent; }
        }
        /// <summary>
        /// Methode qui dit si il n'a pas de semance disponible
        /// </summary>
        /// <returns></returns>
        public bool AucunPlant()
        {
            int Nb = 0;
            for (int i = 0; i < Ceuilli.Count; i++)
            {
                Nb += TotalInventaire(AjouterCoorect(i), Ceuilli);
            }
            return Nb == 0;
        }
        /// <summary>
        /// Methode qui dit le total de l'inventaire soi pour vendre ou celle acheter
        /// </summary>
        /// <param name="_LeType"></param>
        /// <param name="AVendre"></param>
        /// <returns></returns>
        public int Total(Sorte _LeType, bool AVendre)
        {
            if(AVendre)
            {
                return TotalInventaire(_LeType, Ceuilli);
            }
            else
            {
                return TotalInventaire(_LeType, Acheter);
            }
        }
        /// <summary>
        /// Methode qui ajuste la bonne plante
        /// </summary>
        /// <param name="_Type"></param>
        /// <param name="VaPlanter"></param>
        public void AjusterPlante(Sorte _Type, bool VaPlanter)
        {
            if (VaPlanter)
            {
                Retirer(_Type, Acheter);
            }
            else
            {
                AjoutSemence(_Type);
            }
        }
        /// <summary>
        /// Methode qui ajuste les liste quand le joueur recolte une plante qu'il a cultiver
        /// </summary>
        /// <param name="_Type"></param>
        public void CeuillirPlante(Sorte _Type)
        {
            Cultiver(_Type);
        }
        /// <summary>
        /// Methode qui met a jour la liste de semance
        /// </summary>
        /// <param name="_Type"></param>
        /// <param name="_total"></param>
        public void AchatSemance(int _Type, int _total)
        {
            switch (_Type)
            {
                case 1:
                    Acheter[Sorte.BLE] += _total;
                    break;
                case 2:
                    Acheter[Sorte.CARROT] += _total;
                    break;
                case 3:
                    Acheter[Sorte.TULIPE] += _total;
                    break;
                case 4:
                    Acheter[Sorte.TOMATE] += _total;
                    break;
                case 5:
                    Acheter[Sorte.OIGNON] += _total;
                    break;
            }
        }

        /// <summary>
        /// Methode qui ajuste le solde du joueur par rapport s'il vend ou achete une plante
        /// </summary>
        /// <param name="_Type"></param>
        /// <param name="Achat"></param>
        public void AjusterSolde(int _Type, int _total ,bool Achat)
        {
            if (Achat)
            {
                Cout(_Type, _total);
            }
            else
            {
                Profit(_Type, _total);
            }
        }
        /// <summary>
        /// Methode qui ajuste l'argent du joueur par rapport s'il achete une plante
        /// </summary>
        /// <param name="_Type"></param>
        private void Cout(int _Type, int _total)
        {
            switch (_Type)
            {
                case 1:
                    Argent -= _total;
                    break;
                case 2:
                    Argent -= _total;
                    break;
                case 3:
                    Argent -= _total;
                    break;
                case 4:
                    Argent -= _total;
                    break;
                case 5:
                    Argent -= _total;
                    break;
            }
        }
        /// <summary>
        /// Methode qui ajuste le solde quand il vend une plante
        /// </summary>
        /// <param name="_Type"></param>
        private void Profit(int _Type, int _total)
        {
            switch (_Type)
            {
                case 1:
                    Argent += _total;
                    Ajuster(Sorte.CARROT, RendreNegatif(_total / 20), Ceuilli);
                    break;
                case 2:
                    Argent += _total;
                    Ajuster(Sorte.BLE, RendreNegatif(_total / 25), Ceuilli);
                    break;
                case 3:
                    Argent += _total;
                    Ajuster(Sorte.TULIPE, RendreNegatif(_total / 50), Ceuilli);
                    break;
                case 4:
                    Argent += _total;
                    Ajuster(Sorte.OIGNON, RendreNegatif(_total / 200), Ceuilli);
                    break;
                case 5:
                    Argent += _total;
                    Ajuster(Sorte.TOMATE, RendreNegatif(_total / 250), Ceuilli);
                    break;
            }
        }
        /// <summary>
        /// Methode qui est appeler pour convertir en negatif un nombre
        /// </summary>
        /// <param name="_i"></param>
        /// <returns></returns>
        private int RendreNegatif(int _i)
        {
            return _i = _i - (_i * 2);

        }
        /// <summary>
        /// Methode qui ajuste de moins la liste
        /// </summary>
        /// <param name="_Type"></param>
        /// <param name="_Lst"></param>
        private void Retirer(Sorte _Type, SortedList<Sorte, int> _Lst)
        {
            Ajuster(_Type, -1, _Lst);
        }
        /// <summary>
        /// Methode qui est appeler du dehors de la classe
        /// </summary>
        /// <param name="_Type"></param>
        private void AjoutSemence(Sorte _Type)
        {
            Ajuster(_Type, 1, Acheter);
        }
        /// <summary>
        /// Methode qui est appeler du dehors de la classe pour ajuster la liste
        /// </summary>
        /// <param name="_Type"></param>
        private void Cultiver(Sorte _Type)
        {
            Ajuster(_Type, 1, Ceuilli);
        }
        /// <summary>
        /// Methode qui met a jour la liste
        /// </summary>
        /// <param name="_p"></param>
        /// <param name="_i"></param>
        /// <param name="_Lst"></param>
        private void Ajuster(Sorte _p, int _i, SortedList<Sorte, int> _Lst)
        {
            switch (_p)
            {
                case Sorte.BLE:
                    _Lst[Sorte.BLE] += _i;
                    break;
                case Sorte.CARROT:
                    _Lst[Sorte.CARROT] += _i;
                    break;
                case Sorte.OIGNON:
                    _Lst[Sorte.OIGNON] += _i;
                    break;
                case Sorte.TOMATE:
                    _Lst[Sorte.TOMATE] += _i;
                    break;
                case Sorte.TULIPE:
                    _Lst[Sorte.TULIPE] += _i;
                    break;
            }
        }
        /// <summary>
        /// Methode qui donne le total de la plante demander
        /// </summary>
        /// <param name="_p"></param>
        /// <param name="_Lst"></param>
        /// <returns></returns>
        private int TotalInventaire(Sorte _p, SortedList<Sorte, int> _Lst)
        {
            int Retour = 0;
            switch (_p)
            {
                case Sorte.BLE:
                    _Lst.TryGetValue(Sorte.BLE, out Retour);
                    break;
                case Sorte.CARROT:
                    _Lst.TryGetValue(Sorte.CARROT, out Retour);
                    break;
                case Sorte.OIGNON:
                    _Lst.TryGetValue(Sorte.OIGNON, out Retour);
                    break;
                case Sorte.TOMATE:
                    _Lst.TryGetValue(Sorte.TOMATE, out Retour);
                    break;
                case Sorte.TULIPE:
                    _Lst.TryGetValue(Sorte.TULIPE, out Retour);
                    break;
            }
            return Retour;
        }
        /// <summary>
        /// Methode qui met a jour les listes 
        /// </summary>
        private void LesLists()
        {
            Ceuilli = new SortedList<Sorte, int>();
            Acheter = new SortedList<Sorte, int>();
            Associer(Ceuilli);
            Associer(Acheter);
        }
        /// <summary>
        /// Methode qui associ la bonne plante a la bonne liste
        /// </summary>
        /// <param name="_Lst"></param>
        private void Associer(SortedList<Sorte, int> _Lst)
        {
            for (int i = 0; i < 5; i++)
            {
                _Lst.Add(AjouterCoorect(i),0);
            }
        }
        /// <summary>
        /// Methode qui retrourne la bonne plante
        /// </summary>
        /// <param name="_i"></param>
        /// <returns></returns>
        private Sorte AjouterCoorect(int _i)
        {
            switch (_i)
            {
                case 1:
                    return Sorte.CARROT;
                case 2:
                    return Sorte.OIGNON;
                case 3:
                    return Sorte.TOMATE;
                case 4:
                    return Sorte.TULIPE;
                default:
                    return Sorte.BLE;
            }
        }  
    }
}
