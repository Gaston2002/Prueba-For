using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_For
{
    public partial class PruebaFor : Form
    {
        public PruebaFor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btArranque_Click(object sender, EventArgs e)
        {
            int x = System.Convert.ToInt32(txtX.Text); //¿hace falta definir la variable X?
            lbl.Visible = true;

            for (int i = x; i < 500; i++) // i = i + (1,2,3,etc)
            {
                lbl.Left = i;
                this.Refresh();
                //preguntar que es un argumento?
            }

        }
    }
}
