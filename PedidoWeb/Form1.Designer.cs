namespace PedidoWeb
{
    partial class Form1
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
            this.btnConexao = new System.Windows.Forms.Button();
            this.tBTeste = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConexao
            // 
            this.btnConexao.Location = new System.Drawing.Point(108, 134);
            this.btnConexao.Name = "btnConexao";
            this.btnConexao.Size = new System.Drawing.Size(111, 23);
            this.btnConexao.TabIndex = 0;
            this.btnConexao.Text = "Testa Conexão";
            this.btnConexao.UseVisualStyleBackColor = true;
            this.btnConexao.Click += new System.EventHandler(this.btnConexao_Click);
            // 
            // tBTeste
            // 
            this.tBTeste.Location = new System.Drawing.Point(72, 199);
            this.tBTeste.Name = "tBTeste";
            this.tBTeste.Size = new System.Drawing.Size(100, 20);
            this.tBTeste.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tBTeste);
            this.Controls.Add(this.btnConexao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConexao;
        private System.Windows.Forms.TextBox tBTeste;

    }
}

