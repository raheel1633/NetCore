using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class QbRequest
    {
        public int QbRequestLineId { get; set; }
        public int? QbwcId { get; set; }
        public string Request { get; set; }
        public string Response { get; set; }
        public string QbListId { get; set; }
        public string QbSequenceId { get; set; }
        public string Filename { get; set; }
    }
}
