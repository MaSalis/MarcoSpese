using Spese.Core.Interfaces;
using Spese.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spese.Mock.Repositories
{
    public class MockPurchaseRepo : IPurchaseRepo
    {
        public Purchase ApproveP(int id)
        {
            List<Purchase> purchases = InMemoryStorage.Purchases;
            foreach (Purchase p in purchases)
            {
                if (p.Id == id)
                {
                    p.Approved = true;
                    return p;
                };
            }
            return null; 

            // internal IEnumerable<Purchase> ApprovePurchase()

            
        }

        public IEnumerable<Purchase> ViewPurchasesLastMonth()
        {
            var purchases = InMemoryStorage.Purchases.Where(P => P.PDate.Month == 11).ToList();
            return purchases;
            
        }

        public IEnumerable<Purchase> ViewPurchasesOfUser(int id)

        {
            var purchases = InMemoryStorage.Purchases.Where(p => p.UserId == id).ToList();

            
            return purchases;
        }

        public IEnumerable<Purchase> ViewPurchasesOrdered()
        {
            //List<Purchase>  purchases1= new List<Purchase>();
            var purchases = InMemoryStorage.Purchases.OrderBy(p => p.PDate);
            return purchases;

        }

        

        

        

       

        

       

       

        
    }

}
