using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jueves2623
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
          /*  DuDCatalogo.Items.Add("Celulares");
            DuDCatalogo.Items.Add("Computadoras");
            DuDCatalogo.Items.Add("Impresoras");
          */
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            DuDCatalogo.Items.Add(txtnombre.Text);
            txtnombre.Text =  "";
        }

        private void DuDCatalogo_SelectedItemChanged(object sender, EventArgs e)
        {
            string producto = DuDCatalogo.SelectedItem.ToString();
            lblresultado.Text = string.Format("Ha seleccionado: "+producto);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int eliminar_indice=DuDCatalogo.SelectedIndex;
            DuDCatalogo.Items.RemoveAt(eliminar_indice);

        }
    }
}
