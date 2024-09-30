namespace _30092024___Open_Data
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lista = new System.Windows.Forms.ListBox();
            this.ordinapopolarità = new System.Windows.Forms.Button();
            this.ordinadatarilascio = new System.Windows.Forms.Button();
            this.ordinatitolo = new System.Windows.Forms.Button();
            this.ordinavoto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(12, 95);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(776, 394);
            this.lista.TabIndex = 0;
            // 
            // ordinapopolarità
            // 
            this.ordinapopolarità.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordinapopolarità.Location = new System.Drawing.Point(12, 12);
            this.ordinapopolarità.Name = "ordinapopolarità";
            this.ordinapopolarità.Size = new System.Drawing.Size(190, 77);
            this.ordinapopolarità.TabIndex = 1;
            this.ordinapopolarità.Text = "Ordina per popolarità";
            this.ordinapopolarità.UseVisualStyleBackColor = true;
            // 
            // ordinadatarilascio
            // 
            this.ordinadatarilascio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordinadatarilascio.Location = new System.Drawing.Point(208, 12);
            this.ordinadatarilascio.Name = "ordinadatarilascio";
            this.ordinadatarilascio.Size = new System.Drawing.Size(190, 77);
            this.ordinadatarilascio.TabIndex = 2;
            this.ordinadatarilascio.Text = "Ordina per data di rilascio";
            this.ordinadatarilascio.UseVisualStyleBackColor = true;
            // 
            // ordinatitolo
            // 
            this.ordinatitolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordinatitolo.Location = new System.Drawing.Point(404, 12);
            this.ordinatitolo.Name = "ordinatitolo";
            this.ordinatitolo.Size = new System.Drawing.Size(190, 77);
            this.ordinatitolo.TabIndex = 3;
            this.ordinatitolo.Text = "Ordina per titolo";
            this.ordinatitolo.UseVisualStyleBackColor = true;
            // 
            // ordinavoto
            // 
            this.ordinavoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordinavoto.Location = new System.Drawing.Point(600, 12);
            this.ordinavoto.Name = "ordinavoto";
            this.ordinavoto.Size = new System.Drawing.Size(188, 77);
            this.ordinavoto.TabIndex = 4;
            this.ordinavoto.Text = "Ordina per voto";
            this.ordinavoto.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.ordinavoto);
            this.Controls.Add(this.ordinatitolo);
            this.Controls.Add(this.ordinadatarilascio);
            this.Controls.Add(this.ordinapopolarità);
            this.Controls.Add(this.lista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Button ordinapopolarità;
        private System.Windows.Forms.Button ordinadatarilascio;
        private System.Windows.Forms.Button ordinatitolo;
        private System.Windows.Forms.Button ordinavoto;
    }
}

