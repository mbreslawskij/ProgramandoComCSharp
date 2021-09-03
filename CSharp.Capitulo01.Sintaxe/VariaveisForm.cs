using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp.Capitulo01.Sintaxe
{
    public partial class VariaveisForm : Form
    {
        int x = 32;
        int y = 16;
        int w = 45;
        int z = 32;
        public VariaveisForm()
        {
            InitializeComponent();
        }

        private void VariaveisForm_Load(object sender, EventArgs e)
        {

        }
        // estemétodo é usado para atender
        private void aritmeticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultadoListBox.Items.Clear();
            //tipos de dados: pagina 25

            int x = 42;
            int X = 10;

            long população = 1212312312312312312;
            string nome = "Marcio", sobrenome = "Breslawskij";
            x = 5;
            //X = "14";//estaticamente tipada;
            char letra = 'a';
            bool aprovado = true;
            DateTime dataNascimento = new DateTime(1983, 10, 15);
            var dataNascimentos = new DateTime(1983, 10, 15);
            decimal valor = 13.6m;
            double outroValor = 2.2;
            float distancia = 100.32f;
            decimal media = 8.0M;
            decimal bim1 = 5.6m;

            object camaleao = "Marcio";
            camaleao = 5;
            camaleao = DateTime.Now;

            int a = 2;
            var b = 6;
            var c = 0;
            var d = 13;
            var f = 5.6m;

            var outroNome = "Breslawskij";

            decimal preco = 14;
            //preco = 25;

            resultadoListBox.Items.Add("a = " + a); //Shift + Ctrl + barra de espaços
            resultadoListBox.Items.Add(string.Concat("b = ", b));
            resultadoListBox.Items.Add(string.Format("c = {0} ", c));
            resultadoListBox.Items.Add($"d = {d}");

            resultadoListBox.Items.Add($"c * d = {c * d}");
            resultadoListBox.Items.Add($"d / a = {d / a}");
            resultadoListBox.Items.Add($"d % a = {d % a}");


        }

        private void resultadoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {




        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void reduzidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultadoListBox.Items.Clear();

            var x = 5;
            resultadoListBox.Items.Add($"x = {x}");
            resultadoListBox.Items.Add("----------------------------------------------");
            //x = x - 3;
            x -= 3;
            resultadoListBox.Items.Add($"x = {x}");
        }

        private void incrementaisDecrementaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultadoListBox.Items.Clear();

            int a;

            a = 5;
            resultadoListBox.Items.Add("Exemplo de pré-incremental");
            resultadoListBox.Items.Add($"a = {a}");
            resultadoListBox.Items.Add($"2 + ++a = {2 + ++a}");
            resultadoListBox.Items.Add($"a = {a}");

            resultadoListBox.Items.Add(new string('-', 50));

            a = 5;
            resultadoListBox.Items.Add("Exemplo de pós-incremental");
            resultadoListBox.Items.Add($"a = {a}");
            resultadoListBox.Items.Add($"2 + a++ = {2 + a++}");
            resultadoListBox.Items.Add($"a = {a}");

        }

        private void booleanasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibiValores();

            resultadoListBox.Items.Add($"w <= x = {w <= x}");
            resultadoListBox.Items.Add($"x == z = {x == z}");
            resultadoListBox.Items.Add($"x != z = {x != z}");


        }

        private void ExibiValores()
        {
            resultadoListBox.Items.Clear();

            resultadoListBox.Items.Add($"x = {x}");
            resultadoListBox.Items.Add($"y = {y}");
            resultadoListBox.Items.Add($"w = {w}");
            resultadoListBox.Items.Add($"z = {z}");

            resultadoListBox.Items.Add(new string('-', 50));
        }

        private void logicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (true)
            //{
            //    var x = 10;
            //}

            //x = 5;

            resultadoListBox.Items.Add($"w <= x || y == 16 = {w <= x || y == 16}");
            resultadoListBox.Items.Add($"x == z && x != z = {x == z && x != z}");
            resultadoListBox.Items.Add($"!(y > w) = {!(y > w)}");
        }
    }
}

