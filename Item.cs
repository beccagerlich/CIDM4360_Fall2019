//Becca Gerlich, Gregory Sprock, & Cedric Whitaker

using System;
using System.Collections.Generic;

namespace Homework_4
{
    class Item
    {
        int ID;
        float UnitPrice;
        string Description;
        int AvailableQty;
        public Item(int id, string d, float up, int aq)
        {
            ID = id;
            UnitPrice = up;
            Description  = d;
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
        public void updtAvlblQnty(int passedValue)
        {

        }
        public void getAvlblQnty()
        {

        }
        public void displayItem()
        {
            Console.WriteLine();
        }
    }
}
