//Becca Gerlich, Gregory Sprock, & Cedric Whitaker

using System;
using System.Collections.Generic;

namespace Homework_4
{
    class InvoiceEntry
    {
        List<Item> itemObjects = new List<Item>();
        int LineNo;
        int Qnty;
        public void ItemInvoice(Item i)
        {
            itemObjects.Add(i);
        }
        public InvoiceEntry(List<Item> i, int l, int q)
        {
            itemObjects = i;
            LineNo = l;
            Qnty = q;
        }
        public int getLineNumber()
        {
            return LineNo;
        }
        public void setLineNumber(int ln)
        {

        }
        public int getQnty()
        {
            return Qnty;
        }
    }
}