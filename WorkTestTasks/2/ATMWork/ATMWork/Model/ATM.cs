﻿using System;
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
                    AtmCurrentLoad.Add(Convert.ToInt32(line), DefaultAtmLoad);
                }

                if (AtmCurrentLoad.Count == 0)
                {
                    throw new ArgumentException("BankNote file is Empty!");
                }
            }
        }

        public Dictionary<int, int> CalculateWithDraw(int sum, int preferNominal)
        {
            var bankNotesNominal = AtmCurrentLoad.Keys.OrderByDescending(c => c).ToArray();

            var result = new Dictionary<int, int>();

            var i = 0;

            while (bankNotesNominal[i] != preferNominal)
            {
                result.Add(bankNotesNominal[i], 0);
                i++;
            }

            for (; i < bankNotesNominal.Length; i++)
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
