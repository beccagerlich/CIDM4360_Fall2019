//Becca Gerlich, Gregory Sprock, & Cedric Whitaker

using System;
using System.Collections.Generic;

namespace Homework_4
{
    class Item
    {
        int ID;
        string Description;
        float UnitPrice;
        int AvailableQty;
        public Item(int id, string d, float up, int aq)
        {
            ID = id;
            Description  = d;
            UnitPrice = up;
            AvailableQty = aq;
        }
        public string getItemDescription()
        {
            return Description;
        }
        public float getPrice()
        {
            return UnitPrice;
        }
        public int getItemID()
        {
            return ID;
        }
        public int updtAvlblQnty(int qnty)//pass item and get qnty out of it
        {
            AvailableQty = AvailableQty - qnty;
            //needs work
            return AvailableQty;
        }
        public int getAvlblQnty()
        {
            return AvailableQty;
        }
        public string displayItem()
        {
            return ID+" "+Description+" "+UnitPrice+" "+AvailableQty;
        }
    }
}
