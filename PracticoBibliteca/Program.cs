using PracticoBibliteca.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticoBibliteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Biblioteca NuevaBiblioteca = new Biblioteca();
            Libro NuevoLibro = new Libro("Cien Años de Soledad", "Gabriel Garcia Marquez", 1967);
            Libro NuevoLibro2 = new Libro("Don Quijote de la Mancha", "Miguel de Cervantes", 1605);
            Libro NuevoLibro3 = new Libro("Orgullo y Prejuicio", "Jane Austen", 1813);
            Libro NuevoLibro4 = new Libro("1984", "George Orwell", 1949);
            Libro NuevoLibro5 = new Libro("El Gran Gatsby", "F. Scott Fitzgerald", 1925);
            Libro NuevoLibro6 = new Libro("Matar a un Ruiseñor", "Harper Lee", 1960);
            Libro NuevoLibro7 = new Libro("En Busca del Tiempo Perdido", "Marcel Proust", 1913);
            Libro NuevoLibro8 = new Libro("Ulises", "James Joyce", 1922);
            Libro NuevoLibro9 = new Libro("La Odisea", "Homero", -800);
            Libro NuevoLibro10 = new Libro("Crimen y Castigo", "Fyodor Dostoevsky", 1866);

            NuevaBiblioteca.AgregarLibro(NuevoLibro);
            NuevaBiblioteca.AgregarLibro(NuevoLibro2);
            NuevaBiblioteca.AgregarLibro(NuevoLibro3);
            NuevaBiblioteca.AgregarLibro(NuevoLibro4);
            NuevaBiblioteca.AgregarLibro(NuevoLibro5);
            NuevaBiblioteca.AgregarLibro(NuevoLibro6);
            NuevaBiblioteca.AgregarLibro(NuevoLibro7);
            NuevaBiblioteca.AgregarLibro(NuevoLibro8);
            NuevaBiblioteca.AgregarLibro(NuevoLibro9);
            NuevaBiblioteca.AgregarLibro(NuevoLibro10);

            Funcionario NuevoFuncionario = new Funcionario("Juan Perez", 12345678, "Gerente");
            Funcionario NuevoFuncionario2 = new Funcionario("Ana Gomez", 23456789, "Analista");
            Funcionario NuevoFuncionario3 = new Funcionario("Carlos Rodriguez", 34567890, "Desarrollador");

            NuevaBiblioteca.AgregarFuncionario(NuevoFuncionario);
            NuevaBiblioteca.AgregarFuncionario(NuevoFuncionario2);
            NuevaBiblioteca.AgregarFuncionario(NuevoFuncionario3);

            NuevaBiblioteca.MostrarLibros();

            Console.ReadKey();



        }
    }
}
