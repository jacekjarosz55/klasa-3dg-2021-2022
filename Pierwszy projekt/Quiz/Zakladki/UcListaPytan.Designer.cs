
namespace Quiz.Zakladki
{
    partial class UcListaPytan
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelListaPytan = new System.Windows.Forms.Label();
            this.comboBoxListaPytan = new System.Windows.Forms.ComboBox();
            this.ucWyswietlPytanie = new Quiz.Okna_pomocnicze.UcWyswietlPytanie();
            this.buttonUsunPytanie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelListaPytan
            // 
            this.labelListaPytan.AutoSize = true;
            this.labelListaPytan.Location = new System.Drawing.Point(3, 0);
            this.labelListaPytan.Name = "labelListaPytan";
            this.labelListaPytan.Size = new System.Drawing.Size(64, 15);
            this.labelListaPytan.TabIndex = 0;
            this.labelListaPytan.Text = "Lista pytań";
            // 
            // comboBoxListaPytan
            // 
            this.comboBoxListaPytan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxListaPytan.FormattingEnabled = true;
            this.comboBoxListaPytan.Location = new System.Drawing.Point(3, 18);
            this.comboBoxListaPytan.Name = "comboBoxListaPytan";
            this.comboBoxListaPytan.Size = new System.Drawing.Size(121, 23);
            this.comboBoxListaPytan.TabIndex = 1;
            this.comboBoxListaPytan.SelectedIndexChanged += new System.EventHandler(this.comboBoxListaPytan_SelectedIndexChanged);
            // 
            // ucWyswietlPytanie
            // 
            this.ucWyswietlPytanie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucWyswietlPytanie.Location = new System.Drawing.Point(0, 73);
            this.ucWyswietlPytanie.Name = "ucWyswietlPytanie";
            this.ucWyswietlPytanie.Size = new System.Drawing.Size(390, 354);
            this.ucWyswietlPytanie.TabIndex = 2;
            // 
            // buttonUsunPytanie
            // 
            this.buttonUsunPytanie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUsunPytanie.Location = new System.Drawing.Point(162, 18);
            this.buttonUsunPytanie.Name = "buttonUsunPytanie";
            this.buttonUsunPytanie.Size = new System.Drawing.Size(105, 49);
            this.buttonUsunPytanie.TabIndex = 3;
            this.buttonUsunPytanie.Text = "Usuń pytanie";
            this.buttonUsunPytanie.UseVisualStyleBackColor = true;
            this.buttonUsunPytanie.Click += new System.EventHandler(this.buttonUsunPytanie_Click);
            // 
            // UcListaPytan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonUsunPytanie);
            this.Controls.Add(this.ucWyswietlPytanie);
            this.Controls.Add(this.comboBoxListaPytan);
            this.Controls.Add(this.labelListaPytan);
            this.Name = "UcListaPytan";
            this.Size = new System.Drawing.Size(390, 427);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelListaPytan;
        private System.Windows.Forms.ComboBox comboBoxListaPytan;
        private Okna_pomocnicze.UcWyswietlPytanie ucWyswietlPytanie;
        private System.Windows.Forms.Button buttonUsunPytanie;
    }
}
