using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ModeloPorCapasWinFrom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }  

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ModeloNegocio.Empleados.Get();
            var data = ModeloNegocio.Respuestas.Get();
            string s = "";
            foreach (var res in data) {
                s = s + "-"+res.respuestas1+"-" + "-"+res.preguntasFID+"--";
            }
            textBox1.Text = s;
            //textBox1.Text = ModeloNegocio.Respuetas.get();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
