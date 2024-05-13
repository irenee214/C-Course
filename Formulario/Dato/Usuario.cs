using Formulario.Dato;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Formulario.Dato
{
    public class Usuario
    {
        List<UsuarioModel> lista = new List<UsuarioModel>();
        /// <summary>
        /// Guarda los usuarios
        /// </summary>
        /// <param name="model">datos del usuario</param>
        public void Guardar(UsuarioModel model)
        {
            lista.Add(model);
        }
        /// <summary>
        /// Consulta todos los usuarios
        /// </summary>
        /// <returns>datos de usuarios</returns>
        public List<UsuarioModel> Consultar() { return lista; }
    }
}

