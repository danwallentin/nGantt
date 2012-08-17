using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nGantt.PeriodSplitter
{
    public class PeriodYearSplitter : PeriodSplitter
    {
        public PeriodYearSplitter(DateTime min, DateTime max)
            : base(min, max)
        { }

        public override List<Period> Split()
        {
            var precedingBreak = new DateTime(min.Year, 1, 1);
            return base.Split(precedingBreak);
        }

        protected override DateTime Increase(DateTime date, int value)
        {
            return date.AddYears(value);
        }
    }
}
