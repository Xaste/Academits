using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMWork.Model
{
    internal class Atm
    {
        private int _balance;
        private int _maxBankNotesCapacity;

        public int Balance
        {
            get => _balance;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException($"Баланс не может быть отрицательным.");
                }

                _balance = value;
            }
        }

        public int MaxBankNotesCapacity
        {
            get => _maxBankNotesCapacity;
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException($"Вместимость банкомата не может быть меньше 1");
                }

                _maxBankNotesCapacity = value;
            }
        }

        public int DefaultAtmLoad { get; }

        public Dictionary<int, int> AtmCurrentLoad { get; } = new Dictionary<int, int>();

        public Atm(int defaultBalance, int maxBankNotes, int defaultAtmLoad)
        {
            if (defaultBalance < 0)
            {
                throw new ArgumentException("Баланс не может быть меньше 0");
            }
            if (maxBankNotes < 0)
            {
                throw new ArgumentException("Вместимость не может быть меньше 0");
            }
            if (defaultAtmLoad < 0)
            {
                throw new ArgumentException("Вместимость по умолчанию не может быть меньше 0");
            }
            if (defaultAtmLoad > maxBankNotes)
            {
                throw new ArgumentException("Банкнот по умолчанию не может быть больше, чем вместимость.");
            }

            DefaultAtmLoad = defaultAtmLoad;

            GetBankNotesData();
            MaxBankNotesCapacity = maxBankNotes;

            Balance = defaultBalance;
        }

        public bool AddBankNote(int amount)
        {
            if (AtmCurrentLoad[amount] >= MaxBankNotesCapacity)
            {
                return false;
            }

            AtmCurrentLoad[amount]++;
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
                    if (AtmCurrentLoad.ContainsKey(Convert.ToInt32(line)))
                    {
                        continue;
                    }

                    AtmCurrentLoad.Add(Convert.ToInt32(line), DefaultAtmLoad);
                }

                if (AtmCurrentLoad.Count == 0)
                {
                    throw new ArgumentException("BankNote file is Empty!");
                }
            }
        }

        public Dictionary<int, int> CalculateWithDraw(int sum, int[] preferNominal)
        {
            var bankNotesNominal = new int[preferNominal.Length];
            Array.Copy(preferNominal, bankNotesNominal, preferNominal.Length);

            Array.Sort(bankNotesNominal, new Comparison<int>((i1, i2) => i2.CompareTo(i1)));

            var result = new Dictionary<int, int>();

            for (int i = 0; i < bankNotesNominal.Length; i++)
            {
                var amount = (int)sum / bankNotesNominal[i];

                if (amount > AtmCurrentLoad[bankNotesNominal[i]])
                {
                    amount = AtmCurrentLoad[bankNotesNominal[i]];
                }

                sum -= amount * bankNotesNominal[i];

                AtmCurrentLoad[bankNotesNominal[i]] -= amount;

                result.Add(bankNotesNominal[i], amount);
            }

            return result;
        }
    }
}
