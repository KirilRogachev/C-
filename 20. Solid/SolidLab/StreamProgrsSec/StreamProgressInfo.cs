using System;
using System.Collections.Generic;
using System.Text;

namespace P01.Stream_Progress
{
    public class StreamProgressInfo
    {
        private IComponents component;

        // If we want to stream a music file, we can't
        public StreamProgressInfo(IComponents component)
        {
            this.component = component;
        }

        public int CalculateCurrentPercent()
        {
            return (this.component.BytesSent * 100) / this.component.Length;
        }
    }
}
