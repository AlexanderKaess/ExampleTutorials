using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_8
{
    class Post
    {
        //variables
        private static int currentPostId;

        //properties
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUserName { get; set; }
        protected bool IsPublic { get; set; }

        //default constructor
        public Post()
        {
            ID = 0;
            Title = "Mein erster Post";
            IsPublic = true;
            SendByUserName = "Alexander Kaess";
        }

        //constructor
        public Post(string title, bool isPublic, string sendByUserName)
        {
            this.ID = GetNextId();
            this.Title = title;
            this.IsPublic = isPublic;
            this.SendByUserName = sendByUserName;
        }

        //methods
        protected int GetNextId()
        {
            return ++currentPostId;
        }

        public void UpdatePost(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        //virtuelle Methoden können von erbenden Klassen überschrieben werden
        //override überschreibt die virtuelle Methode
        public override string ToString()
        {
            return String.Format("ID: {0} - Title: {1} - von User: {2}", this.ID, this.Title, this.SendByUserName);
        }
    }
}
