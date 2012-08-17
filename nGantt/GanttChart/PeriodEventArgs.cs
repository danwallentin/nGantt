using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nGantt.GanttChart
{
    public class PeriodEventArgs : EventArgs
    {
        public DateTime SelectionStart { get; set; }
        public DateTime SelectionEnd { get; set; }
    }
}
