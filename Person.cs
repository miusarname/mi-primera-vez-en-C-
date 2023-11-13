using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mi_primera_vez
{
    public class Person
    {
        private string ? cedula { get { return this.cedula; }  }
        protected string? name { get { return this.name; } set { this.name = value; } }
        protected int? age { get { return this.age; } set { this.age = value; } }
        public string Aparciencia { get { return this.Aparciencia; } set { this.Aparciencia = value; } }

        //cedula = Guid.NewGuid().ToString();

        public Person() {
            this.name = "a";
            this.age = 0;
            this.Aparciencia = "Feo";
        }
    }
}