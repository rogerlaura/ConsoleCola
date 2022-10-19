using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCola
{
    internal class Cola
    {
        private int primero, ultimo,maxcola;
        private int[] contenedorcola;
        public Cola(int maxcola)
        {
            this.primero = 0;
            this.ultimo = -1;
            this.maxcola = maxcola;
            this.contenedorcola = new int[maxcola]; 
        }
        public bool colavacia()
        {
            if (this.ultimo < this.primero)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool colallena()
        {
            if (this.ultimo == maxcola - 1&&this.primero==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void insertarItem(int dato)
        {
            if (this.colallena())
            {
                Console.WriteLine("\t LA COLA ESTA LLENA");
            }
            else
            {
                this.ultimo++;
                this.contenedorcola[ultimo] = dato;
                Console.WriteLine("\t SE INSERTO CON EXITO A LA COLA");
            }
        }
        public void eliminarItem()
        {
            if (colavacia())
            {
                Console.WriteLine("\t LA COLA ESTA VACIA");
            }
            else
            {
                Console.WriteLine("\t SE ELEIMINO CON EXITO EL ELEMENTO "+this.contenedorcola[primero]);
                for(int i=0; i<this.ultimo; i++)
                {
                    this.contenedorcola[i] = this.contenedorcola[i + 1];
                }
                this.ultimo--;
            }
        }
        public void ListarItems()
        {
            if (this.colavacia())
            {
                Console.WriteLine("\tLA COLA ESTA VACIA");
            }
            else
            {
                for (int i = this.primero; i <= this.ultimo; i++)
                {
                    Console.WriteLine("\t [" + i + "] => " + this.contenedorcola[i]);
                }
            }
        }

    }
}
