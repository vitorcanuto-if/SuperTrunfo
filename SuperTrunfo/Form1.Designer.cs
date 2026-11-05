namespace SuperTrunfo
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
            label1 = new Label();
            label2 = new Label();
            TxtCartaJogador1 = new TextBox();
            TxtCartaJogador2 = new TextBox();
            BtnDistribuirCartas = new Button();
            LblPontosJogador1 = new Label();
            LblPontosJogador2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 84);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 0;
            label1.Text = "Carta Jogador 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(344, 84);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 1;
            label2.Text = "Carta Jogador 2";
            // 
            // TxtCartaJogador1
            // 
            TxtCartaJogador1.Location = new Point(94, 114);
            TxtCartaJogador1.Name = "TxtCartaJogador1";
            TxtCartaJogador1.Size = new Size(89, 23);
            TxtCartaJogador1.TabIndex = 2;
            // 
            // TxtCartaJogador2
            // 
            TxtCartaJogador2.Location = new Point(344, 114);
            TxtCartaJogador2.Name = "TxtCartaJogador2";
            TxtCartaJogador2.Size = new Size(89, 23);
            TxtCartaJogador2.TabIndex = 3;
            // 
            // BtnDistribuirCartas
            // 
            BtnDistribuirCartas.Location = new Point(214, 172);
            BtnDistribuirCartas.Name = "BtnDistribuirCartas";
            BtnDistribuirCartas.Size = new Size(103, 45);
            BtnDistribuirCartas.TabIndex = 4;
            BtnDistribuirCartas.Text = "Distribuir Cartas";
            BtnDistribuirCartas.UseVisualStyleBackColor = true;
            BtnDistribuirCartas.Click += BtnDistribuirCartas_Click;
            // 
            // LblPontosJogador1
            // 
            LblPontosJogador1.AutoSize = true;
            LblPontosJogador1.Location = new Point(113, 152);
            LblPontosJogador1.Name = "LblPontosJogador1";
            LblPontosJogador1.Size = new Size(47, 15);
            LblPontosJogador1.TabIndex = 5;
            LblPontosJogador1.Text = "Pontos:";
            // 
            // LblPontosJogador2
            // 
            LblPontosJogador2.AutoSize = true;
            LblPontosJogador2.Location = new Point(365, 152);
            LblPontosJogador2.Name = "LblPontosJogador2";
            LblPontosJogador2.Size = new Size(47, 15);
            LblPontosJogador2.TabIndex = 6;
            LblPontosJogador2.Text = "Pontos:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 306);
            Controls.Add(LblPontosJogador2);
            Controls.Add(LblPontosJogador1);
            Controls.Add(BtnDistribuirCartas);
            Controls.Add(TxtCartaJogador2);
            Controls.Add(TxtCartaJogador1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "SuperTrunfo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TxtCartaJogador1;
        private TextBox TxtCartaJogador2;
        private Button BtnDistribuirCartas;
        private Label LblPontosJogador1;
        private Label LblPontosJogador2;
    }
}
