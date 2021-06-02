using System;
using Entities;
using System.Collections.Generic;
namespace EXERCISE_01___ACTION {
    class Program {
        static void Main(string[] args) {

            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.0));
            list.Add(new Product("Mouse",50.00));
            list.Add(new Product("Tablwt",350.00));
            list.Add(new Product("Mouse",50.00));

            Action<Product> act = p => { p.Price += p.Price * 0.1; };

            list.ForEach(UpdatePrice);
            foreach(Product p in list) {
                Console.WriteLine(p);
            }
                   
        }  
         static void UpdatePrice(Product p) {
                p.Price += p.Price * 0.1;
         }
    }
}
