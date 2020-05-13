using System;
using System.Collections.Generic;
using System.Text;

namespace P01.Stream_Progress
{
  public  class Components
    {
        public Components(int length, int bytesSent)
        {
            this.Length = length;
            this.BytesSent = bytesSent;
        }
        public int Length { get; set; }

        public int BytesSent { get; set; }
    }

}
