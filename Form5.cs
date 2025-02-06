using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void go_Click(object sender, EventArgs e)
        {
            {
                if (TX1.Text == "160218")
                {
                    Form4 form4 = new Form4();
                    form4.Show();

                    this.Close();

                }
                else
                {
                    MessageBox.Show("Código inválido. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
