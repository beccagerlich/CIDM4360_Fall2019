//Becca Gerlich, Gregory Sprock, & Cedric Whitaker

using System;
using System.Collections.Generic;

namespace Homework_4
{
    class InvoiceEntry
    {
        List<Item> items {get; set;}
        List<Invoice> invoices {get; set;}
        int LineNo;
        int Qnty;
        public InvoiceEntry(int l, int q)
        {
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