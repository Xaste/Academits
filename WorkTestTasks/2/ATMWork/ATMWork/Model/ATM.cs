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
        public int Balance { get; set; }

        public int MaxBankNotes { get; private set; }

        public int DefaultLoadOut { get; private set; }

        public Dictionary<int, int> _ATMLoadOut { get; private set; } = new Dictionary<int, int>();

        public ATM(int maxBankNotes, int defaultLoadOut)
        {
            DefaultLoadOut = defaultLoadOut;

            GetBankNotesData();
            MaxBankNotes = maxBankNotes;

            Balance = 0;           
        }

        public bool AddBankNote(int amount)
        {
            if (_ATMLoadOut[amount] >= MaxBankNotes)
            {
                return false;
            }

            _ATMLoadOut[amount]++;
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
                    _ATMLoadOut.Add(Convert.ToInt32(line), DefaultLoadOut);
                }
            }
        }

        public Dictionary<int, int> CalculateWithDraw(int sum, int preferNominal)
        {
            var bankNotesNominals = _ATMLoadOut.Keys.OrderByDescending(c => c).ToArray();

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

                if (amount > _ATMLoadOut[bankNotesNominals[i]])
                {
                    amount = _ATMLoadOut[bankNotesNominals[i]];
                }

                sum -= amount * bankNotesNominals[i];

                _ATMLoadOut[bankNotesNominals[i]] -= amount;

                result.Add(bankNotesNominals[i], amount);
            }

            return result;
        }
    }
}
