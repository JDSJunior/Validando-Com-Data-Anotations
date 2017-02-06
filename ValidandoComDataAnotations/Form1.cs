using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidandoComDataAnotations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ValidarAluno(object obj)
        {
            var erros = Validacao.getValidationErros(obj);
            foreach (var error in erros)
            {
                MessageBox.Show((error.ErrorMessage));
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Aluno _aluno = new Aluno();
            _aluno.Id    = Convert.ToInt32(tbxID.Text);
            _aluno.Nome  = tbxNome.Text;
            _aluno.Email = tbxEmail.Text;
            _aluno.Idade = Convert.ToInt32(tbxIdade.Text);

            ValidarAluno(_aluno);
        }
    }
}
