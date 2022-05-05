using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjWPFShopping
{
    class Products
    {
        private String strProduct;
        private int iID;
        private int iPrice;
        private int iQty;

        public Products(string strProduct, int iID, int iPrice, int iQty)
        {
            this.StrProduct = strProduct;
            this.IID = iID;
            this.IPrice = iPrice;
            this.IQty = iQty;
        }

        public string StrProduct { get => strProduct; set => strProduct = value; }
        public int IID { get => iID; set => iID = value; }
        public int IPrice { get => iPrice; set => iPrice = value; }
        public int IQty { get => iQty; set => iQty = value; }

        public override string ToString()
        {
            return "ID: " + iID + "\n"+
                   "Product Name: " + strProduct + "\n" +
                   "Price: R" + iPrice + "\n" +
                   "Quantity: " + iQty;
        }
        public string ProductName()
        {
            return ""+strProduct;
        }
    }
}
