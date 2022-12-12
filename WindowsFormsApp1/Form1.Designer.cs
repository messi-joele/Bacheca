namespace WindowsFormsApp1
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
            this.nomeTxt = new System.Windows.Forms.TextBox();
            this.CostoTxt = new System.Windows.Forms.TextBox();
            this.descTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateBox = new System.Windows.Forms.DateTimePicker();
            this.aggiungi = new System.Windows.Forms.Button();
            this.Lista = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.Idtxt = new System.Windows.Forms.TextBox();
            this.CercaButton = new System.Windows.Forms.Button();
            this.Modifica = new System.Windows.Forms.Button();
            this.Elimina = new System.Windows.Forms.Button();
            this.Ordina = new System.Windows.Forms.Button();
            this.PrezzoTot = new System.Windows.Forms.Button();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descrizione = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Costo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // nomeTxt
            // 
            this.nomeTxt.Location = new System.Drawing.Point(42, 65);
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(100, 20);
            this.nomeTxt.TabIndex = 0;
            // 
            // CostoTxt
            // 
            this.CostoTxt.Location = new System.Drawing.Point(42, 344);
            this.CostoTxt.Name = "CostoTxt";
            this.CostoTxt.Size = new System.Drawing.Size(100, 20);
            this.CostoTxt.TabIndex = 1;
            // 
            // descTxt
            // 
            this.descTxt.Location = new System.Drawing.Point(42, 157);
            this.descTxt.Name = "descTxt";
            this.descTxt.Size = new System.Drawing.Size(100, 20);
            this.descTxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descrizione";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Prezzo";
            // 
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(42, 257);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(100, 20);
            this.dateBox.TabIndex = 8;
            // 
            // aggiungi
            // 
            this.aggiungi.Location = new System.Drawing.Point(42, 385);
            this.aggiungi.Name = "aggiungi";
            this.aggiungi.Size = new System.Drawing.Size(97, 40);
            this.aggiungi.TabIndex = 9;
            this.aggiungi.Text = "Aggiungi";
            this.aggiungi.UseVisualStyleBackColor = true;
            this.aggiungi.Click += new System.EventHandler(this.aggiungi_Click);
            // 
            // Lista
            // 
            this.Lista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.nome,
            this.Descrizione,
            this.Data,
            this.Costo});
            this.Lista.HideSelection = false;
            this.Lista.Location = new System.Drawing.Point(178, 25);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(380, 400);
            this.Lista.TabIndex = 10;
            this.Lista.UseCompatibleStateImageBehavior = false;
            this.Lista.View = System.Windows.Forms.View.Details;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(593, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Metti Id";
            // 
            // Idtxt
            // 
            this.Idtxt.Location = new System.Drawing.Point(578, 50);
            this.Idtxt.Name = "Idtxt";
            this.Idtxt.Size = new System.Drawing.Size(69, 20);
            this.Idtxt.TabIndex = 12;
            // 
            // CercaButton
            // 
            this.CercaButton.Location = new System.Drawing.Point(675, 50);
            this.CercaButton.Name = "CercaButton";
            this.CercaButton.Size = new System.Drawing.Size(75, 23);
            this.CercaButton.TabIndex = 13;
            this.CercaButton.Text = "Cerca";
            this.CercaButton.UseVisualStyleBackColor = true;
            this.CercaButton.Click += new System.EventHandler(this.CercaButton_Click);
            // 
            // Modifica
            // 
            this.Modifica.Location = new System.Drawing.Point(578, 111);
            this.Modifica.Name = "Modifica";
            this.Modifica.Size = new System.Drawing.Size(75, 23);
            this.Modifica.TabIndex = 14;
            this.Modifica.Text = "Modifica";
            this.Modifica.UseVisualStyleBackColor = true;
            this.Modifica.Click += new System.EventHandler(this.Modifica_Click);
            // 
            // Elimina
            // 
            this.Elimina.Location = new System.Drawing.Point(686, 111);
            this.Elimina.Name = "Elimina";
            this.Elimina.Size = new System.Drawing.Size(75, 23);
            this.Elimina.TabIndex = 15;
            this.Elimina.Text = "Elimina";
            this.Elimina.UseVisualStyleBackColor = true;
            this.Elimina.Click += new System.EventHandler(this.Elimina_Click);
            // 
            // Ordina
            // 
            this.Ordina.Location = new System.Drawing.Point(578, 187);
            this.Ordina.Name = "Ordina";
            this.Ordina.Size = new System.Drawing.Size(75, 23);
            this.Ordina.TabIndex = 16;
            this.Ordina.Text = "Ordina";
            this.Ordina.UseVisualStyleBackColor = true;
            this.Ordina.Click += new System.EventHandler(this.Ordina_Click);
            // 
            // PrezzoTot
            // 
            this.PrezzoTot.Location = new System.Drawing.Point(578, 371);
            this.PrezzoTot.Name = "PrezzoTot";
            this.PrezzoTot.Size = new System.Drawing.Size(123, 23);
            this.PrezzoTot.TabIndex = 17;
            this.PrezzoTot.Text = "Prezzo Totale";
            this.PrezzoTot.UseVisualStyleBackColor = true;
            this.PrezzoTot.Click += new System.EventHandler(this.PrezzoTot_Click);
            // 
            // Id
            // 
            this.Id.Text = "ID";
            this.Id.Width = 50;
            // 
            // nome
            // 
            this.nome.Text = "Nome";
            this.nome.Width = 80;
            // 
            // Descrizione
            // 
            this.Descrizione.Text = "Descrizione";
            this.Descrizione.Width = 90;
            // 
            // Data
            // 
            this.Data.Text = "Data";
            this.Data.Width = 80;
            // 
            // Costo
            // 
            this.Costo.Text = "Costo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PrezzoTot);
            this.Controls.Add(this.Ordina);
            this.Controls.Add(this.Elimina);
            this.Controls.Add(this.Modifica);
            this.Controls.Add(this.CercaButton);
            this.Controls.Add(this.Idtxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.aggiungi);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descTxt);
            this.Controls.Add(this.CostoTxt);
            this.Controls.Add(this.nomeTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nomeTxt;
        private System.Windows.Forms.TextBox CostoTxt;
        private System.Windows.Forms.TextBox descTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateBox;
        private System.Windows.Forms.Button aggiungi;
        private System.Windows.Forms.ListView Lista;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Idtxt;
        private System.Windows.Forms.Button CercaButton;
        private System.Windows.Forms.Button Modifica;
        private System.Windows.Forms.Button Elimina;
        private System.Windows.Forms.Button Ordina;
        private System.Windows.Forms.Button PrezzoTot;
        private System.Windows.Forms.ColumnHeader Descrizione;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.ColumnHeader Costo;
    }
}

