namespace hello_world2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbnumero1 = new System.Windows.Forms.TextBox();
            this.txbnumero2 = new System.Windows.Forms.TextBox();
            this.lbnumero1 = new System.Windows.Forms.Label();
            this.lbnumero2 = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.lbresultado = new System.Windows.Forms.Label();
            this.btnsubtrair = new System.Windows.Forms.Button();
            this.btnmultplicar = new System.Windows.Forms.Button();
            this.btndividir = new System.Windows.Forms.Button();
            this.btnmaiormenor = new System.Windows.Forms.Button();
            this.lbnumero3 = new System.Windows.Forms.Label();
            this.txbnumero3 = new System.Windows.Forms.TextBox();
            this.lbresultado2 = new System.Windows.Forms.Label();
            this.btnimparpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbnumero1
            // 
            this.txbnumero1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbnumero1.Location = new System.Drawing.Point(28, 69);
            this.txbnumero1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbnumero1.Name = "txbnumero1";
            this.txbnumero1.Size = new System.Drawing.Size(69, 26);
            this.txbnumero1.TabIndex = 10;
            // 
            // txbnumero2
            // 
            this.txbnumero2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbnumero2.Location = new System.Drawing.Point(28, 120);
            this.txbnumero2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbnumero2.Name = "txbnumero2";
            this.txbnumero2.Size = new System.Drawing.Size(69, 26);
            this.txbnumero2.TabIndex = 11;
            // 
            // lbnumero1
            // 
            this.lbnumero1.AutoSize = true;
            this.lbnumero1.Font = new System.Drawing.Font("BankGothic Md BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnumero1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbnumero1.Location = new System.Drawing.Point(20, 48);
            this.lbnumero1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbnumero1.Name = "lbnumero1";
            this.lbnumero1.Size = new System.Drawing.Size(148, 25);
            this.lbnumero1.TabIndex = 12;
            this.lbnumero1.Text = "numero 1";
            this.lbnumero1.Click += new System.EventHandler(this.lbnumero1_Click);
            // 
            // lbnumero2
            // 
            this.lbnumero2.AutoSize = true;
            this.lbnumero2.Font = new System.Drawing.Font("BankGothic Md BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnumero2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbnumero2.Location = new System.Drawing.Point(24, 95);
            this.lbnumero2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbnumero2.Name = "lbnumero2";
            this.lbnumero2.Size = new System.Drawing.Size(148, 25);
            this.lbnumero2.TabIndex = 13;
            this.lbnumero2.Text = "numero 2";
            this.lbnumero2.Click += new System.EventHandler(this.label7_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncalcular.Location = new System.Drawing.Point(28, 167);
            this.btncalcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(123, 37);
            this.btncalcular.TabIndex = 14;
            this.btncalcular.Text = "calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // lbresultado
            // 
            this.lbresultado.AutoSize = true;
            this.lbresultado.BackColor = System.Drawing.Color.Silver;
            this.lbresultado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbresultado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbresultado.Location = new System.Drawing.Point(189, 76);
            this.lbresultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbresultado.Name = "lbresultado";
            this.lbresultado.Size = new System.Drawing.Size(84, 18);
            this.lbresultado.TabIndex = 15;
            this.lbresultado.Text = "resultado";
            // 
            // btnsubtrair
            // 
            this.btnsubtrair.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubtrair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsubtrair.Location = new System.Drawing.Point(28, 208);
            this.btnsubtrair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsubtrair.Name = "btnsubtrair";
            this.btnsubtrair.Size = new System.Drawing.Size(123, 24);
            this.btnsubtrair.TabIndex = 16;
            this.btnsubtrair.Text = "subtrair";
            this.btnsubtrair.UseVisualStyleBackColor = true;
            this.btnsubtrair.Click += new System.EventHandler(this.btnsubtrair_Click);
            // 
            // btnmultplicar
            // 
            this.btnmultplicar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmultplicar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnmultplicar.Location = new System.Drawing.Point(158, 167);
            this.btnmultplicar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnmultplicar.Name = "btnmultplicar";
            this.btnmultplicar.Size = new System.Drawing.Size(123, 37);
            this.btnmultplicar.TabIndex = 17;
            this.btnmultplicar.Text = "multplicar";
            this.btnmultplicar.UseVisualStyleBackColor = true;
            this.btnmultplicar.Click += new System.EventHandler(this.btnmultplicar_Click);
            // 
            // btndividir
            // 
            this.btndividir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndividir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btndividir.Location = new System.Drawing.Point(158, 208);
            this.btndividir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btndividir.Name = "btndividir";
            this.btndividir.Size = new System.Drawing.Size(123, 24);
            this.btndividir.TabIndex = 18;
            this.btndividir.Text = "dividir";
            this.btndividir.UseVisualStyleBackColor = true;
            this.btndividir.Click += new System.EventHandler(this.btndividir_Click);
            // 
            // btnmaiormenor
            // 
            this.btnmaiormenor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmaiormenor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnmaiormenor.Location = new System.Drawing.Point(25, 352);
            this.btnmaiormenor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnmaiormenor.Name = "btnmaiormenor";
            this.btnmaiormenor.Size = new System.Drawing.Size(139, 27);
            this.btnmaiormenor.TabIndex = 19;
            this.btnmaiormenor.Text = "maior menor";
            this.btnmaiormenor.UseVisualStyleBackColor = true;
            this.btnmaiormenor.Click += new System.EventHandler(this.btnmaiormenor_Click);
            // 
            // lbnumero3
            // 
            this.lbnumero3.AutoSize = true;
            this.lbnumero3.Font = new System.Drawing.Font("BankGothic Md BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnumero3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbnumero3.Location = new System.Drawing.Point(20, 262);
            this.lbnumero3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbnumero3.Name = "lbnumero3";
            this.lbnumero3.Size = new System.Drawing.Size(148, 25);
            this.lbnumero3.TabIndex = 20;
            this.lbnumero3.Text = "numero 3";
            // 
            // txbnumero3
            // 
            this.txbnumero3.Location = new System.Drawing.Point(25, 298);
            this.txbnumero3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbnumero3.Name = "txbnumero3";
            this.txbnumero3.Size = new System.Drawing.Size(67, 32);
            this.txbnumero3.TabIndex = 21;
            // 
            // lbresultado2
            // 
            this.lbresultado2.AutoSize = true;
            this.lbresultado2.BackColor = System.Drawing.Color.Silver;
            this.lbresultado2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbresultado2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbresultado2.Location = new System.Drawing.Point(121, 306);
            this.lbresultado2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbresultado2.Name = "lbresultado2";
            this.lbresultado2.Size = new System.Drawing.Size(84, 18);
            this.lbresultado2.TabIndex = 22;
            this.lbresultado2.Text = "resultado";
            // 
            // btnimparpar
            // 
            this.btnimparpar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimparpar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnimparpar.Location = new System.Drawing.Point(25, 407);
            this.btnimparpar.Name = "btnimparpar";
            this.btnimparpar.Size = new System.Drawing.Size(139, 29);
            this.btnimparpar.TabIndex = 24;
            this.btnimparpar.Text = "impar/par";
            this.btnimparpar.UseVisualStyleBackColor = true;
            this.btnimparpar.Click += new System.EventHandler(this.btnimparpar_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(881, 491);
            this.Controls.Add(this.btnimparpar);
            this.Controls.Add(this.lbresultado2);
            this.Controls.Add(this.txbnumero3);
            this.Controls.Add(this.lbnumero3);
            this.Controls.Add(this.btnmaiormenor);
            this.Controls.Add(this.btndividir);
            this.Controls.Add(this.btnmultplicar);
            this.Controls.Add(this.btnsubtrair);
            this.Controls.Add(this.lbresultado);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.lbnumero2);
            this.Controls.Add(this.lbnumero1);
            this.Controls.Add(this.txbnumero2);
            this.Controls.Add(this.txbnumero1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form1";
            this.Text = "multplicar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbnumero1;
        private System.Windows.Forms.TextBox txbnumero2;
        private System.Windows.Forms.Label lbnumero1;
        private System.Windows.Forms.Label lbnumero2;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lbresultado;
        private System.Windows.Forms.Button btnsubtrair;
        private System.Windows.Forms.Button btnmultplicar;
        private System.Windows.Forms.Button btndividir;
        private System.Windows.Forms.Button btnmaiormenor;
        private System.Windows.Forms.Label lbnumero3;
        private System.Windows.Forms.TextBox txbnumero3;
        private System.Windows.Forms.Label lbresultado2;
        private System.Windows.Forms.Button btnimparpar;
    }
}

