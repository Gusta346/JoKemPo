namespace Jokempo.UI
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
            btnPedra = new Button();
            lblTitulo = new Label();
            btnPapel = new Button();
            btnTesoura = new Button();
            lblResultado = new Label();
            lblJogador = new Label();
            lblComputador = new Label();
            lblEmpate = new Label();
            SuspendLayout();
            // 
            // btnPedra
            // 
            btnPedra.Location = new Point(154, 91);
            btnPedra.Name = "btnPedra";
            btnPedra.Size = new Size(75, 23);
            btnPedra.TabIndex = 0;
            btnPedra.Text = "Pedra";
            btnPedra.UseVisualStyleBackColor = true;
            btnPedra.Click += btnPedra_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(210, 35);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(164, 30);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "JOGO JOKENPO";
            // 
            // btnPapel
            // 
            btnPapel.Location = new Point(251, 91);
            btnPapel.Name = "btnPapel";
            btnPapel.Size = new Size(75, 23);
            btnPapel.TabIndex = 3;
            btnPapel.Text = "Papel";
            btnPapel.UseVisualStyleBackColor = true;
            btnPapel.Click += btnPapel_Click;
            // 
            // btnTesoura
            // 
            btnTesoura.Location = new Point(346, 91);
            btnTesoura.Name = "btnTesoura";
            btnTesoura.Size = new Size(75, 23);
            btnTesoura.TabIndex = 4;
            btnTesoura.Text = "Tesoura";
            btnTesoura.UseVisualStyleBackColor = true;
            btnTesoura.Click += btnTesoura_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(167, 160);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(62, 15);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "Resultado:";
            // 
            // lblJogador
            // 
            lblJogador.AutoSize = true;
            lblJogador.Location = new Point(179, 191);
            lblJogador.Name = "lblJogador";
            lblJogador.Size = new Size(61, 15);
            lblJogador.TabIndex = 6;
            lblJogador.Text = "Jogador: 0";
            // 
            // lblComputador
            // 
            lblComputador.AutoSize = true;
            lblComputador.Location = new Point(179, 219);
            lblComputador.Name = "lblComputador";
            lblComputador.Size = new Size(87, 15);
            lblComputador.TabIndex = 7;
            lblComputador.Text = "Computador: 0";
            // 
            // lblEmpate
            // 
            lblEmpate.AutoSize = true;
            lblEmpate.Location = new Point(179, 249);
            lblEmpate.Name = "lblEmpate";
            lblEmpate.Size = new Size(64, 15);
            lblEmpate.TabIndex = 8;
            lblEmpate.Text = "Empates: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblEmpate);
            Controls.Add(lblComputador);
            Controls.Add(lblJogador);
            Controls.Add(lblResultado);
            Controls.Add(btnTesoura);
            Controls.Add(btnPapel);
            Controls.Add(lblTitulo);
            Controls.Add(btnPedra);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPedra;
        private Label lblTitulo;
        private Button btnPapel;
        private Button btnTesoura;
        private Label lblResultado;
        private Label lblJogador;
        private Label lblComputador;
        private Label lblEmpate;
    }
}
