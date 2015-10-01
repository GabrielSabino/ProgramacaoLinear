using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramacaoLinear
{
    public partial class Formulario : Form
    {
        int contadorEixoX;
        int contadorEixoY;

        public Formulario(int qtdeVariaveis, int qtdeRestricoes)
        {
            InitializeComponent();
            contadorEixoY = 40;
            for (int i = 0; i < qtdeRestricoes; i++)
            {
                contadorEixoX = 100;

                Label lbRestricoes = new Label();
                lbRestricoes.SetBounds(10, contadorEixoY, 80, 25);
                lbRestricoes.Text = "Restricao " + (i+1).ToString();
                this.Controls.Add(lbRestricoes);

                for (int j = 0; j < qtdeVariaveis; j++)
                {
                    Label lbVariaveis = new Label();
                    lbVariaveis.SetBounds(contadorEixoX, 10, 30, 25);
                    lbVariaveis.Text = "X" + (j+1).ToString();
                    this.Controls.Add(lbVariaveis);

                    TextBox txt = new TextBox();
                    txt.SetBounds(contadorEixoX, contadorEixoY, 30, 30);
                    this.Controls.Add(txt);
                    contadorEixoX += 40;
                }
                contadorEixoY += 30;
            }
        }
    }
}
