namespace Jogo_De_Adivinhacao
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_inuciado = new Label();
            lbl_escolha = new Label();
            txt_1 = new TextBox();
            btn_Adivinhe = new Button();
            lbl_Resultado = new Label();
            btn_Reiniciar = new Button();
            SuspendLayout();
            // 
            // lbl_inuciado
            // 
            lbl_inuciado.AutoSize = true;
            lbl_inuciado.Font = new Font("Cooper Black", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_inuciado.Location = new Point(233, 56);
            lbl_inuciado.Name = "lbl_inuciado";
            lbl_inuciado.Size = new Size(385, 40);
            lbl_inuciado.TabIndex = 0;
            lbl_inuciado.Text = "Jogo de Adivinhação";
            // 
            // lbl_escolha
            // 
            lbl_escolha.AutoSize = true;
            lbl_escolha.Font = new Font("Castellar", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_escolha.Location = new Point(164, 123);
            lbl_escolha.Name = "lbl_escolha";
            lbl_escolha.Size = new Size(525, 23);
            lbl_escolha.TabIndex = 1;
            lbl_escolha.Text = "Escolha um número qualquer de 1 à 100";
            // 
            // txt_1
            // 
            txt_1.BackColor = SystemColors.Info;
            txt_1.ForeColor = Color.Red;
            txt_1.Location = new Point(346, 163);
            txt_1.Name = "txt_1";
            txt_1.Size = new Size(78, 23);
            txt_1.TabIndex = 2;
            txt_1.TextChanged += txt_1_TextChanged;
            // 
            // btn_Adivinhe
            // 
            btn_Adivinhe.BackColor = Color.Red;
            btn_Adivinhe.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Adivinhe.ForeColor = Color.GhostWhite;
            btn_Adivinhe.Location = new Point(336, 192);
            btn_Adivinhe.Name = "btn_Adivinhe";
            btn_Adivinhe.Size = new Size(101, 38);
            btn_Adivinhe.TabIndex = 3;
            btn_Adivinhe.Text = "ADIVINHE";
            btn_Adivinhe.UseVisualStyleBackColor = false;
            btn_Adivinhe.Click += btn_Adivinhe_Click;
            // 
            // lbl_Resultado
            // 
            lbl_Resultado.AutoSize = true;
            lbl_Resultado.Font = new Font("Castellar", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Resultado.Location = new Point(246, 277);
            lbl_Resultado.Name = "lbl_Resultado";
            lbl_Resultado.Size = new Size(0, 23);
            lbl_Resultado.TabIndex = 4;
            // 
            // btn_Reiniciar
            // 
            btn_Reiniciar.Location = new Point(336, 236);
            btn_Reiniciar.Name = "btn_Reiniciar";
            btn_Reiniciar.Size = new Size(100, 23);
            btn_Reiniciar.TabIndex = 5;
            btn_Reiniciar.Text = "Reiniciar o Jogo\r\n";
            btn_Reiniciar.UseVisualStyleBackColor = true;
            btn_Reiniciar.Click += btn_Reiniciar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 545);
            Controls.Add(btn_Reiniciar);
            Controls.Add(lbl_Resultado);
            Controls.Add(btn_Adivinhe);
            Controls.Add(txt_1);
            Controls.Add(lbl_escolha);
            Controls.Add(lbl_inuciado);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_inuciado;
        private Label lbl_escolha;
        private TextBox txt_1;
        private Button btn_Adivinhe;
        private Label lbl_Resultado;
        private Button btn_Reiniciar;
    }
}