
namespace Przelicznik
{
    partial class Oknoglowne
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Oknoglowne));
            this.comboBoxRodzaj = new System.Windows.Forms.ComboBox();
            this.Rodzaj = new System.Windows.Forms.Label();
            this.comboBoxZrodlowa = new System.Windows.Forms.ComboBox();
            this.comboBoxDocelowa = new System.Windows.Forms.ComboBox();
            this.JednostkaZrodlowa = new System.Windows.Forms.Label();
            this.JednostkaDocelowa = new System.Windows.Forms.Label();
            this.buttonPrzeliczanie = new System.Windows.Forms.Button();
            this.textBoxWartosc = new System.Windows.Forms.TextBox();
            this.Wartosc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxRodzaj
            // 
            this.comboBoxRodzaj.FormattingEnabled = true;
            this.comboBoxRodzaj.Location = new System.Drawing.Point(12, 39);
            this.comboBoxRodzaj.Name = "comboBoxRodzaj";
            this.comboBoxRodzaj.Size = new System.Drawing.Size(749, 21);
            this.comboBoxRodzaj.TabIndex = 0;
            // 
            // Rodzaj
            // 
            this.Rodzaj.AutoSize = true;
            this.Rodzaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Rodzaj.Location = new System.Drawing.Point(9, 21);
            this.Rodzaj.Name = "Rodzaj";
            this.Rodzaj.Size = new System.Drawing.Size(49, 15);
            this.Rodzaj.TabIndex = 1;
            this.Rodzaj.Text = "Rodzaj:";
            // 
            // comboBoxZrodlowa
            // 
            this.comboBoxZrodlowa.FormattingEnabled = true;
            this.comboBoxZrodlowa.Location = new System.Drawing.Point(12, 109);
            this.comboBoxZrodlowa.Name = "comboBoxZrodlowa";
            this.comboBoxZrodlowa.Size = new System.Drawing.Size(749, 21);
            this.comboBoxZrodlowa.TabIndex = 2;
            // 
            // comboBoxDocelowa
            // 
            this.comboBoxDocelowa.FormattingEnabled = true;
            this.comboBoxDocelowa.Location = new System.Drawing.Point(12, 194);
            this.comboBoxDocelowa.Name = "comboBoxDocelowa";
            this.comboBoxDocelowa.Size = new System.Drawing.Size(749, 21);
            this.comboBoxDocelowa.TabIndex = 3;
            // 
            // JednostkaZrodlowa
            // 
            this.JednostkaZrodlowa.AutoSize = true;
            this.JednostkaZrodlowa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.JednostkaZrodlowa.Location = new System.Drawing.Point(9, 91);
            this.JednostkaZrodlowa.Name = "JednostkaZrodlowa";
            this.JednostkaZrodlowa.Size = new System.Drawing.Size(123, 15);
            this.JednostkaZrodlowa.TabIndex = 4;
            this.JednostkaZrodlowa.Text = "Jednostka Źródłowa: ";
            // 
            // JednostkaDocelowa
            // 
            this.JednostkaDocelowa.AutoSize = true;
            this.JednostkaDocelowa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.JednostkaDocelowa.Location = new System.Drawing.Point(9, 178);
            this.JednostkaDocelowa.Name = "JednostkaDocelowa";
            this.JednostkaDocelowa.Size = new System.Drawing.Size(124, 15);
            this.JednostkaDocelowa.TabIndex = 5;
            this.JednostkaDocelowa.Text = "Jednostka Docelowa:";
            // 
            // buttonPrzeliczanie
            // 
            this.buttonPrzeliczanie.Location = new System.Drawing.Point(393, 264);
            this.buttonPrzeliczanie.Name = "buttonPrzeliczanie";
            this.buttonPrzeliczanie.Size = new System.Drawing.Size(198, 70);
            this.buttonPrzeliczanie.TabIndex = 6;
            this.buttonPrzeliczanie.Text = "Przelicz";
            this.buttonPrzeliczanie.UseVisualStyleBackColor = true;
            // 
            // textBoxWartosc
            // 
            this.textBoxWartosc.Location = new System.Drawing.Point(33, 291);
            this.textBoxWartosc.Name = "textBoxWartosc";
            this.textBoxWartosc.Size = new System.Drawing.Size(310, 20);
            this.textBoxWartosc.TabIndex = 7;
            // 
            // Wartosc
            // 
            this.Wartosc.AutoSize = true;
            this.Wartosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wartosc.Location = new System.Drawing.Point(9, 264);
            this.Wartosc.Name = "Wartosc";
            this.Wartosc.Size = new System.Drawing.Size(54, 15);
            this.Wartosc.TabIndex = 8;
            this.Wartosc.Text = "Wartość:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(9, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Wynik:";
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelText.Location = new System.Drawing.Point(173, 402);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(337, 39);
            this.labelText.TabIndex = 10;
            this.labelText.Text = "Test Text = Test Text";
            // 
            // Oknoglowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 505);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Wartosc);
            this.Controls.Add(this.textBoxWartosc);
            this.Controls.Add(this.buttonPrzeliczanie);
            this.Controls.Add(this.JednostkaDocelowa);
            this.Controls.Add(this.JednostkaZrodlowa);
            this.Controls.Add(this.comboBoxDocelowa);
            this.Controls.Add(this.comboBoxZrodlowa);
            this.Controls.Add(this.Rodzaj);
            this.Controls.Add(this.comboBoxRodzaj);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Oknoglowne";
            this.Text = "Przelicznik Walut";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxRodzaj;
        private System.Windows.Forms.Label Rodzaj;
        private System.Windows.Forms.ComboBox comboBoxZrodlowa;
        private System.Windows.Forms.ComboBox comboBoxDocelowa;
        private System.Windows.Forms.Label JednostkaZrodlowa;
        private System.Windows.Forms.Label JednostkaDocelowa;
        private System.Windows.Forms.Button buttonPrzeliczanie;
        private System.Windows.Forms.TextBox textBoxWartosc;
        private System.Windows.Forms.Label Wartosc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelText;
    }
}

