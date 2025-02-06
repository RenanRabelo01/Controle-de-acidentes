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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
          
        }

        private void go_Click(object sender, EventArgs e)
        {
            {
                if (TX1.Text == "160218")
                {
                    Form2 form2 = new Form2();
                    form2.Show();
                   
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Código inválido. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
