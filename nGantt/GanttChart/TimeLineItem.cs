using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;

namespace nGantt.GanttChart
{
    public class TimeLineItem 
    {
        public TimeLineItem()
        {
            BackgroundColor = new SolidColorBrush(Colors.Transparent);
        }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Name { get; set; }
        public Brush BackgroundColor { get; set; }
    }
}
