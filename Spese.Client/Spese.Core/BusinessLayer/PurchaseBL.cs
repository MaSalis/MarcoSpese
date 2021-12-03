using Spese.Core.Interfaces;
using Spese.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spese.Core.BusinessLayer
{
    public class PurchaseBL
    {
        private readonly ICategoryRepo _categoryRepo;
        private readonly IUserRepo _userRepo;
        private readonly IPurchaseRepo _purchaseRepo;

        public PurchaseBL(IPurchaseRepo purchaseRepo, IUserRepo userRepo, ICategoryRepo categoryRepo)
        {
            _categoryRepo = categoryRepo;
            _userRepo = userRepo;
            _purchaseRepo = purchaseRepo;

        }

        public Purchase ApproveP(int id)
        {
            return _purchaseRepo.ApproveP(id);
            throw new NotImplementedException();
        }

        public IEnumerable<Purchase> ViewPurchasesLastMonth()
        {
            return _purchaseRepo.ViewPurchasesLastMonth();
            throw new NotImplementedException();
        }



        public IEnumerable<Purchase> ViewPurchasesOfUser(int id)
        {
            return _purchaseRepo.ViewPurchasesOfUser(id);
            throw new NotImplementedException();
        }

        public IEnumerable<Purchase> ViewPurchasesOrdered()
        {
            return _purchaseRepo.ViewPurchasesOrdered();
            throw new NotImplementedException();
        }
    }
}
