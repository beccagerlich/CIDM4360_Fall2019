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
        public InvoiceEntry( int l, int q)
        {
            LineNo = l;
            Qnty = q;
        }
        public int getLineNumber()
        {
            return this.LineNo;
        }
        public void setLineNumber(int lineNum)
        {

        }
        public int getQnty()
        {
            return this.Qnty;
        }
    }
}