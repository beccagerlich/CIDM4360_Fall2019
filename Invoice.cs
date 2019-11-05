//Becca Gerlich, Gregory Sprock, & Cedric Whitaker

using System;
using System.Collections.Generic;

namespace Homework_4
{
    class Invoice
    {
        int InvNum;
        string InvDate;
        int total;
        public Invoice(int i, string id)
        {
            InvNum = i;
            InvDate = id;
        }
        public void addInvEntry() // list and int as param
        {
            Invoice inv1 = new Invoice(1231,"12/11/2018");
        }
        public void removeInvEntry(int lineNumber)
        {

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