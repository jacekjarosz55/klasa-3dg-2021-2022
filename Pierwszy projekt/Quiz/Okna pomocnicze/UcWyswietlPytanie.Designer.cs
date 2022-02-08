
namespace Quiz.Okna_pomocnicze
{
    partial class UcWyswietlPytanie
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
            this.panelGorny = new System.Windows.Forms.Panel();
            this.panelTrescPytania = new System.Windows.Forms.Panel();
            this.textBoxTestowy = new System.Windows.Forms.TextBox();
            this.labelOdowiedzi = new System.Windows.Forms.Label();
            this.labelTrescPytania = new System.Windows.Forms.Label();
            this.flowLayoutPanelOdpowiedzi = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panelGorny.SuspendLayout();
            this.panelTrescPytania.SuspendLayout();
            this.flowLayoutPanelOdpowiedzi.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGorny
            // 
            this.panelGorny.Controls.Add(this.panelTrescPytania);
            this.panelGorny.Controls.Add(this.labelOdowiedzi);
            this.panelGorny.Controls.Add(this.labelTrescPytania);
            this.panelGorny.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGorny.Location = new System.Drawing.Point(0, 0);
            this.panelGorny.Name = "panelGorny";
            this.panelGorny.Size = new System.Drawing.Size(527, 133);
            this.panelGorny.TabIndex = 0;
            // 
            // panelTrescPytania
            // 
            this.panelTrescPytania.Controls.Add(this.textBoxTestowy);
            this.panelTrescPytania.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTrescPytania.Location = new System.Drawing.Point(0, 15);
            this.panelTrescPytania.Name = "panelTrescPytania";
            this.panelTrescPytania.Size = new System.Drawing.Size(527, 103);
            this.panelTrescPytania.TabIndex = 2;
            // 
            // textBoxTestowy
            // 
            this.textBoxTestowy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTestowy.Location = new System.Drawing.Point(0, 0);
            this.textBoxTestowy.Multiline = true;
            this.textBoxTestowy.Name = "textBoxTestowy";
            this.textBoxTestowy.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxTestowy.Size = new System.Drawing.Size(527, 103);
            this.textBoxTestowy.TabIndex = 0;
            // 
            // labelOdowiedzi
            // 
            this.labelOdowiedzi.AutoSize = true;
            this.labelOdowiedzi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelOdowiedzi.Location = new System.Drawing.Point(0, 118);
            this.labelOdowiedzi.Name = "labelOdowiedzi";
            this.labelOdowiedzi.Size = new System.Drawing.Size(73, 15);
            this.labelOdowiedzi.TabIndex = 1;
            this.labelOdowiedzi.Text = "Odpowiedzi:";
            // 
            // labelTrescPytania
            // 
            this.labelTrescPytania.AutoSize = true;
            this.labelTrescPytania.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTrescPytania.Location = new System.Drawing.Point(0, 0);
            this.labelTrescPytania.Name = "labelTrescPytania";
            this.labelTrescPytania.Size = new System.Drawing.Size(78, 15);
            this.labelTrescPytania.TabIndex = 0;
            this.labelTrescPytania.Text = "Treść pytania:";
            // 
            // flowLayoutPanelOdpowiedzi
            // 
            this.flowLayoutPanelOdpowiedzi.AutoScroll = true;
            this.flowLayoutPanelOdpowiedzi.Controls.Add(this.checkBox1);
            this.flowLayoutPanelOdpowiedzi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelOdpowiedzi.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelOdpowiedzi.Location = new System.Drawing.Point(0, 133);
            this.flowLayoutPanelOdpowiedzi.Name = "flowLayoutPanelOdpowiedzi";
            this.flowLayoutPanelOdpowiedzi.Size = new System.Drawing.Size(527, 161);
            this.flowLayoutPanelOdpowiedzi.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 19);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // UcWyswietlPytanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanelOdpowiedzi);
            this.Controls.Add(this.panelGorny);
            this.Name = "UcWyswietlPytanie";
            this.Size = new System.Drawing.Size(527, 294);
            this.panelGorny.ResumeLayout(false);
            this.panelGorny.PerformLayout();
            this.panelTrescPytania.ResumeLayout(false);
            this.panelTrescPytania.PerformLayout();
            this.flowLayoutPanelOdpowiedzi.ResumeLayout(false);
            this.flowLayoutPanelOdpowiedzi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGorny;
        private System.Windows.Forms.Panel panelTrescPytania;
        private System.Windows.Forms.TextBox textBoxTestowy;
        private System.Windows.Forms.Label labelOdowiedzi;
        private System.Windows.Forms.Label labelTrescPytania;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOdpowiedzi;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
