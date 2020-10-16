using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetMetier
{
    public class GestionnaireDeCaves
    {
        private Dictionary<string, List<Bouteille>> lesCaves;

        public GestionnaireDeCaves()
        {
            LesCaves = new Dictionary<string, List<Bouteille>>();
        }

        public Dictionary<string, List<Bouteille>> LesCaves { get => lesCaves; set => lesCaves = value; }


        
        public void AjouterCave(string unNomDeCave,List<Bouteille> lesBouteillesDeLaCave)
        {
            LesCaves.Add(unNomDeCave,lesBouteillesDeLaCave);
        }

        public int NbBouteilles(string unNomDeCave)
        {
            int num = 0;
            foreach (GestionnaireDeCaves gest in lesCaves)
            {
                foreach (Bouteille bou in gest.lesBouteillesDeLaCave)
                {
                    if (Couleur == "Rouges")
                    {
                        num++;
                    }


                    return num;
        }

        public int NbBouteillesDeRouges(string unNomDeCave)
        {
            int num = 0;
            foreach (GestionnaireDeCaves gest in lesCaves)
            {
                foreach (Bouteille bou in gest.lesBouteillesDeLaCave)
                {
                    if (Couleur == "Rouges")
                    {
                        num++;
                    }
                    else(Couleur == "")
                    {
                        return 0;
                    }
                }
            }

            return num;
        }

        public double ValeurDeLaCave(string unNomDeCave)
        {
            // A vous de jouer
            return 0;
        }
    }
}
