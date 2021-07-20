using System;
using System.Collections.Generic;
using System.Text;

namespace BankLibrary
{
    public class Bank
    {

        public string BankName { get; set; }
        public string BankId { get; set; }
        public string BankAddress { get; set; }
        public string BankZip { get; set; }
        private string BankCity { get; set; }
        public string BankState { get; set; }
        public string _email;
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (value.Contains("@"))
                {
                    _email = value;
                }
                else
                {
                    throw new Exception("Email should have @");
                }
            }
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(BankId);
            sb.AppendLine(BankName);
            sb.AppendLine(BankAddress);
            sb.AppendLine(BankCity);
            sb.AppendLine(BankState);
            sb.Append(" " + BankZip);
            sb.AppendLine(Email);
            return sb.ToString();
        }
    }
}
