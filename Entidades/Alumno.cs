using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mi_primera_vez.Entidades
{
    public class Alumno : Person 
    {
        private string? idAlumno;
        protected string? email;
        public string? apariencia;
        public string? grupo;


        public Alumno() => idAlumno = Guid.NewGuid().ToString();

        public string? IdAlumno
        {
            get
            {
                return this.idAlumno;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set { this.name = value; }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            set { this.email = value; }
        }

        public string Apariencia
        {
            get
            {
                return this.apariencia;
            }

            set
            {
                this.apariencia = value;
            }
        }

        public string Grupo
        {
            get
            {
                return this.grupo;
            }

            set 
            { 
            this.grupo = value;
            }
        }
    }
}