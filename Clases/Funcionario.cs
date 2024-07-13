using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticoBibliteca.Clases
{
    public class Funcionario
    {
        private string _nombre;
        private int _documento;
        private string _cargo;

        public Funcionario() { }

        public Funcionario(string nombre, int documento, string cargo)
        {
            this._nombre = nombre;
            this._documento = documento;
            this._cargo = cargo;
        }

        public string GetNombre()
        {
            return this._nombre;
        }
        public int GetDocumento()
        {
            return this._documento;
        }
        public string GetCargo()
        {
            return this._cargo;
        }

        public void SetCargo(string cargo)
        {
            this._cargo = cargo;

        }
        public void SetDocumento(int documento)
        {
            this._documento = documento;

        }
        public void SetNombre(string nombre)
        {
            this._nombre = nombre;

        }
    }
}
