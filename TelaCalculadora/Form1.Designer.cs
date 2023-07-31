namespace TelaCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BotãoSoma = new System.Windows.Forms.Button();
            this.BotãoSubtração = new System.Windows.Forms.Button();
            this.BotãoMulti = new System.Windows.Forms.Button();
            this.BotãoDivisão = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Conta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Font = new System.Drawing.Font("GothicE", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.maskedTextBox1.Font = new System.Drawing.Font("GothicE", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(106, 119);
            this.maskedTextBox1.Mask = "0000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(191, 49);
            this.maskedTextBox1.TabIndex = 1;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digite os Numeros e selecione a operação desejada";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BotãoSoma
            // 
            this.BotãoSoma.BackColor = System.Drawing.Color.Red;
            this.BotãoSoma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BotãoSoma.Font = new System.Drawing.Font("GreekC_IV25", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotãoSoma.Location = new System.Drawing.Point(106, 214);
            this.BotãoSoma.Name = "BotãoSoma";
            this.BotãoSoma.Size = new System.Drawing.Size(77, 38);
            this.BotãoSoma.TabIndex = 3;
            this.BotãoSoma.Text = "+";
            this.BotãoSoma.UseVisualStyleBackColor = false;
            this.BotãoSoma.Click += new System.EventHandler(this.BotãoSoma_Click);
            // 
            // BotãoSubtração
            // 
            this.BotãoSubtração.BackColor = System.Drawing.Color.Red;
            this.BotãoSubtração.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BotãoSubtração.Font = new System.Drawing.Font("GreekC_IV25", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotãoSubtração.Location = new System.Drawing.Point(220, 214);
            this.BotãoSubtração.Name = "BotãoSubtração";
            this.BotãoSubtração.Size = new System.Drawing.Size(77, 38);
            this.BotãoSubtração.TabIndex = 4;
            this.BotãoSubtração.Text = "-";
            this.BotãoSubtração.UseVisualStyleBackColor = false;
            this.BotãoSubtração.Click += new System.EventHandler(this.BotãoSubtração_Click);
            // 
            // BotãoMulti
            // 
            this.BotãoMulti.BackColor = System.Drawing.Color.Red;
            this.BotãoMulti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BotãoMulti.Font = new System.Drawing.Font("GreekC_IV25", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotãoMulti.Location = new System.Drawing.Point(220, 274);
            this.BotãoMulti.Name = "BotãoMulti";
            this.BotãoMulti.Size = new System.Drawing.Size(77, 38);
            this.BotãoMulti.TabIndex = 5;
            this.BotãoMulti.Text = "*";
            this.BotãoMulti.UseVisualStyleBackColor = false;
            this.BotãoMulti.Click += new System.EventHandler(this.BotãoMulti_Click);
            // 
            // BotãoDivisão
            // 
            this.BotãoDivisão.BackColor = System.Drawing.Color.Red;
            this.BotãoDivisão.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BotãoDivisão.Font = new System.Drawing.Font("GreekC_IV25", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotãoDivisão.Location = new System.Drawing.Point(106, 274);
            this.BotãoDivisão.Name = "BotãoDivisão";
            this.BotãoDivisão.Size = new System.Drawing.Size(77, 38);
            this.BotãoDivisão.TabIndex = 6;
            this.BotãoDivisão.Text = "/";
            this.BotãoDivisão.UseVisualStyleBackColor = false;
            this.BotãoDivisão.Click += new System.EventHandler(this.BotãoDivisão_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("GreekC_IV25", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(106, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Conta
            // 
            this.Conta.AutoSize = true;
            this.Conta.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Conta.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Conta.Location = new System.Drawing.Point(18, 393);
            this.Conta.Name = "Conta";
            this.Conta.Size = new System.Drawing.Size(165, 20);
            this.Conta.TabIndex = 8;
            this.Conta.Text = "Operação a ser realizada:\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(400, 550);
            this.Controls.Add(this.Conta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BotãoDivisão);
            this.Controls.Add(this.BotãoMulti);
            this.Controls.Add(this.BotãoSubtração);
            this.Controls.Add(this.BotãoSoma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(416, 589);
            this.MinimumSize = new System.Drawing.Size(416, 589);
            this.Name = "Form1";
            this.Text = "Tela Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BotãoSoma;
        private System.Windows.Forms.Button BotãoSubtração;
        private System.Windows.Forms.Button BotãoMulti;
        private System.Windows.Forms.Button BotãoDivisão;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Conta;
    }
}

