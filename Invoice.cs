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
        float total;
        public Invoice(int i, string id)
        {
            InvNum = i;
            InvDate = id;
        }
        public bool addInvEntry(Item item, int ReqQuantity) // needs verification
        {
            // int lineNumber = invoiceEntries.Count +1; //item.getAvailibility()
            // InvoiceEntry invEnt = new InvoiceEntry(lineNumber, ReqQuantity);
            // invoiceEntries.Add(invEnt);

            int avlQty = item.getAvlblQnty();
            if (avlQty < ReqQuantity)
            {
                return false;
            }
            int newQty = item.updtAvlblQnty(ReqQuantity);
            InvoiceEntry invoiceEntry = new InvoiceEntry(1231, ReqQuantity);
            invoiceEntries.Add(invoiceEntry); // ???
            int qty = invoiceEntry.getQnty();
            return true;
        }
        public bool removeInvEntry(int lineNumber)// needs verification
        {
            if(invoiceEntries.Contains(lineNumber))
            {
                InvoiceEntry removeInvEnt = invoiceEntries.Find(lineNumber);
                invoiceEntries.Remove(removeInvEnt);
            }
            
            return true;
        }
        private float updateTotal(float newValue)
        {
            return this.total += newValue;
        }
        private void updateLineNumbers()
        {
            
        }
        public void printInvoice()
        {
            Console.WriteLine($"Invoice #: {this.InvNum}\tDate: {this.InvDate}");
        }
    }

  
    //     public bool removeInvEntry(int lineNum)
    //     {


    //         return true;
    //     }
    // }
}