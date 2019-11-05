//Becca Gerlich, Gregory Sprock, & Cedric Whitaker

using System;
using System.Collections.Generic;

namespace Homework_4
{
    class Invoice
    {
        public List<InvoiceEntry> invoiceentries = new List<InvoiceEntry>();
        int InvNum;
        string InvDate;
        int total;
        public Invoice(int i, string id)
        {
            InvNum = i;
            InvDate = id;
        }
        public void addInvEntry(int l, int q) 
        {
            InvoiceEntry invEnt = new InvoiceEntry(l,q);
            invoiceentries.Add(invEnt);
        }
        public void removeInvEntry(InvoiceEntry i)//???
        {
            if(invoiceentries.Contains(i))
            {
                invoiceentries.Remove(i);
            }
        }
        private void updateTotal()
        {
            
        }
        private void updateLineNumbers()
        {
            
        }
        public void printInvoice()
        {

        }
    }
}