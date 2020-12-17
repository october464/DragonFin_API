using Finportal.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DragonFin_API.Models
{
    public class Transaction
    {
        public int Id { get; set; }

        public int? CategoryItemId { get; set; }

        public int BankAccountId { get; set; }

        public string FPUserId { get; set; }

        public DateTimeOffset Created { get; set; }

        public TransactionType Type { get; set; }

        public string Memo { get; set; }

        public decimal Amount { get; set; }


        public bool IsDeleted { get; set; }


    }

        
}
