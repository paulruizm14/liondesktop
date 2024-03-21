using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LionApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!validarDatos())
            {
                MessageBox.Show("Ingrese los datos", "Error");
            }
        }

        private bool validarDatos()
        {
            bool validar = true;
            if(txt_usr.Text == string.Empty){
                validar = false;
            }
            if(txt_pwd.Text == string.Empty) {
                validar = false; 
            }
            ////contra la base
            dblionDataContext dbcnt = new dblionDataContext();
            ADMINISTRACION admin = dbcnt.ADMINISTRACION.Where(x=> x.CLAVE_ADMIN.Equals(txt_pwd.Text) && x.NOMBRE_ADMIN.Equals(txt_usr.Text )).FirstOrDefault();
            if(admin == null)
            {
                validar &= false;
            }
            else
            {
                validar &= true;
            }
            return validar;
        }
    }
}
