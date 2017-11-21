using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LEDDisplay
{
    class DisplayProvider_Stats : DisplayProvider
    {
        public static new string Title
        {
            get
            {
                return "Computer Stats";
            }
        }

        public override void Draw(ref ScrollingFrameBuffer buffer)
        {
            PerformanceCounter perfMemCount = new PerformanceCounter("Memory", "Available MBytes");

            string ramString = String.Format("{0}MB RAM", (int)perfMemCount.NextValue());

            buffer = new ScrollingFrameBuffer(LEDFont.stringWidth(ramString));
            buffer.ViewOffset = -21;
            LEDFont.DrawString(ref buffer, 0, ramString);
        }

        public override void OnClick(object sender, EventArgs e)
        {
            Draw(ref LEDDisplayApp.frameBuffer);
            LEDDisplayApp.HandleClick(Title);
        }
    }
}
