using Spese.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spese.Core.Interfaces
{
    public interface IPurchaseRepo
    {
        Purchase ApproveP(int id);
        IEnumerable<Purchase> ViewPurchasesLastMonth();
        IEnumerable<Purchase> ViewPurchasesOfUser(int id);
        IEnumerable<Purchase> ViewPurchasesOrdered();
    }
}
