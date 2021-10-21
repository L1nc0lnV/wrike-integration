using System;
using System.Collections.Generic;
using System.Text;

namespace Wrike.IO.Model
{
    class CreateWrikeTask
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Importance { get; set; }
        public object Dates { get; set; }
        public Array Shareds { get; set; }
        public Array Parents { get; set; }
        public Array Responsibles { get; set; }
        public Array Followers { get; set; }
        public bool Follow { get; set; }
        public string PriorityBefore { get; set; }
        public string PriorityAfter { get; set; }
        public Array SuperTasks { get; set; }
        public Array Metadata { get; set; }
        public Array CustomFields { get; set; }
        public string CustomStatus { get; set; }
        public object EffortAllocation { get; set; }
        public string BillingType { get; set; }
        public Array Fields { get; set; }
    }
}
