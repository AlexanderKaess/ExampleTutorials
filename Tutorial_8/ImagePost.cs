using System;

namespace Tutorial_8
{
    //ImagePost erbt von Post und fügt eine Eigenschaft (ImageURL) und zwei Konstruktoren hinzu

    class ImagePost : Post
    {
        //variables

        //properties
        protected string ImageURL { get; set; }

        //default constructor
        public ImagePost()
        {
            ImageURL = "Keine URL vorhanden";
        }

        //constructor
        public ImagePost(string title, string sendByUserName, string imageURL, bool isPublic)
        {
            //GetNextID() von Post-Klasse geerbt und kann verwendet werden
            this.ID = GetNextId();
            this.Title = title;
            this.SendByUserName = sendByUserName;
            //imageURl ist Property von Klasse-ImagePost aber nicht von Klasse-Post
            this.ImageURL = imageURL;
            this.IsPublic = isPublic;
        }

        //methods
        //virtuelle Methoden können von erbenden Klassen überschrieben werden
        //override überschreibt die virtuelle Methode
        public override string ToString()
        {
            return String.Format("ID: {0} - Bild-Title: {1} - mit URL {2} - von User: {3}", this.ID, this.Title, this.ImageURL, this.SendByUserName);
        }

    }
}
