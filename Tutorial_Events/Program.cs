using System;

namespace Tutorial_Events
{
    //Delegaten (Funktionszeiger) definieren, der ein Eventhandler (Methode) darstellt
    public delegate void VideoUploadedEventHandler();

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World, Kaess is the best!");

            Uploader loader = new Uploader();
            Nachrichten mes = new Nachrichten();

            //Mit dem += Operator kan man sagen, mit welcher Methode man das Event abonnieren will
            //Mit dem += Operattor kann man eine Methode (Eventhandler) auswählen die ausgeführt werden soll
            //Mit dem += Operattor kam man eine Methodes auswählen, die nach dem Event horchen soll
            //EVENT += EVENTHANDLERMETHODE DIE AUSGEFÜHRT WERDEN SOLL
            loader.VideoUploaded += mes.MessageParty;

            loader.VideoUpload();

            Console.ReadKey();
        }
    }

    public class Uploader
    {
        //Event definieren
        public event VideoUploadedEventHandler VideoUploaded;

        //Methoden definieren
        public void VideoUpload()
        {
            Console.WriteLine("Das Video wird gerade hochgeladen...");
            //Event soll ausgelöst werden
            //Event benötigt Adresse von Methode die ausgeführt wird, 
            //es wird ein Delegat (Funktionszeiger) benötigt
            VideoUploaded();
        }
    }

    public class Nachrichten
    {
        //Methoden
        //EventHandlerMehthode die ausgeführt wird, wenn Event ausgelöst wird
        public void VideoUploaded()
        {
            Console.WriteLine("Das Video wurde fertig hochgeladen!");
        }

        public void MessageParty()
        {
            Console.WriteLine("Scheiss auf upload, ich will party machen");
        }
    }
}
