using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class product
    {
        public string Name {  get; set; }
        private decimal Price;
        private int StockQuantity;
        public int Avalable;


        public decimal price
        {
            get { return Price; }
            set
            {
                if (value >= 0)
                    Price = value;
            }
        }
      public int stock
        { 
            get
            { 
                return StockQuantity;
            }
            set 
            { 
                if (value >= 0)
                StockQuantity = value;
            }
        }


        // (true or false )لتاكد من ان المنتج موجود ولا لا بترد ب  
        public bool IsAvailable
        {
            get { return StockQuantity > 0; }
        }

        public void  updataStock(int quantity)
        { 
            if (StockQuantity + quantity > 0)
            {
                StockQuantity += quantity;
            } 
            
        }
        public void downdataStock(int quantity) 
        { 
            if (StockQuantity - quantity > 0)
            {
                StockQuantity -= quantity;
            }
        }


    }
}
