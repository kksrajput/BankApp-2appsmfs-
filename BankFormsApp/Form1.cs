using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankLibrary;

namespace BankFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btntest_Click(object sender, EventArgs e)
        {
            var testBank = new Bank();
           
            testBank.BankState = BankState.Text;
            testBank.BankAddress = BankAddress.Text;
            testBank.BankZip = BankZip.Text;
            testBank.BankId = BankId.Text;
            testBank.BankName = BankName.Text;
            
            try { 
            testBank.Email = BankEmail.Text;
               }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show(testBank.ToString());
        }
    }
}
