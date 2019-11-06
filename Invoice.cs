//Becca Gerlich, Gregory Sprock, & Cedric Whitaker

using System;
using System.Collections.Generic;

namespace Homework_4
{
    class Invoice
    {
        public List<InvoiceEntry> invoiceEntries = new List<InvoiceEntry>();
        int InvNum;
        string InvDate;
        int total;
        public Invoice(int i, string id)
        {
            InvNum = i;
            InvDate = id;
        }
        public void addInvEntry(List<Item> item, int ReqQuantity) 
        {
            int lineNumber = invoiceEntries.Count +1;
            InvoiceEntry invEnt = new InvoiceEntry(item, lineNumber, ReqQuantity);
            invoiceEntries.Add(invEnt);
        }
        public void removeInvEntry(InvoiceEntry i)//???
        {
            if(invoiceEntries.Contains(i))
            {
                invoiceEntries.Remove(i);
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