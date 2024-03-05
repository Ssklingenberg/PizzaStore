using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.ExceptionServices;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class Store
    {

        /* Dette er en metode som vi har oprettet i vores Store klasse, 
         * vi kunne have kaldt metoden for hvad som helst. Det er denne metode du køre i Program*/

        public void Start() 
        {
                        
            //Create toppings
            Topping tomato = new Topping("Tomato");
            Topping cheese = new Topping("Cheese");
            Topping muchroom = new Topping("Muchroom");

            //Create 3 pizza
            Pizza margharita = new Pizza("Margharita", 69, tomato, cheese, muchroom, "Extra cheese");
            Pizza italiana = new Pizza("Italiana", 75, tomato, cheese, muchroom, "Extra cheese");
            Pizza bigMamma = new Pizza("BIG MAMMA", 90, tomato, cheese, muchroom, "Extra cheese");

            //Create 3 customer
            Customer milla = new Customer("Milla", "Milla@gmail.com", "42430442", "Solvej 12, 2650 Hvidovre ");
            Customer maylie = new Customer("Maylie", "Maylie@gmail.com", "23245566", "Blomstervej 10, 2660 Brøndby");
            Customer zakariyah = new Customer("Zakariyah", "Ziko@gmail.com", "44707979", "Sommerfuglevej 20, 2970 Hørsholm");

            
            // Der oprettes en aboutBigMamma fordi det indgår i invoice
            AboutBigMamma about = new AboutBigMamma();

            /* First order                       
             * For at kunne oprette en order skal der først laves nye 
             * objekter af både Costumer og Pizza, da de begge indgår i Order klassens kontructor
             * og Topping før Pizza fordi Toppings er en del af Pizza klassens constructor.*/

            Console.WriteLine("Welcome to BIG MAMMA");

            /* Her laver jeg den første order. Ved at oprette et nyt objekt af klassen order.
               Det er constructoren i Order klassen der bliver kaldt først og bruges til at initialisere objektet. */
           
            Order order1 = new Order(milla, margharita, true); 
            Console.WriteLine();

             /* Nu vil jeg gerne have en betinget sætning som skal informere kunden om 
             * afhentningstidspunkt/leveringstidspunkt. Så hvis order1 er true altså
             * IsTakeAway så skal den tilføje 15 min til den aktuelle tid og hvis det er false
             * skal leveringstiden være den aktuelle tid plus 30 min.*/

            Console.WriteLine();

            if (order1.IsTakeAway)
            {
                DateTime futureTime = DateTime.Now.AddHours(0.25);
                Console.WriteLine("Your order is ready for takeaway : " + futureTime);
            }
            else 
            {
                DateTime futureTime = DateTime.Now.AddHours(0.5);
                Console.WriteLine("Your order is expected to be delivered:" + futureTime);
            }
                                 
            /* Nu udskriver jeg en faktura, ved at oprette et nyt objekt af Invoice klasse 
             * og definere betingelserne i construktoren
             * og derefter udskriver ToString metoden fra Invoice klassen.*/

            Invoice in1 = new Invoice(DateTime.Now, order1, about);
            Console.WriteLine($"{in1}");

            Console.WriteLine("_________________________________________________"); Console.WriteLine();


            // Second order 

            Console.WriteLine("Welcome to BIG MAMMA");
            Console.WriteLine();
            

            Console.WriteLine("Order date and time:" + DateTime.Now);
            Console.WriteLine();
                     
            Order order2 = new Order(maylie, italiana, false);
                      
            if (order2.IsTakeAway)
            {
                DateTime futureTime = DateTime.Now.AddHours(0.25);
                Console.WriteLine("Your order is ready for takeaway" + futureTime);
            }
            else
            {
                DateTime futureTime = DateTime.Now.AddHours(0.5);
                Console.WriteLine("Your order is expected to be delivered:" + futureTime);
            }
            
                                       
            Invoice in2 = new Invoice(DateTime.Now, order2, about);
            Console.WriteLine($"{in2}");

            Console.WriteLine("_________________________________________________"); Console.WriteLine();

                                               
            //Third order

            Console.WriteLine("Welcome to BIG MAMMA");
            Console.WriteLine();
            
            Console.WriteLine("Order date and time:" + DateTime.Now);
            Console.WriteLine();
            
            Order order3 = new Order(zakariyah, bigMamma, false);                             
            
            if (order3.IsTakeAway)
            {
                DateTime futureTime = DateTime.Now.AddHours(0.25);
                Console.WriteLine("Your order is ready for takeaway" + futureTime);
            }
            else
            {
                DateTime futureTime = DateTime.Now.AddHours(0.5);
                Console.WriteLine("Your order is expected to be delivered:" + futureTime);
            }
                        
            Invoice in3 = new Invoice(DateTime.Now, order3, about);
            Console.WriteLine($"{in3}");
            
            
          
           

        }


    }
}
