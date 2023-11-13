using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mi_primera_vez.Entidades
{
    public class Alumno
    {
        private string ? idAlumno;
        protected string? name;
        protected int ? age;
        public string? Apariencia;

        public Alumno()=>idAlumno = Guid.NewGuid().ToString();
    }
}