using NET.XF.Intro.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.XF.Intro.ViewModel
{
    public class UsuarioViewModel 
    {
        public ObservableCollection<Usuario> Usuarios;

        public UsuarioViewModel() {
            LoadUsuarios();
        }

        private ObservableCollection<Usuario> LoadUsuarios()
        {
            return Usuarios = new ObservableCollection<Usuario>()
            {
                new Usuario()
                {
                    Nome = "Anderson",
                    Senha = "fiap"
                },
                new Usuario()
                {
                    Nome = "Aldo",
                    Senha = "fiap"
                }
            };
        }
    }
}
