using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticoBibliteca.Clases
{
    public class Biblioteca
    {
        private List<Libro> ListaLibro;
        private List<Funcionario> ListaFuncionario;


        public Biblioteca()
        {
            this.ListaLibro = new List<Libro>();
            this.ListaFuncionario = new List<Funcionario>();
        }

        public void AgregarLibro(Libro libro)
        {
            this.ListaLibro.Add(libro);
        }
        public void AgregarFuncionario(Funcionario funcionario)
        {
            this.ListaFuncionario.Add(funcionario);
        }

        public List<Libro> GetLibros()
        {
            return this.ListaLibro;
        }
        public List<Funcionario> GetFuncionarios()
        {
            return this.ListaFuncionario;
        }

        public void MostrarLibros()
        {
            foreach (var objeto in GetLibros())
            {
                objeto.MostrarLibro();
                Console.WriteLine();

            }



        }
    }
}
