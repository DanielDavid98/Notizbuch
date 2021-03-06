using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace OOP_Notizbuch
{
    public partial class Form1 : Form
    {
        // Datenfeld
        Notizbuch einNotizbuch = new Notizbuch();
        Notiz eineNotiz = new Notiz();
        public Form1()
        {
            InitializeComponent();
        }

        public static void Input(String[] args)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Hinzufügen einer Notiz + Fehlermeldung
            if (textBoxNotiz.TextLength.Equals(0))
            {
                MessageBox.Show("Please enter a title");
            }
            else if (richTextBox.TextLength.Equals(0))
            {
                MessageBox.Show("Please enter a text");
            }
            else
            {
                einNotizbuch.Notizhinzufügen(textBoxNotiz.Text, richTextBox.Text);
                comboBox1.Items.Add(textBoxNotiz.Text);
                richTextBox.Clear();
                textBoxNotiz.Clear();
            }
            if (!File.Exists("Notizen.txt")) // If file does not exists
            {
                File.Create("Notizen.txt").Close(); // Create file
                using (StreamWriter sw = File.AppendText("Notizen.txt"))
                {
                    sw.WriteLine(eineNotiz); // Write text to .txt file
                }
            }
            else // If file already exists
            {
                File.WriteAllText("Notizen.txt", String.Empty); // Clear file
                using (StreamWriter sw = File.AppendText("Notizen.txt"))
                {
                    sw.WriteLine(eineNotiz); // Write text to .txt file
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNotiz_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelTitel_Click(object sender, EventArgs e)
        {

        }

        private void buttonNotizAnzeigen_Click(object sender, EventArgs e)
        {
            // Methode die nach Auswahl und betätigen des Buttons den
            // Titel aus der comboBox1 und den Text anzeigt.

            // 1. Wähle einen Titel aus der comboBox1
            // 2. zeige mir den Titel in textBoxNotiz an
            // 3. zeige mir den dazugehörigen Text in der richTextBox an
           
           /* textBoxNotiz.Text = string.Join(Environment.NewLine, File.ReadLines("Notizen.txt"));
            richTextBox.Text = string.Join(Environment.NewLine, File.ReadLines("Notizen.txt"));*/
            
        }
        private void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            //textBoxNotiz.ToString(einNotizbuch.ladenInOberflaeche());
            //txtValue.Text = comboBox1.SelectedValue.ToString();
        }

        private void buttonNotizLoeschen_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Hier soll der Titel angezeigt werden sobald gespeichert wurde
            // um diesen dann anschließend auswählen und aufrufen zu können.
        }
    }
}
