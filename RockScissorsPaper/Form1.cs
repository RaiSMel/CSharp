using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockScissorsPaper
{
    public partial class PedraPapelTesoura : Form
    {





        enum Opções { Pedra, Papel, Tesoura };
        enum Resultado { Jogador, Cpu, Empate }
        Opções jogador = new Opções();
        Opções cpu = new Opções();
        Random rdm = new Random();
        Resultado ganhador = new Resultado();


        void EscolhaJogador()
        {
            switch (jogador)
            {
                case Opções.Pedra:
                    PicJogador.BackgroundImage = Properties.Resources.PedraJ;
                    break;
                case Opções.Papel:
                    PicJogador.BackgroundImage = Properties.Resources.PapelJ;
                    break;
                case Opções.Tesoura:
                    PicJogador.BackgroundImage = Properties.Resources.TesouraJ;
                    break;
            }
        }

      


        public PedraPapelTesoura()
        {
            InitializeComponent();
        }

        void VerificarGanhador()
        {
            switch (jogador)
            {
                case Opções.Pedra:
                    if (cpu == Opções.Pedra)
                        ganhador = Resultado.Empate;
                    else if (cpu == Opções.Papel)
                        ganhador = Resultado.Cpu;
                    else if (cpu == Opções.Tesoura)
                        ganhador = Resultado.Jogador;
                    break;

                case Opções.Papel:
                    if (cpu == Opções.Pedra)
                        ganhador = Resultado.Jogador;
                    else if (cpu == Opções.Papel)
                        ganhador = Resultado.Empate;
                    else if (cpu == Opções.Tesoura)
                        ganhador = Resultado.Cpu;
                    break;

                case Opções.Tesoura:
                    if (cpu == Opções.Pedra)
                        ganhador = Resultado.Cpu;
                    else if (cpu == Opções.Papel)
                        ganhador = Resultado.Jogador;
                    else if (cpu == Opções.Tesoura)
                        ganhador = Resultado.Empate;
                    break;
            }




            if (ganhador == Resultado.Jogador)
            {
                gbJog.BackColor = Color.Green;
                gbComput.BackColor = Color.DarkRed;
               lblPlacarJ.Text = (int.Parse(lblPlacarJ.Text) + 1).ToString();
            }
            else if (ganhador == Resultado.Cpu)
            {
                gbComput.BackColor = Color.Green;
                gbJog.BackColor = Color.DarkRed;
                lblPlacarM.Text = (int.Parse(lblPlacarM.Text) + 1).ToString();
            }
            else
            {
                gbComput.BackColor = Color.WhiteSmoke;
                gbJog.BackColor = Color.WhiteSmoke;

            }

       if(Convert.ToInt32(lblPlacarM.Text) > 2)
            {
                MessageBox.Show("Você foi derrotado", "Derrota", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gbComput.BackColor = Color.WhiteSmoke;
                gbJog.BackColor = Color.WhiteSmoke;
                lblPlacarJ.Text = (0).ToString();
                lblPlacarM.Text = (0).ToString();
                picComputador.BackgroundImage = null;
                PicJogador.BackgroundImage = null;
            }
       else if(Convert.ToInt32(lblPlacarJ.Text) > 2)
            {
                MessageBox.Show("Parabéns você ganhou", "Vitória", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gbComput.BackColor = Color.WhiteSmoke;
                gbJog.BackColor = Color.WhiteSmoke;
                lblPlacarM.Text = (0).ToString();
                lblPlacarJ.Text = (0).ToString();
                picComputador.BackgroundImage = null;
                PicJogador.BackgroundImage = null;
            }

        }

                void EscolhaCpu()
        {

            int numero = rdm.Next(1, 4);
            if (numero == 1)
            {
                cpu = Opções.Pedra;
                picComputador.BackgroundImage = Properties.Resources.PedraC;
            }
            else if (numero == 2)
            {
                cpu = Opções.Papel;
                picComputador.BackgroundImage = Properties.Resources.PapelC;
            }
            else if (numero == 3)
            {
                cpu = Opções.Tesoura;
                picComputador.BackgroundImage = Properties.Resources.TesouraC;
            }


           
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            jogador = Opções.Papel;
            EscolhaJogador();
            EscolhaCpu();
            VerificarGanhador();
        }

        private void btnPedra_Click(object sender, EventArgs e)
        {
            jogador = Opções.Pedra;
            EscolhaJogador();
            EscolhaCpu();
            VerificarGanhador();
        }

        private void btnTesoura_Click(object sender, EventArgs e)
        {
            jogador = Opções.Tesoura;
            EscolhaJogador();
            EscolhaCpu();
            VerificarGanhador();
        }

    }
}
