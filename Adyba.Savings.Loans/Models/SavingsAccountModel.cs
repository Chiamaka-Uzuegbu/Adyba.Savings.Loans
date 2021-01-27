using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adyba.Savings.Loans.Models
{
    public class SavingsAccountModel
    {
        public string AccountNumber { get; set; }
        public DateTime AccountCreationDate { get; set; }
        public bool IsActive { get; set; }
        public int AccountOwnerID { get; set; }
    }
}
