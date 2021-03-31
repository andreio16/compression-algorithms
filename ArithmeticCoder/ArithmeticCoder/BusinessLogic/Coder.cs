using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticCoder
{
    class Coder
    {
        private UInt64 Range;
        private BitWriter Writer;

        private UInt32 High = 0xFFFFFFFF;
        private UInt32 Low = 0x00000000;

        private readonly UInt32 FirstShiftingMask_1 = 0x80000000;
        private readonly UInt32 FirstShiftingMask_2 = 0x0FFFFFFF;

        private readonly UInt32 SecondShiftingMask = 0xC0000000;
        private readonly UInt32 SecondShigtingHigh = 0x80000000;
        private readonly UInt32 SecondShigtingLow = 0x40000000;

        public Coder(BitWriter writer)
        {
            Writer = writer;
        }
        
    }
}
