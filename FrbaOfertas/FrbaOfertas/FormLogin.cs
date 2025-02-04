﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaOfertas
{
    public partial class FormLogin : Form
    {
        #region Variables

        static SqlConnection conexion;

        #endregion

        public FormLogin()
        {
            InitializeComponent();
            conexion = new SqlConnection(Configuracion.stringConexion);
            Configuracion.formLogin = this;
        }

        #region Métodos

        private Boolean validarCampos()
        {
            if (txtUsername.Text.Equals("") && txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar un nombre de usuario y contraseña.");
                return false;
            }
            else
            {
                if (txtUsername.Text.Equals(""))
                {
                    MessageBox.Show("Debe ingresar un nombre de usuario.");
                    return false;
                }

                if (txtPassword.Text.Equals(""))
                {
                    MessageBox.Show("Debe ingresar una contraseña.");
                    return false;
                }
            }
            return true;
        }

        #endregion

        #region Eventos

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                try
                {
                    conexion.Open();
                    SqlCommand validarLogin = new SqlCommand("[LOS_GDDS].[validar_login]", conexion);
                    validarLogin.CommandType = CommandType.StoredProcedure;
                    validarLogin.Parameters.AddWithValue("@Usuario", txtUsername.Text);
                    validarLogin.Parameters.AddWithValue("@Clave", txtPassword.Text);
                    validarLogin.Parameters.AddWithValue("@MaxIntentos", Configuracion.cantidadMaximaIntentosLogin);

                    var resultado = validarLogin.Parameters.Add("@Resultado", SqlDbType.Int);
                    var idUsuario = validarLogin.Parameters.Add("@Id", SqlDbType.Int);
                    var idRol = validarLogin.Parameters.Add("@Rol", SqlDbType.Int);
                    resultado.Direction = ParameterDirection.Output;
                    idUsuario.Direction = ParameterDirection.Output;
                    idRol.Direction = ParameterDirection.Output;

                    SqlDataReader data = validarLogin.ExecuteReader();

                    switch (int.Parse(resultado.Value.ToString()))
                    {
                        /* 
                         * 0: El usuario no existe
                         * 1: Intentos excedidos
                         * 2: La password no coincide
                         * 3: El usuario no está habilitado
                         * 4: Login exitoso
                        */
                        case 0:
                        case 2:
                            MessageBox.Show("Los datos ingresados son incorrectos.");
                            break;
                        case 3:
                            MessageBox.Show("El usuario se encuentra inhabilitado.");
                            break;
                        case 1:
                            MessageBox.Show("Excedió la cantidad de intentos permitidos.");
                            break;
                        case 4:
                            Configuracion.idUsuario = int.Parse(idUsuario.Value.ToString());
                            Configuracion.idRol = int.Parse(idRol.Value.ToString());
                            FormMenuPrincipal form = new FormMenuPrincipal(this);
                            form.Show();
                            this.Hide();
                            txtUsername.Text = "";
                            txtPassword.Text = "";
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        private void lnkRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegistrarUsuario form = new FormRegistrarUsuario(this);
            this.Visible = false;
            form.ShowDialog();
        }

        #endregion
    }
}