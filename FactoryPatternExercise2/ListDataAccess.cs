﻿using System;

namespace FactoryPatternExercise2
{
    public class ListDataAccess : IDataAccess
    {
       
        

        public void SaveData()
        {
            Console.WriteLine($"I am saving data from LIST database.");
        }

        public static List<Product> Products = new List<Product>()
        {
            new Product () {Name = "xBox", Price = 350},
            new Product () {Name = "guitar", Price = 1000},
            new Product () {Name = "blender", Price = 50},
            new Product () {Name = "kite", Price = 25},

        };

        List<Product> IDataAccess.LoadData()
        {
            Console.WriteLine("I am reading data from List Data Access.");
            return Products;
        }

    }

}

