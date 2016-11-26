using NET.XF.Intro.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace NET.XF.Intro.View.Home
{
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void OnEntrar_Clicked(object sender, EventArgs args)
        {
            UsuarioViewModel usuarioVM = new UsuarioViewModel();

            if (usuarioVM.Usuarios.Where(a => a.Nome == txtUsuario.Text &&
                a.Senha == txtSenha.Text).Any())
            {
                // Navegar para página Home do Usuário
            }
            else
            {
                DisplayAlert("Atenção", 
                    string.Format("Usuário: {0} inválido", txtUsuario.Text), "OK");
            }
        }
    }
}
