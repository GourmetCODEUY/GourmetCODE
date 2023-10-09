using proyecto.Persistencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuProyecto.Logica;

namespace proyecto.Presentacion
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;
            int rol;

            if (verificarUsuario.VerificarCredenciales(usuario, contrasena, out rol))
            {
                MessageBox.Show("Inicio de sesión exitoso.");
                FormMenu formMenu = new FormMenu(rol);
                formMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas.");
            }
        }

        private void txtContrasena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string usuario = txtUsuario.Text;
                string contrasena = txtContrasena.Text;
                if (verificarUsuario.VerificarCredenciales(usuario, contrasena, out int rol))
                {
                    MessageBox.Show("Inicio de sesión exitoso.");
                    FormMenu formMenu = new FormMenu(rol);
                    this.Hide();
                    formMenu.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas.");
                }
            }
        }
        private void lblRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormAltaCliente formAltaCliente = new FormAltaCliente();
            formAltaCliente.FormBorderStyle = FormBorderStyle.Sizable;
            formAltaCliente.ShowDialog();
        }
    }
}