using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CapstoneProject2
{
    class Book
    {

        private static int BookIdCounter;

        static Book()
        {
            Book.BookIdCounter = 0;

        }
        public Book()
        {
            this._BookId = ++Book.BookIdCounter;
        }

        private int _BookId;
        public int BookId
        {
            get
            {
                return _BookId;
            }
        }

        public string BookName { get; set; }
        public string Author { get; set; }
        public string Publication { get; set; }
        public DateTime AddDateTime { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Cost
        {
            get
            {
                return Price * Quantity;
            }
        }
        public string Type { get; set;}

        public int RemQuantity { get; set; }
        
        public override string ToString()
        {
            return $" {BookId, -5} {BookName, -20} {Author, -20} {Publication, -20} {Type,-20} {AddDateTime,-20} {Quantity,10} {Price,15:C} {Cost,15:C} {RemQuantity,10}";
        }
    }
}
