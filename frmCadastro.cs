﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_Telefonica
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void presencaCamposCadastro()
        {
            //Verifica se o nome, usuário, telefone, senha e confirmação da senha estão preenchidos.
            //senha e confirmação da senha devem possuir mais de 8 caracteres e serem iguais
            bool possuiErro = false;
            if (txtNome.Text == "")
            {
                possuiErro = true;
            }
            if (txtUsuario.Text == "")
            { 
                possuiErro = true;
            }
            if (txtSenha.Text.Length <8)
            {
                possuiErro = true;
            }
            if (txtConfirmarSenha.Text != txtSenha.Text)
            {
                possuiErro = true;
            }

            if (possuiErro == false)
            {
                btnCadastrar.Enabled = true;
            }
            else
            {
                btnCadastrar.Enabled = false;
            }

            //Verifica se o nome, usuário, telefone, senha e confirmação da senha estão preenchidos.
            //senha e confirmação da senha devem possuir mais de 8 caracteres e serem iguais
            if (txtNome.Text != "" && txtUsuario.Text != "" &&
                txtTelefone.Text != "" && txtSenha.Text.Length >=8 &&
                txtConfirmarSenha.Text.Length >=8 && txtSenha.Text == txtConfirmarSenha.Text)
            {
                btnCadastrar.Enabled = true;
            }
            else
            {
                btnCadastrar.Enabled = false;
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin formularioLogin = new frmLogin();
            formularioLogin.Show();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            presencaCamposCadastro();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            presencaCamposCadastro();
        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {
            presencaCamposCadastro();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            presencaCamposCadastro();
        }

        private void txtConfirmarSenha_TextChanged(object sender, EventArgs e)
        {
            presencaCamposCadastro();
        }
    }
}
