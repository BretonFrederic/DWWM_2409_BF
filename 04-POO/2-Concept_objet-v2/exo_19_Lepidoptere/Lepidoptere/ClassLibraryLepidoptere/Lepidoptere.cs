﻿namespace ClassLibraryLepidoptere
{
    public class Lepidoptere
    {
        private string espece;
        private StadeEvolution? sonStadeCourant;

        // Constructeur
        public Lepidoptere(string espece)
        {
            this.espece = espece;
            this.sonStadeCourant = new Oeuf();
        }

        // Méthodes
        public void SeMetamorphoser()
        {
            this.sonStadeCourant = sonStadeCourant.SeMetamorphoser();
        }
        public void SeDeplacer()
        {
            this.sonStadeCourant.SeDeplacer();
        }
    }
}
