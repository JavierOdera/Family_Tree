using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
             List<Node<Persona>> lista = new List<Node<Persona>>();
            Persona p1 = new Persona("Rodrigo", 68);
            Persona p2 = new Persona("Judith", 47);
            Persona p3 = new Persona("Maxwell", 45);
            Persona p4 = new Persona("Michael", 27);
            Persona p5 = new Persona("James", 26);
            Persona p6 = new Persona("Belladonna", 23);
            Persona p7 = new Persona("Alex", 21);   //p7 y p8 son ambos adoptados
            Persona p8 = new Persona("Jesse", 20);
            Node<Persona> n1 = new Node<Persona>(p1);
            Node<Persona> n2 = new Node<Persona>(p2);
            Node<Persona> n3 = new Node<Persona>(p3);
            Node<Persona> n4 = new Node<Persona>(p4);
            Node<Persona> n5 = new Node<Persona>(p5);
            Node<Persona> n6 = new Node<Persona>(p6);
            Node<Persona> n7 = new Node<Persona>(p7);
            Node<Persona> n8 = new Node<Persona>(p8);

            n1.AddChildren(n2);
            n1.AddChildren(n3);
            
            n3.AddChildren(n4);
            n3.AddChildren(n5);
            n3.AddChildren(n6);

            n4.AddChildren(n8);
            n5.AddChildren(n7);

            lista.Add(n1);
            lista.Add(n2);
            lista.Add(n3);
            lista.Add(n4);
            lista.Add(n5);
            lista.Add(n6);
            lista.Add(n7);
            lista.Add(n8);
            
            SumaEdad S = new SumaEdad();
            S.Visit(n1);
            Console.WriteLine(S.suma);

            NombreMasLargo L = new NombreMasLargo();
            L.Visit(n1);
            Console.WriteLine(L.largo);

            MayorHijo M = new MayorHijo();
            M.Visit(n1);
            Console.WriteLine(M.edad);
        }
    }
}
