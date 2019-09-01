using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioPictureBox
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void LimpiarCampo()
        {
            txtimagen.Text = "";
            txtimagen.Focus();
        }

        private void AbrirUrl(string pagina)
        {
            System.Diagnostics.Process.Start(pagina);
        }

        private void btnmostrar1_Click(object sender, EventArgs e)
        {
            string numeroImagen = txtimagen.Text;

            switch (numeroImagen)
            {
                case "1":
                    ptbibm.Visible = true;
                    break;
                case "2":
                    ptbsiliconvalley.Visible = true;
                    break;
                case "3":
                    ptbmicrosoft.Visible = true;
                    break;
                case "4":
                    ptbnsa.Visible = true;
                    break;
                case "5":
                    ptbnasa.Visible = true;
                    break;
                default:
                    MessageBox.Show("¡Valor incorrecto!");
                    break;
            }

            LimpiarCampo();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtimagen.Focus();
        }

        private void btnocultar_Click(object sender, EventArgs e)
        {
            string numeroImagen = txtimagen.Text;

            switch (numeroImagen)
            {
                case "1":
                    ptbibm.Visible = false;
                    break;
                case "2":
                    ptbsiliconvalley.Visible = false;
                    break;
                case "3":
                    ptbmicrosoft.Visible = false;
                    break;
                case "4":
                    ptbnsa.Visible = false;
                    break;
                case "5":
                    ptbnasa.Visible = false;
                    break;
                default:
                    MessageBox.Show("¡Valor incorrecto!");
                    break;
            }

            LimpiarCampo();
        }

        private void ptbibm_DoubleClick(object sender, EventArgs e)
        {
            ptbibm.Visible = false;
            AbrirUrl("https://www.ibm.com/");
        }

        private void ptbsiliconvalley_DoubleClick_1(object sender, EventArgs e)
        {
            ptbsiliconvalley.Visible = false;
            AbrirUrl("https://www.siliconvalley.com/");
        }

        private void ptbmicrosoft_DoubleClick(object sender, EventArgs e)
        {
            ptbmicrosoft.Visible = false;
            AbrirUrl("https://www.microsoft.com");
        }

        private void ptbnsa_DoubleClick(object sender, EventArgs e)
        {
            ptbnsa.Visible = false;
            AbrirUrl("https://www.nsa.gov/");
        }

        private void ptbnasa_DoubleClick(object sender, EventArgs e)
        {
            ptbnasa.Visible = false;
            AbrirUrl("https://www.nasa.gov/");
        }

        private void btnmostrartodos_Click(object sender, EventArgs e)
        {
            ptbibm.Visible = true;
            ptbsiliconvalley.Visible = true;
            ptbmicrosoft.Visible = true;
            ptbnsa.Visible = true;
            ptbnasa.Visible = true;
        }

        private void ptbverde_Click(object sender, EventArgs e)
        {
            BackColor = Color.LawnGreen;
        }

        private void ptbrojo_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void ptbblanco_Click(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }
    }
}
