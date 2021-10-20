using System;
using System.Windows.Forms;
using System.Drawing;

namespace TumbnailDotnet
{
    public class ThumbnailFlowLayoutPanel : FlowLayoutPanel
    {
        protected override Point ScrollToControl(Control activeControl)
        {
            return this.AutoScrollPosition;
        }
    }
}
