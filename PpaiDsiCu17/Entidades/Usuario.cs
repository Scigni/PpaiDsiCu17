using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace PpaiDsiCu17.Entidades
{
    public class Usuario
    {
        private bool activo;
        private DateTime fechaAlta;
        private string nombreUsuario;
        private string password;
        private Perfil perfil;

        public Perfil getPerfil()
        {
            return perfil;
        }

        public void setPerfil(Perfil perfil) 
        {
            this.perfil = perfil;
        }
    }
}
