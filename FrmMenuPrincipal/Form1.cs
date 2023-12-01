using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmMenuPrincipal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pnlMedico.Visible = false;
            pnlPaciente.Visible = false;
            pnlConsulta.Visible = false;
        }


        private void OcultSubMenu()
        {
            if(pnlMedico.Visible == true)
            {
                pnlMedico.Visible = false;
            }if(pnlPaciente.Visible == true)
            {
                pnlPaciente.Visible = false;
            }if(pnlConsulta.Visible == true)
            {
                pnlConsulta.Visible = false;
            }


        }


        private void MostrarSubMenu(Panel submenu)
        {

            if(submenu.Visible == false)
            {
                OcultSubMenu();
                submenu.Visible = true;

            }
            else
            {
                submenu.Visible = false;

            }


        }

   

        private void btnMedico_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlMedico);
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlPaciente);
        }
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlConsulta);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMedico_MouseEnter(object sender, EventArgs e)
        {

            btnMedico.BackColor = Color.White;
            btnMedico.ForeColor = Color.Black;
        }

        private void btnMedico_MouseLeave(object sender, EventArgs e)
        {
            btnMedico.BackColor = default(Color);
            btnMedico.ForeColor = Color.White;
        }

        private void btnPaciente_MouseEnter(object sender, EventArgs e)
        {

            btnPaciente.BackColor = Color.White;
            btnPaciente.ForeColor = Color.Black;
        }

        private void btnPaciente_MouseLeave(object sender, EventArgs e)
        {

            btnPaciente.BackColor = default(Color);
            btnPaciente.ForeColor = Color.White;
        }

        private void btnConsulta_MouseEnter(object sender, EventArgs e)
        {
            btnConsulta.BackColor = Color.White;
            btnConsulta.ForeColor = Color.Black;
        }

        private void btnConsulta_MouseLeave(object sender, EventArgs e)
        {

            btnConsulta.BackColor = default(Color);
            btnConsulta.ForeColor = Color.White;
        }

   
        private void btnRegistroMed_Click(object sender, EventArgs e)
        {
            OcultSubMenu();
        }

        private void btnRegistroPac_Click(object sender, EventArgs e)
        {
            OcultSubMenu();
        }

        private void btnExpedientePac_Click(object sender, EventArgs e)
        {
            OcultSubMenu();
        }

        private void btnProgramCon_Click(object sender, EventArgs e)
        {
            OcultSubMenu();
        }

        private void btnHistorCon_Click(object sender, EventArgs e)
        {
            OcultSubMenu();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
