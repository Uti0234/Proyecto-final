using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1_Hospital
{
    public partial class FormEmpleados : Form
    {
        public FormEmpleados()
        {
            InitializeComponent();
        }

        CLEmpleados logica = new CLEmpleados();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        


            cbox_Tabajo.Items.AddRange(new string[] { "Director", "Medico", "Enfermero", "Tecnico", "Farmaceutico" });
            cbox_Estado.Items.AddRange(new string[] {  "Activo", "Inactivo", "Suspendido", "Despedido" });
            
            
        }
        

        private void cbox_Tabajo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbox_Tabajo.Items.AddRange(new string[] {"Director","Medico", "Emfermero", "Tecnico", "Farmaceutico"});
        }

        private void lbl_Sueldo_Click(object sender, EventArgs e)
        {
            
        }
      
        private void iconButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (cbox_Tabajo.Text == "" || cbox_Estado.Text == ""  )
            MessageBox.Show("Tiene alguna celda vacia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            else
            {
                MessageBox.Show("Error al ver", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        

        private void lbl_Sueldo_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
