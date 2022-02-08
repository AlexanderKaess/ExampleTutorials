using System;
using System.Threading;

namespace Tutorial_8
{
    class VideoPost:Post
    {
        //variables
        protected bool isPlaying = false;
        protected int currentDuration = 0;
        Timer timer;

        //properties
        protected string VideoURL { get; set; }
        protected int VideoLength { get; set; }

        //default constructor
        public VideoPost()
        {
            VideoURL = "Keine URL vorhanden";
            VideoLength = 0;
        }

        //constructor
        public VideoPost(string title, string sendByUserName, string videoURL, int videoLength, bool isPublic)
        {
            //GetNextID() von Post-Klasse geerbt und kann verwendet werden
            this.ID = GetNextId();
            this.Title = title;
            this.SendByUserName = sendByUserName;
            //VideoURL und VideoLength ist Property von Klasse-VideoPost aber nicht von Klasse-Post
            this.VideoURL = videoURL;
            this.VideoLength = videoLength;
            this.IsPublic = isPublic;
        }

        //methods
        //virtuelle Methoden können von erbenden Klassen überschrieben werden
        //override überschreibt die virtuelle Methode
        public override string ToString()
        {
            return String.Format("ID: {0} - Video-Title: {1} - mit Video-URL {2} - Laenge: {3}s - von User: {4}", this.ID, this.Title, this.VideoURL, this.VideoLength, this.SendByUserName);
        }

        public void PlayVideo()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Spiele Video ab");
                timer = new Timer(MyTimerCallBack,null,0, 1000);
            }
        }

        //alle 1000ms wird diese Methode ausgeführt, siehe den Wert 1000 bei Instanzierung von "timer"
        private void MyTimerCallBack(Object obj)
        {
            //MyTimerCallBack wird beendet wenn currentDuration gleich Länge des Videos ist
            if (currentDuration < VideoLength)
            {
                currentDuration++;
                Console.WriteLine("Video ist bei {0}s", currentDuration);
                GC.Collect();
            }
            else 
            {
                StopVideo();
            }
        }

        public void StopVideo()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine("Video angehalten bei {0}s", currentDuration);
                currentDuration = 0;
                //Timer wird gestoppt und geschlossen
                timer.Dispose();
            }
        }


    }
}
