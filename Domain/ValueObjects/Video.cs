using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObjects
{
    public class Video
    {
        public byte[] Data { get; set; }
        public string Description { get; set; }
    }
}
