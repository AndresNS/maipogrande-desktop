using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaDTO;


namespace CapaGUI
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Sesion loginven = new Sesion();
            loginven.Nombre_usuario = this.txtUsuario.Text;
            loginven.Password = this.txtContraseña.Text;

            NegocioSesion ven = new NegocioSesion();
            if (ven.IngresoSistema(loginven))
            {
                MainADM venaca = new MainADM();
                venaca.ShowDialog();
                // Cerrar ventana de login
                System.GC.Collect();


                //this.Dispose();
                // usuario entra

            } else
            {
                MessageBox.Show("Acceso denegado!");
            }

            
            





        }
    }
}
