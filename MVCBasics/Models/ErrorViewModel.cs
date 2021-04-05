using System;

namespace MVCBasics.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public object Content { get; internal set; }
    }
}
