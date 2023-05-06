namespace Jogo_da_Velha
{
    partial class frm_JogoDaVelha
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
            this.pnl_top = new System.Windows.Forms.Panel();
            this.gb_Empate = new System.Windows.Forms.GroupBox();
            this.lb_Empate = new System.Windows.Forms.Label();
            this.bt_Sair = new System.Windows.Forms.Button();
            this.bt_Reiniciar = new System.Windows.Forms.Button();
            this.bt_Iniciar = new System.Windows.Forms.Button();
            this.gb_Placar = new System.Windows.Forms.GroupBox();
            this.lb_Jogador2 = new System.Windows.Forms.Label();
            this.lb_Joagor1 = new System.Windows.Forms.Label();
            this.gb_Opcao = new System.Windows.Forms.GroupBox();
            this.rb_O = new System.Windows.Forms.RadioButton();
            this.rb_X = new System.Windows.Forms.RadioButton();
            this.gb_Jogadores = new System.Windows.Forms.GroupBox();
            this.tb_Jogador2 = new System.Windows.Forms.TextBox();
            this.tb_Jogador1 = new System.Windows.Forms.TextBox();
            this.lb_Jogador_2 = new System.Windows.Forms.Label();
            this.lb_Jogador_1 = new System.Windows.Forms.Label();
            this.pnl_botao = new System.Windows.Forms.Panel();
            this.bt_9 = new System.Windows.Forms.Button();
            this.bt_8 = new System.Windows.Forms.Button();
            this.bt_7 = new System.Windows.Forms.Button();
            this.bt_6 = new System.Windows.Forms.Button();
            this.bt_5 = new System.Windows.Forms.Button();
            this.bt_4 = new System.Windows.Forms.Button();
            this.bt_3 = new System.Windows.Forms.Button();
            this.bt_2 = new System.Windows.Forms.Button();
            this.bt_1 = new System.Windows.Forms.Button();
            this.gb_Hankimg = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_top.SuspendLayout();
            this.gb_Empate.SuspendLayout();
            this.gb_Placar.SuspendLayout();
            this.gb_Opcao.SuspendLayout();
            this.gb_Jogadores.SuspendLayout();
            this.pnl_botao.SuspendLayout();
            this.gb_Hankimg.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pnl_top.Controls.Add(this.gb_Empate);
            this.pnl_top.Controls.Add(this.bt_Sair);
            this.pnl_top.Controls.Add(this.bt_Reiniciar);
            this.pnl_top.Controls.Add(this.bt_Iniciar);
            this.pnl_top.Controls.Add(this.gb_Placar);
            this.pnl_top.Controls.Add(this.gb_Opcao);
            this.pnl_top.Controls.Add(this.gb_Jogadores);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.ForeColor = System.Drawing.Color.Black;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(697, 205);
            this.pnl_top.TabIndex = 0;
            // 
            // gb_Empate
            // 
            this.gb_Empate.BackColor = System.Drawing.Color.White;
            this.gb_Empate.Controls.Add(this.lb_Empate);
            this.gb_Empate.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Empate.Location = new System.Drawing.Point(485, 12);
            this.gb_Empate.Name = "gb_Empate";
            this.gb_Empate.Size = new System.Drawing.Size(187, 100);
            this.gb_Empate.TabIndex = 7;
            this.gb_Empate.TabStop = false;
            this.gb_Empate.Text = "Empate";
            this.gb_Empate.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // lb_Empate
            // 
            this.lb_Empate.AutoSize = true;
            this.lb_Empate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Empate.Location = new System.Drawing.Point(21, 44);
            this.lb_Empate.Name = "lb_Empate";
            this.lb_Empate.Size = new System.Drawing.Size(0, 18);
            this.lb_Empate.TabIndex = 2;
            // 
            // bt_Sair
            // 
            this.bt_Sair.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Sair.Location = new System.Drawing.Point(569, 156);
            this.bt_Sair.Name = "bt_Sair";
            this.bt_Sair.Size = new System.Drawing.Size(103, 41);
            this.bt_Sair.TabIndex = 6;
            this.bt_Sair.Text = "Sair";
            this.bt_Sair.UseVisualStyleBackColor = true;
            this.bt_Sair.Click += new System.EventHandler(this.button3_Click);
            // 
            // bt_Reiniciar
            // 
            this.bt_Reiniciar.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Reiniciar.Location = new System.Drawing.Point(459, 156);
            this.bt_Reiniciar.Name = "bt_Reiniciar";
            this.bt_Reiniciar.Size = new System.Drawing.Size(104, 41);
            this.bt_Reiniciar.TabIndex = 5;
            this.bt_Reiniciar.Text = "Reiniciar";
            this.bt_Reiniciar.UseVisualStyleBackColor = true;
            this.bt_Reiniciar.Click += new System.EventHandler(this.bt_Reiniciar_Click);
            // 
            // bt_Iniciar
            // 
            this.bt_Iniciar.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Iniciar.Location = new System.Drawing.Point(357, 156);
            this.bt_Iniciar.Name = "bt_Iniciar";
            this.bt_Iniciar.Size = new System.Drawing.Size(96, 41);
            this.bt_Iniciar.TabIndex = 4;
            this.bt_Iniciar.Text = "Iniciar";
            this.bt_Iniciar.UseVisualStyleBackColor = true;
            this.bt_Iniciar.Click += new System.EventHandler(this.bt_Iniciar_Click);
            // 
            // gb_Placar
            // 
            this.gb_Placar.BackColor = System.Drawing.Color.White;
            this.gb_Placar.Controls.Add(this.lb_Jogador2);
            this.gb_Placar.Controls.Add(this.lb_Joagor1);
            this.gb_Placar.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Placar.Location = new System.Drawing.Point(248, 12);
            this.gb_Placar.Name = "gb_Placar";
            this.gb_Placar.Size = new System.Drawing.Size(231, 100);
            this.gb_Placar.TabIndex = 3;
            this.gb_Placar.TabStop = false;
            this.gb_Placar.Text = "Placar";
            // 
            // lb_Jogador2
            // 
            this.lb_Jogador2.AutoSize = true;
            this.lb_Jogador2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Jogador2.Location = new System.Drawing.Point(16, 68);
            this.lb_Jogador2.Name = "lb_Jogador2";
            this.lb_Jogador2.Size = new System.Drawing.Size(0, 18);
            this.lb_Jogador2.TabIndex = 4;
            // 
            // lb_Joagor1
            // 
            this.lb_Joagor1.AutoSize = true;
            this.lb_Joagor1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Joagor1.Location = new System.Drawing.Point(16, 32);
            this.lb_Joagor1.Name = "lb_Joagor1";
            this.lb_Joagor1.Size = new System.Drawing.Size(0, 18);
            this.lb_Joagor1.TabIndex = 3;
            // 
            // gb_Opcao
            // 
            this.gb_Opcao.BackColor = System.Drawing.Color.White;
            this.gb_Opcao.Controls.Add(this.rb_O);
            this.gb_Opcao.Controls.Add(this.rb_X);
            this.gb_Opcao.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Opcao.Location = new System.Drawing.Point(12, 118);
            this.gb_Opcao.Name = "gb_Opcao";
            this.gb_Opcao.Size = new System.Drawing.Size(148, 76);
            this.gb_Opcao.TabIndex = 3;
            this.gb_Opcao.TabStop = false;
            this.gb_Opcao.Text = "Opções";
            // 
            // rb_O
            // 
            this.rb_O.AutoSize = true;
            this.rb_O.Location = new System.Drawing.Point(84, 35);
            this.rb_O.Name = "rb_O";
            this.rb_O.Size = new System.Drawing.Size(44, 32);
            this.rb_O.TabIndex = 1;
            this.rb_O.Text = "O";
            this.rb_O.UseVisualStyleBackColor = true;
            // 
            // rb_X
            // 
            this.rb_X.AutoSize = true;
            this.rb_X.Checked = true;
            this.rb_X.Location = new System.Drawing.Point(6, 35);
            this.rb_X.Name = "rb_X";
            this.rb_X.Size = new System.Drawing.Size(43, 32);
            this.rb_X.TabIndex = 0;
            this.rb_X.TabStop = true;
            this.rb_X.Text = "X";
            this.rb_X.UseVisualStyleBackColor = true;
            // 
            // gb_Jogadores
            // 
            this.gb_Jogadores.BackColor = System.Drawing.Color.White;
            this.gb_Jogadores.Controls.Add(this.tb_Jogador2);
            this.gb_Jogadores.Controls.Add(this.tb_Jogador1);
            this.gb_Jogadores.Controls.Add(this.lb_Jogador_2);
            this.gb_Jogadores.Controls.Add(this.lb_Jogador_1);
            this.gb_Jogadores.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Jogadores.Location = new System.Drawing.Point(12, 12);
            this.gb_Jogadores.Name = "gb_Jogadores";
            this.gb_Jogadores.Size = new System.Drawing.Size(230, 100);
            this.gb_Jogadores.TabIndex = 2;
            this.gb_Jogadores.TabStop = false;
            this.gb_Jogadores.Text = "Jogadores";
            // 
            // tb_Jogador2
            // 
            this.tb_Jogador2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Jogador2.Location = new System.Drawing.Point(6, 68);
            this.tb_Jogador2.Name = "tb_Jogador2";
            this.tb_Jogador2.Size = new System.Drawing.Size(177, 27);
            this.tb_Jogador2.TabIndex = 9;
            // 
            // tb_Jogador1
            // 
            this.tb_Jogador1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Jogador1.Location = new System.Drawing.Point(6, 35);
            this.tb_Jogador1.Name = "tb_Jogador1";
            this.tb_Jogador1.Size = new System.Drawing.Size(177, 27);
            this.tb_Jogador1.TabIndex = 8;
            // 
            // lb_Jogador_2
            // 
            this.lb_Jogador_2.AutoSize = true;
            this.lb_Jogador_2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Jogador_2.Location = new System.Drawing.Point(3, 63);
            this.lb_Jogador_2.Name = "lb_Jogador_2";
            this.lb_Jogador_2.Size = new System.Drawing.Size(0, 18);
            this.lb_Jogador_2.TabIndex = 5;
            // 
            // lb_Jogador_1
            // 
            this.lb_Jogador_1.AutoSize = true;
            this.lb_Jogador_1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Jogador_1.Location = new System.Drawing.Point(3, 35);
            this.lb_Jogador_1.Name = "lb_Jogador_1";
            this.lb_Jogador_1.Size = new System.Drawing.Size(0, 18);
            this.lb_Jogador_1.TabIndex = 4;
            // 
            // pnl_botao
            // 
            this.pnl_botao.Controls.Add(this.gb_Hankimg);
            this.pnl_botao.Controls.Add(this.bt_9);
            this.pnl_botao.Controls.Add(this.bt_8);
            this.pnl_botao.Controls.Add(this.bt_7);
            this.pnl_botao.Controls.Add(this.bt_6);
            this.pnl_botao.Controls.Add(this.bt_5);
            this.pnl_botao.Controls.Add(this.bt_4);
            this.pnl_botao.Controls.Add(this.bt_3);
            this.pnl_botao.Controls.Add(this.bt_2);
            this.pnl_botao.Controls.Add(this.bt_1);
            this.pnl_botao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_botao.Enabled = false;
            this.pnl_botao.ForeColor = System.Drawing.Color.Black;
            this.pnl_botao.Location = new System.Drawing.Point(0, 205);
            this.pnl_botao.Name = "pnl_botao";
            this.pnl_botao.Size = new System.Drawing.Size(697, 284);
            this.pnl_botao.TabIndex = 1;
            // 
            // bt_9
            // 
            this.bt_9.BackColor = System.Drawing.Color.Maroon;
            this.bt_9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_9.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_9.Location = new System.Drawing.Point(248, 174);
            this.bt_9.Name = "bt_9";
            this.bt_9.Size = new System.Drawing.Size(92, 77);
            this.bt_9.TabIndex = 13;
            this.bt_9.UseVisualStyleBackColor = false;
            this.bt_9.Click += new System.EventHandler(this.bt_9_Click);
            // 
            // bt_8
            // 
            this.bt_8.BackColor = System.Drawing.Color.Maroon;
            this.bt_8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_8.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_8.Location = new System.Drawing.Point(159, 174);
            this.bt_8.Name = "bt_8";
            this.bt_8.Size = new System.Drawing.Size(92, 77);
            this.bt_8.TabIndex = 12;
            this.bt_8.UseVisualStyleBackColor = false;
            this.bt_8.Click += new System.EventHandler(this.bt_8_Click);
            // 
            // bt_7
            // 
            this.bt_7.BackColor = System.Drawing.Color.Maroon;
            this.bt_7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_7.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_7.Location = new System.Drawing.Point(70, 174);
            this.bt_7.Name = "bt_7";
            this.bt_7.Size = new System.Drawing.Size(92, 77);
            this.bt_7.TabIndex = 11;
            this.bt_7.UseVisualStyleBackColor = false;
            this.bt_7.Click += new System.EventHandler(this.bt_7_Click);
            // 
            // bt_6
            // 
            this.bt_6.BackColor = System.Drawing.Color.Maroon;
            this.bt_6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_6.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_6.Location = new System.Drawing.Point(248, 102);
            this.bt_6.Name = "bt_6";
            this.bt_6.Size = new System.Drawing.Size(92, 77);
            this.bt_6.TabIndex = 10;
            this.bt_6.UseVisualStyleBackColor = false;
            this.bt_6.Click += new System.EventHandler(this.bt_6_Click);
            // 
            // bt_5
            // 
            this.bt_5.BackColor = System.Drawing.Color.Maroon;
            this.bt_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_5.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_5.Location = new System.Drawing.Point(159, 102);
            this.bt_5.Name = "bt_5";
            this.bt_5.Size = new System.Drawing.Size(92, 77);
            this.bt_5.TabIndex = 9;
            this.bt_5.UseVisualStyleBackColor = false;
            this.bt_5.Click += new System.EventHandler(this.bt_5_Click);
            // 
            // bt_4
            // 
            this.bt_4.BackColor = System.Drawing.Color.Maroon;
            this.bt_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_4.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_4.Location = new System.Drawing.Point(70, 102);
            this.bt_4.Name = "bt_4";
            this.bt_4.Size = new System.Drawing.Size(92, 77);
            this.bt_4.TabIndex = 8;
            this.bt_4.UseVisualStyleBackColor = false;
            this.bt_4.Click += new System.EventHandler(this.bt_4_Click);
            // 
            // bt_3
            // 
            this.bt_3.BackColor = System.Drawing.Color.Maroon;
            this.bt_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_3.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_3.Location = new System.Drawing.Point(248, 30);
            this.bt_3.Name = "bt_3";
            this.bt_3.Size = new System.Drawing.Size(92, 77);
            this.bt_3.TabIndex = 7;
            this.bt_3.UseVisualStyleBackColor = false;
            this.bt_3.Click += new System.EventHandler(this.bt_3_Click);
            // 
            // bt_2
            // 
            this.bt_2.BackColor = System.Drawing.Color.Maroon;
            this.bt_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_2.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_2.Location = new System.Drawing.Point(159, 30);
            this.bt_2.Name = "bt_2";
            this.bt_2.Size = new System.Drawing.Size(92, 77);
            this.bt_2.TabIndex = 6;
            this.bt_2.UseVisualStyleBackColor = false;
            this.bt_2.Click += new System.EventHandler(this.bt_2_Click);
            // 
            // bt_1
            // 
            this.bt_1.BackColor = System.Drawing.Color.Maroon;
            this.bt_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_1.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_1.Location = new System.Drawing.Point(70, 30);
            this.bt_1.Name = "bt_1";
            this.bt_1.Size = new System.Drawing.Size(92, 77);
            this.bt_1.TabIndex = 5;
            this.bt_1.UseVisualStyleBackColor = false;
            this.bt_1.Click += new System.EventHandler(this.bt_1_Click);
            // 
            // gb_Hankimg
            // 
            this.gb_Hankimg.BackColor = System.Drawing.Color.Blue;
            this.gb_Hankimg.Controls.Add(this.label1);
            this.gb_Hankimg.Controls.Add(this.label2);
            this.gb_Hankimg.Font = new System.Drawing.Font("Bernard MT Condensed", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Hankimg.Location = new System.Drawing.Point(419, 30);
            this.gb_Hankimg.Name = "gb_Hankimg";
            this.gb_Hankimg.Size = new System.Drawing.Size(236, 221);
            this.gb_Hankimg.TabIndex = 14;
            this.gb_Hankimg.TabStop = false;
            this.gb_Hankimg.Text = "Hanking";
            this.gb_Hankimg.Enter += new System.EventHandler(this.gb_Hankimg_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 5;
            // 
            // frm_JogoDaVelha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 57F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 489);
            this.Controls.Add(this.pnl_botao);
            this.Controls.Add(this.pnl_top);
            this.Font = new System.Drawing.Font("Bernard MT Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_JogoDaVelha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Velha";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Principal_FormClosing);
            this.pnl_top.ResumeLayout(false);
            this.gb_Empate.ResumeLayout(false);
            this.gb_Empate.PerformLayout();
            this.gb_Placar.ResumeLayout(false);
            this.gb_Placar.PerformLayout();
            this.gb_Opcao.ResumeLayout(false);
            this.gb_Opcao.PerformLayout();
            this.gb_Jogadores.ResumeLayout(false);
            this.gb_Jogadores.PerformLayout();
            this.pnl_botao.ResumeLayout(false);
            this.gb_Hankimg.ResumeLayout(false);
            this.gb_Hankimg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Button bt_Sair;
        private System.Windows.Forms.Button bt_Reiniciar;
        private System.Windows.Forms.Button bt_Iniciar;
        private System.Windows.Forms.GroupBox gb_Placar;
        private System.Windows.Forms.GroupBox gb_Opcao;
        private System.Windows.Forms.RadioButton rb_O;
        private System.Windows.Forms.RadioButton rb_X;
        private System.Windows.Forms.GroupBox gb_Jogadores;
        private System.Windows.Forms.TextBox tb_Jogador2;
        private System.Windows.Forms.TextBox tb_Jogador1;
        private System.Windows.Forms.Label lb_Jogador_2;
        private System.Windows.Forms.Label lb_Jogador_1;
        private System.Windows.Forms.Panel pnl_botao;
        private System.Windows.Forms.GroupBox gb_Empate;
        private System.Windows.Forms.Button bt_9;
        private System.Windows.Forms.Button bt_8;
        private System.Windows.Forms.Button bt_7;
        private System.Windows.Forms.Button bt_6;
        private System.Windows.Forms.Button bt_5;
        private System.Windows.Forms.Button bt_4;
        private System.Windows.Forms.Button bt_3;
        private System.Windows.Forms.Button bt_2;
        private System.Windows.Forms.Button bt_1;
        private System.Windows.Forms.Label lb_Empate;
        private System.Windows.Forms.Label lb_Joagor1;
        private System.Windows.Forms.Label lb_Jogador2;
        private System.Windows.Forms.GroupBox gb_Hankimg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

