
namespace OOP_Notizbuch
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonNotizErstellen = new System.Windows.Forms.Button();
            this.buttonNotizAnzeigen = new System.Windows.Forms.Button();
            this.buttonNotizLoeschen = new System.Windows.Forms.Button();
            this.textBoxNotiz = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.labelTitel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(47, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Notizbuch";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonNotizErstellen
            // 
            this.buttonNotizErstellen.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonNotizErstellen.Location = new System.Drawing.Point(404, 77);
            this.buttonNotizErstellen.Name = "buttonNotizErstellen";
            this.buttonNotizErstellen.Size = new System.Drawing.Size(258, 39);
            this.buttonNotizErstellen.TabIndex = 2;
            this.buttonNotizErstellen.Text = "Notiz Erstellen";
            this.buttonNotizErstellen.UseVisualStyleBackColor = true;
            this.buttonNotizErstellen.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonNotizAnzeigen
            // 
            this.buttonNotizAnzeigen.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonNotizAnzeigen.Location = new System.Drawing.Point(404, 187);
            this.buttonNotizAnzeigen.Name = "buttonNotizAnzeigen";
            this.buttonNotizAnzeigen.Size = new System.Drawing.Size(258, 39);
            this.buttonNotizAnzeigen.TabIndex = 3;
            this.buttonNotizAnzeigen.Text = "Notiz Anzeigen";
            this.buttonNotizAnzeigen.UseVisualStyleBackColor = true;
            this.buttonNotizAnzeigen.Click += new System.EventHandler(this.buttonNotizAnzeigen_Click);
            // 
            // buttonNotizLoeschen
            // 
            this.buttonNotizLoeschen.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonNotizLoeschen.Location = new System.Drawing.Point(404, 344);
            this.buttonNotizLoeschen.Name = "buttonNotizLoeschen";
            this.buttonNotizLoeschen.Size = new System.Drawing.Size(258, 39);
            this.buttonNotizLoeschen.TabIndex = 4;
            this.buttonNotizLoeschen.Text = "Notiz Löschen";
            this.buttonNotizLoeschen.UseVisualStyleBackColor = true;
            this.buttonNotizLoeschen.Click += new System.EventHandler(this.buttonNotizLoeschen_Click);
            // 
            // textBoxNotiz
            // 
            this.textBoxNotiz.Location = new System.Drawing.Point(112, 86);
            this.textBoxNotiz.Multiline = true;
            this.textBoxNotiz.Name = "textBoxNotiz";
            this.textBoxNotiz.Size = new System.Drawing.Size(258, 27);
            this.textBoxNotiz.TabIndex = 5;
            this.textBoxNotiz.TextChanged += new System.EventHandler(this.textBoxNotiz_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.AccessibleName = "";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(404, 232);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(258, 28);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "Select an Item";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(47, 132);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(323, 253);
            this.richTextBox.TabIndex = 7;
            this.richTextBox.Text = "";
            this.richTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // labelTitel
            // 
            this.labelTitel.AutoSize = true;
            this.labelTitel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitel.Location = new System.Drawing.Point(47, 82);
            this.labelTitel.Name = "labelTitel";
            this.labelTitel.Size = new System.Drawing.Size(56, 28);
            this.labelTitel.TabIndex = 8;
            this.labelTitel.Text = "Title:";
            this.labelTitel.Click += new System.EventHandler(this.labelTitel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTitel);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxNotiz);
            this.Controls.Add(this.buttonNotizLoeschen);
            this.Controls.Add(this.buttonNotizAnzeigen);
            this.Controls.Add(this.buttonNotizErstellen);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Notizbuch";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonNotizErstellen;
        private System.Windows.Forms.Button buttonNotizAnzeigen;
        private System.Windows.Forms.Button buttonNotizLoeschen;
        private System.Windows.Forms.TextBox textBoxNotiz;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Label labelTitel;
    }
}

