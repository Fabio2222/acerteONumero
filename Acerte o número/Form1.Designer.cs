
namespace Acerte_o_número
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
            this.label1 = new System.Windows.Forms.Label();
            this.text_numero = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label_informacao = new System.Windows.Forms.Label();
            this.cmd_iniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // text_numero
            // 
            this.text_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_numero.Location = new System.Drawing.Point(101, 116);
            this.text_numero.Name = "text_numero";
            this.text_numero.Size = new System.Drawing.Size(117, 29);
            this.text_numero.TabIndex = 2;
            this.text_numero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_numero_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 53);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label_informacao
            // 
            this.label_informacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_informacao.Location = new System.Drawing.Point(12, 9);
            this.label_informacao.Name = "label_informacao";
            this.label_informacao.Size = new System.Drawing.Size(294, 98);
            this.label_informacao.TabIndex = 0;
            this.label_informacao.Text = "label1";
            this.label_informacao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmd_iniciar
            // 
            this.cmd_iniciar.Location = new System.Drawing.Point(101, 170);
            this.cmd_iniciar.Name = "cmd_iniciar";
            this.cmd_iniciar.Size = new System.Drawing.Size(117, 50);
            this.cmd_iniciar.TabIndex = 4;
            this.cmd_iniciar.Text = "Iniciar";
            this.cmd_iniciar.UseVisualStyleBackColor = true;
            this.cmd_iniciar.Click += new System.EventHandler(this.cmd_iniciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 261);
            this.Controls.Add(this.cmd_iniciar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.text_numero);
            this.Controls.Add(this.label_informacao);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_numero;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_informacao;
        private System.Windows.Forms.Button cmd_iniciar;
    }
}

