using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace nGantt.GanttChart
{
    public class GanttRow
    {
        public GanttRowHeader RowHeader { get; set; }
        public ObservableCollection<GanttTask> Tasks { get; set; }
    }
}
