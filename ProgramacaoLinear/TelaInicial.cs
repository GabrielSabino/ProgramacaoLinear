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
    public partial class TelaInicial : Form
    {
        int qtdeVariaveis;
        int qtdeRestricoes;

        public TelaInicial()
        {
            InitializeComponent();
        }

        private void btGerar_Click(object sender, EventArgs e)
        {
            qtdeVariaveis = Convert.ToInt16(txtVariaveis.Text);
            qtdeRestricoes = Convert.ToInt16(txtRestricoes.Text);

            Formulario form1 = new Formulario(qtdeVariaveis, qtdeRestricoes);
            form1.Show();
        }
    }
}
