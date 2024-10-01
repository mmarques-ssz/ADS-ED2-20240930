using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projListaBind
{
    public partial class Form1 : Form
    {
        private List<Coisa> listaCoisas;
        private BindingSource bs;
        public Form1()
        {
            InitializeComponent();
            
            listaCoisas = new List<Coisa>();

            listaCoisas.Add(new Coisa(1, "Coisa Um"));
            listaCoisas.Add(new Coisa(2, "Coisa Dois"));
            listaCoisas.Add(new Coisa(3, "Coisa Três"));
            listaCoisas.Add(new Coisa(4, "Coisa Quatro"));
            atualizaCoisas();
        }

        private void atualizaCoisas()
        {
            bs = new BindingSource();
            bs.DataSource = listaCoisas;
            dataGridView1.DataSource = bs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listaCoisas.Add(
                   new Coisa(
                       int.Parse(textBox1.Text),
                       textBox2.Text)
                   );
            atualizaCoisas();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(
                this.listaCoisas[bs.Position].ToString()
                );
        }
    }
}
