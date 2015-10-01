namespace ProgramacaoLinear
{
    partial class TelaInicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtVariaveis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRestricoes = new System.Windows.Forms.TextBox();
            this.btGerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVariaveis
            // 
            this.txtVariaveis.Location = new System.Drawing.Point(155, 39);
            this.txtVariaveis.Name = "txtVariaveis";
            this.txtVariaveis.Size = new System.Drawing.Size(100, 20);
            this.txtVariaveis.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quantidade de variáveis:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantidade de restrições";
            // 
            // txtRestricoes
            // 
            this.txtRestricoes.Location = new System.Drawing.Point(155, 120);
            this.txtRestricoes.Name = "txtRestricoes";
            this.txtRestricoes.Size = new System.Drawing.Size(100, 20);
            this.txtRestricoes.TabIndex = 3;
            // 
            // btGerar
            // 
            this.btGerar.Location = new System.Drawing.Point(128, 205);
            this.btGerar.Name = "btGerar";
            this.btGerar.Size = new System.Drawing.Size(75, 23);
            this.btGerar.TabIndex = 4;
            this.btGerar.Text = "Gerar";
            this.btGerar.UseVisualStyleBackColor = true;
            this.btGerar.Click += new System.EventHandler(this.btGerar_Click);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 264);
            this.Controls.Add(this.btGerar);
            this.Controls.Add(this.txtRestricoes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVariaveis);
            this.Name = "TelaInicial";
            this.Text = "Início";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVariaveis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRestricoes;
        private System.Windows.Forms.Button btGerar;
    }
}

