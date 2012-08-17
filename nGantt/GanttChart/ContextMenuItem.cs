using System.Windows.Input;
using nGantt.PeriodSplitter;

namespace nGantt.GanttChart
{
    public delegate void ContextMenuItemClick(GanttTask ganttTask);

    public class ContextMenuItem
    {
        public ContextMenuItem(ContextMenuItemClick contextMenuItemClick, string name)
        {
            ContextMenuItemClickCommand = new DelegateCommand<GanttTask>(x => contextMenuItemClick(x));
            this.Name = name;
        }

        public string Name { get; set; }

        public ICommand ContextMenuItemClickCommand { get; private set; }
    }
}