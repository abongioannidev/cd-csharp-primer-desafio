﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio01.models
{
    public class Usuario
    {
        private int id;
        private string nombre;
        private string apellido;
        private string nombreUsuario;
        private string password;
        private string email;

        public int Id { get => this.id; set => this.id = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
        public string Apellido { get => this.apellido; set => this.apellido = value; }
        public string NombreUsuario { get => this.nombreUsuario; set => this.nombreUsuario = value; }
        public string Password { get => this.password; set => this.password = value; }
        public string Email { get => this.email; set => this.email = value; }
    }
}
