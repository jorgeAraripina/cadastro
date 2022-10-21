using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio_Cadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1cad_Click(object sender, EventArgs e)
        {
            Cadastro cad=new Cadastro();    

            cad.nome=textBox1nome.Text;
            cad.telefone = int.Parse(textBox2tele.Text);
            cad.idade = int.Parse(textBox3idade.Text);
            cad.peso = double.Parse(textBox4peso.Text);
            cad.cidade=textBox5cid.Text;
            cad.sexo=textBox6sexo.Text;
            cad.cpf=double.Parse(textBox7cpf.Text);
            cad.id = double.Parse(textBox8ide.Text);

            listBox1.Items.Add(cad.nome);
            listBox1.Items.Add(cad.telefone);
            listBox1.Items.Add(cad.idade);
            listBox1.Items.Add(cad.peso);
            listBox1.Items.Add(cad.cidade);
            listBox1.Items.Add(cad.sexo);
            listBox1.Items.Add(cad.cpf);
            listBox1.Items.Add(cad.id);

        }

        private void button2sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
