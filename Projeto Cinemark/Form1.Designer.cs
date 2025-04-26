namespace Projeto_Cinemark
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
            this.btn_Faturamento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Faturamento
            // 
            this.btn_Faturamento.Location = new System.Drawing.Point(100, 732);
            this.btn_Faturamento.Name = "btn_Faturamento";
            this.btn_Faturamento.Size = new System.Drawing.Size(201, 82);
            this.btn_Faturamento.TabIndex = 0;
            this.btn_Faturamento.Text = "Faturamento";
            this.btn_Faturamento.UseVisualStyleBackColor = true;
            this.btn_Faturamento.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 826);
            this.Controls.Add(this.btn_Faturamento);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Faturamento;
    }
}

