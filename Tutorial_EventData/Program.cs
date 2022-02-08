using System;

namespace Tutorial_EventData
{
    //Delegaten (Funktionszeiger) definieren, der ein EventhandlerMethode darstellt
    //sender = Objektinstanz welches das Event auslöst
    //ea = Daten die alle Empfänger erhalten sollen
    public delegate void WordChangedEventHandler(object sender, WordChangedEventArgs eA);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World, Kaess is the best!");

            Word myWort = new Word();
            Benachrichtiger empf = new Benachrichtiger();

            //Abonnieren des Events
            //Mit dem += Operator kan man sagen, mit welcher Methode man das Event abonnieren will
            //Mit dem += Operattor kann man eine Methode (Eventhandler) auswählen die ausgeführt werden soll
            //Mit dem += Operattor kam man eine Methodes auswählen, die nach dem Event horchen soll
            //EVENT += EVENTHANDLERMETHODE DIE AUSGEFÜHRT WERDEN SOLL
            myWort.WordChangedEvent += empf.WordChanged;

            //Das Wort ändern
            myWort.ChangeWord("Alexander");
            myWort.ChangeWord("Larissa");

            Console.ReadKey();
        }
    }

    public class Word
    {
        //variables
        private string myWord;

        //event definieren
        public event WordChangedEventHandler WordChangedEvent;

        //methods
        public void ChangeWord(string text)
        {
            myWord = text;
            Console.WriteLine("Wort: {0}", myWord);
            //Methode aufrufen in der das Event ausgelöst wird, muss man immer machen, ist sicherer
            OnWordChangedEvent();
        }

        //Methode zum auslösen des Events ist sicherer, immer protected und virtual
        protected virtual void OnWordChangedEvent()
        {
            //Überprüfung ob WordChangedEvent Abonnenten hat
            //wenn nicht macht es keinen Sinn das Event auszulösen
            if (WordChangedEvent != null)
            {
                WordChangedEventArgs args = new WordChangedEventArgs();
                args.Word = myWord;
                //Event wird ausgelöst
                //this = Referenz zu dem Objekt in dem wir uns gerade befinden, hier Objekt von Word,
                //Word löst das Event aus
                //args = Daten die transportiert werden sollen
                WordChangedEvent(this, args);
            }
        }  
    }

    public class Benachrichtiger
    {
        //methods
        //EventHandlerMehthode die ausgeführt wird, wenn Event ausgelöst wird
        public void WordChanged(object sender, WordChangedEventArgs eA)
        {
            string newWord = eA.Word;
            Console.WriteLine("Das neue Wort ist: {0}", newWord);
        }
    }

    //EventArgs-Klassen dienen als Transporter,
    //in denen die Werte/Daten in einem Event von Sender an Empfänger transportiert werden
    //EventArgs Objekte sind Transportobjekte (Werte/Daten) von Sender an Empfänger
    public class WordChangedEventArgs : EventArgs
    {
        public string Word { get; set; }
    }
}
