using System;

namespace MNB
{
    internal class RateDate
    {
        public DateTime Date { get; internal set; }
        public string Currency { get; internal set; }
        public decimal Value { get; internal set; }
    }
}