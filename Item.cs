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
            return this.Description;
        }
        public float getPrice()
        {
            return this.UnitPrice;
        }
        public int getItemID()
        {
            return this.ID;
        }
        public int updtAvlblQnty(int passedValue)//pass item and get qnty out of it
        {
            // order.AvailableQty = order.AvailableQty - order.;
            //needs work
            return this.AvailableQty -= passedValue;
        }
        public int getAvlblQnty()
        {
            return this.AvailableQty;
        }
        public void displayItem()
        {
            Console.WriteLine($"{this.ID}\t{this.Description}\t{this.UnitPrice}\t{this.AvailableQty}");
        }
    }
}
