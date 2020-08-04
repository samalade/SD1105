using System;
using System.Collections.Generic;
using System.Linq;

namespace DailyBlogger.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }


}