using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DragonFin_API.Models
{
    /// <summary>
    /// Shows the Category that the user wants to set up a budget for
    /// </summary>
    public class Category
    {/// <summary>
    /// Primary Key
    /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Shows what Category belongs to a household
        /// </summary>
        public int HouseholdId { get; set; }

        public string Name { get; set; }


        public string Description { get; set; }


        public virtual Household Household { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }



        public virtual ICollection<CategoryItem> CategoryItems { get; set; }
        public Category()
        {
            Transactions = new HashSet<Transaction>();
            CategoryItems = new HashSet<CategoryItem>();
        }
    }
}
