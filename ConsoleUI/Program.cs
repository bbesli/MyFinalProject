﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //SOLID
    //Bu hareket O hareketidir. Open Closed Principle
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
            //IoC ile bir alt satırdaki koddan kurtulacağız.
            //CategoryTest();
            //DTO: Data Transformation Object



        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine(product.ProdutName + " / " + product.CategoryName);
            }
        }
    }
}