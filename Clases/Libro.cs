using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticoBibliteca.Clases
{
    public class Libro
    {
        private string _titulo;
        private string _autor;
        private int _AnioDePublicacion;

        public Libro() { }
        public Libro(string titulo, string autor, int anio)
        {
            this._titulo = titulo;
            this._autor = autor;
            this._AnioDePublicacion = anio;
        }
        public void MostrarLibro()
        {
            Console.WriteLine($"Libro: {_titulo} \n Autor: {_autor}\n Año de publicación: {_AnioDePublicacion}");
        }

        public string GetTitulo()
        {
            return _titulo;
        }
        public string GetAutor()
        {
            return _autor;
        }
        public int GetAnio()
        {
            return _AnioDePublicacion;
        }

        public void SetTitulo(string titulo)
        {
            this._titulo = titulo;  
        }
        public void SetAutor(string autor)
        {
            this._autor = autor;
        }
        public void SetAnio(int anio)
        {
            this._AnioDePublicacion = anio;
        }




    }
}
