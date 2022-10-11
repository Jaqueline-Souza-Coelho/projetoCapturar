
namespace PrintScreenCSharp
{
    partial class frmCaptura
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
            this.btnCapturar = new System.Windows.Forms.Button();
            this.btnCapturarForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(21, 234);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(113, 29);
            this.btnCapturar.TabIndex = 0;
            this.btnCapturar.Text = "Capturar Tela";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // btnCapturarForm
            // 
            this.btnCapturarForm.Location = new System.Drawing.Point(253, 234);
            this.btnCapturarForm.Name = "btnCapturarForm";
            this.btnCapturarForm.Size = new System.Drawing.Size(113, 29);
            this.btnCapturarForm.TabIndex = 1;
            this.btnCapturarForm.Text = "Capturar Formulário";
            this.btnCapturarForm.UseVisualStyleBackColor = true;
            this.btnCapturarForm.Click += new System.EventHandler(this.btnCapturarForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Print Screen";
            // 
            // frmCaptura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(391, 284);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCapturarForm);
            this.Controls.Add(this.btnCapturar);
            this.Name = "frmCaptura";
            this.Text = "Capturar Imagem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Button btnCapturarForm;
        private System.Windows.Forms.Label label1;
    }
}

