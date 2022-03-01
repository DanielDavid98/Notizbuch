using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Notizbuch
{
    class Notiz
    {
        // Datenfelder
        private string title;
        private string text;

        // Properties
        public string TITLE
        {
            get { return title; }
            set { title = value; }
        }

        public string TEXT
        {
            get { return text; }
            set { text = value; }
        }

        // Konstruktor
        public Notiz (string p_title, string p_text)
        {
            TITLE = p_title;
            TEXT = p_text;
        }

        public Notiz()
        {

        }

        // Methoden
        public override string ToString()
        {
            return this.TITLE;
        }

        /*public override string ToString()
        {
            return this.TEXT;
        }*/
    }
}
