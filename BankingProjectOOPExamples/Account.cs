using System;
using System.Collections.Generic;
using System.Text;

namespace BankingProjectOOPExamples {
    public class Account {

        public string Number { get; set; }
        private decimal Balance { get; set; } = 0.0M; // M = decimal
        public string Name { get; set; }
        public bool IsActive { get; set; } = true;

        public void Deposit(decimal Amount) {
            if (Amount <= 0) {
                Console.WriteLine("Deposit amounts must be greater than zero");
            }
            else {
                this.Balance += Amount;
            }
        }
        public void Withdraw(decimal Amount) {
            if (Amount <= 0) {
                Console.WriteLine("Withdraw amount must be GT zero");
            } else {
                if (this.Balance >= Amount) {
                    this.Balance -= Amount;
                }
            }
        }
        public decimal GetBalance() {
            return this.Balance;
        }
    }
    }
