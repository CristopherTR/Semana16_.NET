//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Semana16.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Usuario
    {
        public int UsuarioID { get; set; }
        [Required(ErrorMessage="Este campo es requerido")]
        public string UsuarioNom { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public string UsuarioContraseña { get; set; }

        public string LoginErrorMensaje { get; set; }
    }
}
