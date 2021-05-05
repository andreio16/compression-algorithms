using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearLosslessBMPVisualizer
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

        public void UpdateModel(uint symbol)
        {
            /* Increment the frequency  */
            SymbolCounts[symbol]++;

            /* Update the cumulative frequencies. */
            for (uint i = symbol + 1; i < NumberOfSymbols + 1; i++)
                SymbolSums[i]++;
        }
        
        //--------  Getters for sum[] vector for Coder  --------//
        public uint GetSymbolSumLimitL(uint symbol)
        {
            return SymbolSums[symbol];
        }

        public uint GetSymbolSumLimitH(uint symbol)
        {
            return SymbolSums[symbol + 1];
        }

        public uint GetSymbolTotalSum()
        {
            return SymbolSums[NumberOfSymbols];
        }

        //--------  Getters for sum[] vector for Decoder  --------//
        public uint GetSymbolForSpecifiedSum(uint sum)
        {
            uint symbol;
            for (symbol = NumberOfSymbols - 1; sum < SymbolSums[symbol]; symbol--);
            return symbol;
        }

    }
}
