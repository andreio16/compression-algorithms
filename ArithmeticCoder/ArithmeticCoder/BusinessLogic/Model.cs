using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticCoder
{
    class Model
    {
        private uint[] SymbolSums;
        private uint[] SymbolCounts;
        private uint NumberOfSymbols;

        public Model(uint numOfSymbols)
        {
            NumberOfSymbols = numOfSymbols;
            SymbolCounts = new uint[numOfSymbols];
            SymbolSums = new uint[numOfSymbols + 1];
            InitModel();
        }

        private void InitModel()
        {
            SymbolSums[0] = 0;
            for (int i = 0; i < NumberOfSymbols; i++)
            {
                SymbolCounts[i] = 1;
                SymbolSums[i + 1] = SymbolSums[i] + SymbolCounts[i];
            }
        }

        public void UpdateModel(int symbol)
        {
            /* Increment the frequency  */
            SymbolCounts[symbol]++;

            /* Update the cumulative frequencies. */
            for (int i = symbol; i < NumberOfSymbols; i++)
                SymbolSums[i]++;
        }
        
        //--------  Getters for sum[] vector for Coder  --------//
        public uint GetSymbolSumLimitL(int symbol)
        {
            return SymbolSums[symbol];
        }

        public uint GetSymbolSumLimitH(int symbol)
        {
            return SymbolSums[symbol + 1];
        }

        public uint GetSymbolTotalSum()
        {
            return SymbolSums[NumberOfSymbols];
        }

        //--------  Getters for sum[] vector for Decoder  --------//
        public int GetSymbolForSpecifiedSum(uint sum)
        {
            int symbolOfInterest = 0;

            for (int i = 1; i < NumberOfSymbols; i++)
                if (SymbolSums[i] > sum)
                    symbolOfInterest = i;

            return symbolOfInterest;
        }

    }
}
