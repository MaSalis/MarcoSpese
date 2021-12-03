using Spese.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spese.Mock.Repositories
{
    public class InMemoryStorage
    {

        public static List<Category> Categories = new List<Category>()
        {
            new Category() { Id = 1, Name = "Cat1"},
            new Category() { Id = 2, Name = "Cat2"},
            new Category() { Id = 3, Name = "Cat3"}
        };



        public static List<User> Users = new List<User>() {
            new User() { Id = 1, Name= "Mario", Surname = "Rossi" },
            new User() { Id = 2, Name= "Luca", Surname= "Verdi"},
            new User() { Id = 3, Name= "Sara", Surname= "Bianchi"}
        };

        public static List<Purchase> Purchases = new List<Purchase>()
        {
            new Purchase() { Id = 1, PDate =new DateTime( 2021/11/20), Description = "Smartphone", PAmount = 500, Approved = false, CategoryId = 1, UserId= 3 },
            new Purchase() {Id = 2, PDate =new DateTime( 2021/11/10), Description ="Printer", PAmount = 100, Approved=false, CategoryId = 2, UserId= 2 },
            new Purchase() {Id= 3, PDate= new DateTime(2021/10/15), Description = "PC", PAmount = 1000, Approved=true, CategoryId= 3, UserId = 2}
        };
    }
}
