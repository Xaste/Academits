using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMWork.Model
{
    class ATM
    {
        private int _balance;
        private int _maxBankNotesCapacity;

        public int Balance
        {
            get { return _balance; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException($"{nameof(value)} не может быть отрицательным.");
                }

                _balance = value;
            }
        }

        public int MaxBankNotesCapacity
        {
            get
            {
                return _maxBankNotesCapacity;
            }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException($"{nameof(value)} не может быть меньше 1");
                }

                _maxBankNotesCapacity = value;
            }
        }

        public int DefaultLoadOut { get; private set; }

        public Dictionary<int, int> ATMLoadOut { get; private set; } = new Dictionary<int, int>();

        public ATM(int defaultBalance, int maxBankNotes, int defaultLoadOut)
        {
            DefaultLoadOut = defaultLoadOut;

            GetBankNotesData();
            MaxBankNotesCapacity = maxBankNotes;

            Balance = defaultBalance;
        }

        public bool AddBankNote(int amount)
        {
            if (ATMLoadOut[amount] >= MaxBankNotesCapacity)
            {
                return false;
            }

            ATMLoadOut[amount]++;
            Balance += amount;
            return true;
        }

        private void GetBankNotesData()
        {
            using (var reader = new StreamReader("Banknotes.txt"))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    ATMLoadOut.Add(Convert.ToInt32(line), DefaultLoadOut);
                }
            }
        }

        public Dictionary<int, int> CalculateWithDraw(int sum, int preferNominal)
        {
            var bankNotesNominals = ATMLoadOut.Keys.OrderByDescending(c => c).ToArray();

            var result = new Dictionary<int, int>();

            var i = 0;

            while (bankNotesNominals[i] != preferNominal)
            {
                result.Add(bankNotesNominals[i], 0);
                i++;
            }

            for (; i < bankNotesNominals.Length; i++)
            {
                var amount = (int)sum / bankNotesNominals[i];

                if (amount > ATMLoadOut[bankNotesNominals[i]])
                {
                    amount = ATMLoadOut[bankNotesNominals[i]];
                }

                sum -= amount * bankNotesNominals[i];

                ATMLoadOut[bankNotesNominals[i]] -= amount;

                result.Add(bankNotesNominals[i], amount);
            }

            return result;
        }
    }
}
