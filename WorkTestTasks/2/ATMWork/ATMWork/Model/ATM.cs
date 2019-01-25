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
        //public const int MAX_ATM_CAPACITY = 50;

        public double Balance { get; set; }

        public int MaxBankNotes { get; private set; }

        public int CurrentBankNotesCount { get; private set; }

        private Dictionary<int, int> _aTMCapacity = new Dictionary<int, int>();

        public ATM(int maxBankNotes)
        {
            MaxBankNotes = maxBankNotes;
            CurrentBankNotesCount = 0;
            Balance = 0;
        }

        public void AddCash(int bankNoteDenominal)
        {
            if (AddBankNote(bankNoteDenominal))// не нравится, подумать как сделать по другому
            {
                Balance += bankNoteDenominal;
            }
        }

        public bool AddBankNote(int amount)
        {
            if (_aTMCapacity[amount] >= MaxBankNotes)
            {
                return false;
            }

            _aTMCapacity[amount]++;
            return true;
        }

        public void GetCash(double sum, int PreferBankNote)
        {

        }

        private void GetBankNotesData()
        {
            using (var reader = new StreamReader("Banknotes.txt"))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    _aTMCapacity.Add(Convert.ToInt32(line), 0);
                }
            }
        }
    }
}
