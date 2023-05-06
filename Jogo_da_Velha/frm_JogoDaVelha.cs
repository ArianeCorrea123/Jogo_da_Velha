using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Jogo_da_Velha
{
    public partial class frm_JogoDaVelha : Form
    {
        string Njogador1, Njogador2, Jogada;

        int cont = 0, Pjogador1 = 0, Pjogador2 = 0, empates = 0;

        public frm_JogoDaVelha()
        {
            InitializeComponent();
        }



        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_1_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked)
            {
                Jogada = rb_X.Text;
                rb_O.Checked = true;
                bt_1.Text = Jogada;
                bt_1.Enabled = false;
            }
            else if (rb_O.Checked)
            {
                Jogada = rb_O.Text;
                rb_X.Checked = true;
                bt_1.Text = Jogada;
                bt_1.Enabled = false;
            }
            cont++;
            vencedor();
        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked)
            {
                Jogada = rb_X.Text;
                rb_O.Checked = true;
                bt_2.Text = Jogada;
                bt_2.Enabled = false;
            }
            else if (rb_O.Checked)
            {
                Jogada = rb_O.Text;
                rb_X.Checked = true;
                bt_2.Text = Jogada;
                bt_2.Enabled = false;
            }
            cont++;
            vencedor();
        }

        private void bt_3_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked)
            {
                Jogada = rb_X.Text;
                rb_O.Checked = true;
                bt_3.Text = Jogada;
                bt_3.Enabled = false;
            }
            else if (rb_O.Checked)
            {
                Jogada = rb_O.Text;
                rb_X.Checked = true;
                bt_3.Text = Jogada;
                bt_3.Enabled = false;
            }
            cont++;
            vencedor();
        }

        private void bt_4_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked)
            {
                Jogada = rb_X.Text;
                rb_O.Checked = true;
                bt_4.Text = Jogada;
                bt_4.Enabled = false;
            }
            else if (rb_O.Checked)
            {
                Jogada = rb_O.Text;
                rb_X.Checked = true;
                bt_4.Text = Jogada;
                bt_4.Enabled = false;
            }
            cont++;
            vencedor();
        }

        private void bt_5_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked)
            {
                Jogada = rb_X.Text;
                rb_O.Checked = true;
                bt_5.Text = Jogada;
                bt_5.Enabled = false;
            }
            else if (rb_O.Checked)
            {
                Jogada = rb_O.Text;
                rb_X.Checked = true;
                bt_5.Text = Jogada;
                bt_5.Enabled = false;
            }
            cont++;
            vencedor();
        }

        private void bt_6_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked)
            {
                Jogada = rb_X.Text;
                rb_O.Checked = true;
                bt_6.Text = Jogada;
                bt_6.Enabled = false;
            }
            else if (rb_O.Checked)
            {
                Jogada = rb_O.Text;
                rb_X.Checked = true;
                bt_6.Text = Jogada;
                bt_6.Enabled = false;
            }
            cont++;
            vencedor();
        }

        private void bt_7_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked)
            {
                Jogada = rb_X.Text;
                rb_O.Checked = true;
                bt_7.Text = Jogada;
                bt_7.Enabled = false;
            }
            else if (rb_O.Checked)
            {
                Jogada = rb_O.Text;
                rb_X.Checked = true;
                bt_7.Text = Jogada;
                bt_7.Enabled = false;
            }
            cont++;
            vencedor();
        }

        private void bt_8_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked)
            {
                Jogada = rb_X.Text;
                rb_O.Checked = true;
                bt_8.Text = Jogada;
                bt_8.Enabled = false;
            }
            else if (rb_O.Checked)
            {
                Jogada = rb_O.Text;
                rb_X.Checked = true;
                bt_8.Text = Jogada;
                bt_8.Enabled = false;
            }
            cont++;
            vencedor();

        }

        private void bt_9_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked)
            {
                Jogada = rb_X.Text;
                rb_O.Checked = true;
                bt_9.Text = Jogada;
                bt_9.Enabled = false;
            }
            else if (rb_O.Checked)
            {
                Jogada = rb_O.Text;
                rb_X.Checked = true;
                bt_9.Text = Jogada;
                bt_9.Enabled = false;
            }
            cont++;
            vencedor();
        }

        private void bt_Reiniciar_Click(object sender, EventArgs e)
        {
            Limpar();
            Habilitar_Botoes();
        }

        private void gb_Hankimg_Enter(object sender, EventArgs e)
        {
            
        }

        private void frm_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja fecha o Jogo da Velha...", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        public void vencedor()
        {
            if ((bt_1.Text == "X") && (bt_2.Text == "X") && (bt_3.Text == "X") ||
                (bt_4.Text == "X") && (bt_5.Text == "X") && (bt_6.Text == "X") ||
                (bt_7.Text == "X") && (bt_8.Text == "X") && (bt_9.Text == "X") ||
                (bt_1.Text == "X") && (bt_5.Text == "X") && (bt_9.Text == "X") ||
                (bt_3.Text == "X") && (bt_5.Text == "X") && (bt_7.Text == "X") ||
                (bt_1.Text == "X") && (bt_4.Text == "X") && (bt_7.Text == "X") ||
                (bt_2.Text == "X") && (bt_5.Text == "X") && (bt_8.Text == "X") ||
                (bt_3.Text == "X") && (bt_6.Text == "X") && (bt_9.Text == "X")
                )
            {
                MessageBox.Show(" Xizinho Ganho", "EEEEEEEEEEEEEE");
                Limpar();
                Habilitar_Botoes();
                Pjogador1 = Pjogador1 + 1;
                lb_Joagor1.Text = Pjogador1.ToString() + " - Vitórias";
                cont = 0;

            }
            else if ((bt_1.Text == "O") && (bt_2.Text == "O") && (bt_3.Text == "O") ||
               (bt_4.Text == "O") && (bt_5.Text == "O") && (bt_6.Text == "O") ||
               (bt_7.Text == "O") && (bt_8.Text == "O") && (bt_9.Text == "O") ||
               (bt_1.Text == "O") && (bt_5.Text == "O") && (bt_9.Text == "O") ||
               (bt_3.Text == "O") && (bt_5.Text == "O") && (bt_7.Text == "O") ||
               (bt_1.Text == "O") && (bt_4.Text == "O") && (bt_7.Text == "O") ||
               (bt_2.Text == "O") && (bt_5.Text == "O") && (bt_8.Text == "O") ||
               (bt_3.Text == "O") && (bt_6.Text == "O") && (bt_9.Text == "O")
               )
            {
                MessageBox.Show("Bolinha Ganhou", "EEEEEEEEEEEEEE");
                Limpar();
                Habilitar_Botoes();
                Pjogador2 = Pjogador2 + 1;
                lb_Jogador2.Text = Pjogador2.ToString() + " - Vitórias";
                cont = 0;
            }

            if (cont >= 9)
            {
                empates = empates + 1;
                lb_Empate.Text = empates.ToString() + " - Empate(s)";
                MessageBox.Show("Empato!!!");
                cont = 0;
                Limpar();
                Habilitar_Botoes();
            }




        }

        public void Limpar()
        {
            bt_1.Text = "";
            bt_2.Text = "";
            bt_3.Text = "";
            bt_4.Text = "";
            bt_5.Text = "";
            bt_6.Text = "";
            bt_7.Text = "";
            bt_8.Text = "";
            bt_9.Text = "";
            pnl_botao.Enabled = true;
            Habilitar_Botoes();
            cont = 0;

        }

        public void Habilitar_Botoes()
        {
            bt_1.Enabled = true;
            bt_2.Enabled = true;
            bt_3.Enabled = true;
            bt_4.Enabled = true;
            bt_5.Enabled = true;
            bt_6.Enabled = true;
            bt_7.Enabled = true;
            bt_8.Enabled = true;
            bt_9.Enabled = true;


        }

        private void bt_Iniciar_Click(object sender, EventArgs e)
        {
            if ((tb_Jogador1.Text != "") && (tb_Jogador2.Text != ""))
            {
                Njogador1 = tb_Jogador1.Text;
                tb_Jogador1.Visible = false;
                lb_Jogador_1.Text = Njogador1 + " Joga com ";

                Njogador2 = tb_Jogador2.Text;
                tb_Jogador2.Visible = false;
                lb_Jogador_2.Text = Njogador2 + " Joga com ";

                if (rb_X.Checked)
                {
                    lb_Jogador_1.Text = lb_Jogador_1.Text + " X ";
                    rb_O.Checked = true;
                }
                else if (rb_O.Checked)
                {
                    lb_Jogador_1.Text = lb_Jogador_1.Text + " O ";
                    rb_X.Checked = true;
                }

                if (rb_X.Checked)
                {
                    lb_Jogador_2.Text = lb_Jogador_2.Text + " X ";
                    rb_X.Checked = true;
                }
                else if (rb_O.Checked)
                {
                    lb_Jogador_2.Text = lb_Jogador_2.Text + " O ";
                    rb_X.Checked = true;
                }
                gb_Opcao.Enabled = false;
                pnl_botao.Enabled = true;

                lb_Joagor1.Text = "0 - Vitória";

                lb_Jogador2.Text = "0 - Vitória";
            }

            else
            {
                MessageBox.Show("Por gentileza informe seu nome", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}