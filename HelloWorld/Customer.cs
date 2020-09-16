using System;
using System.Collections.Generic;

namespace HelloWorld
{
    public class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Orders> Orders = new List<Orders>();

        //public Customer(int id)
        //{
        //    this.Id = id;
        //}
        //public Customer(int id, string name)
        //     : this(id)
        //{
        //    this.Name = name;
        //}
        public void Promote()
        {
            var rating = CalculateRating();
            if (rating == 0)
            {
                Console.WriteLine("Promoted");
            }
        }

        protected int CalculateRating()
        {
            return 0;
        }

    }
}
