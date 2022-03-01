using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Notizbuch
{
    class Notizbuch
    {
        // Datenfelder
        private string title;
        private string text;
        private List<Notiz> notizen = new List<Notiz>();

        // Properties
        public string txtTITLE
        {
            get { return title; }
            set { title = value; }
        }

        public string txtTEXT
        {
            get { return text; }
            set { text = value; }
        }
        // Konstruktor
        public Notizbuch(string title, string text)
        {
            txtTITLE = title;
            txtTEXT = text;
        }

        public Notizbuch()
        {

        }

        // Methoden

        //Eine Notiz hinzufügen
        public void Notizhinzufügen(string title, string text)
        {
            // Eine neue Notiz erzeugen
            Notiz neueNotiz = new Notiz(title, text);

            // Die neue Notiz in die Liste hinzufügen
            notizen.Add(neueNotiz);
        }

        public Notiz[] ladenInOberflaeche()
        {
            return notizen.ToArray();
        }
    }
}
