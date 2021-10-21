using System;
using System.Collections.Generic;
using System.Text;

namespace Wrike.IO.Model
{
    class CreateWrikeTaskResponse
{
        public string Id { get; set; }
        public string AccountId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string BriefDescription { get; set; }
        public Array ParentIds { get; set; }
        public Array SuperParentIds { get; set; }
        public Array ResponsibleIds { get; set; }
        public string Status { get; set; }
        public string Importance { get; set; }
        public string createdDate { get; set; }
        public string UpdatedDate { get; set; }
        public string CompletedDate { get; set; }
        public object Dates { get; set; }
        public string Scope { get; set; }
        public Array AuthorIds { get; set; }
        public Array CustomStatusId { get; set; }
        public bool HasAttachments { get; set; }
        public int AttachmentCount { get; set; }
        public string Permalink { get; set; }
        public string Priority { get; set; }
        public bool FollowedByMe { get; set; }
        public Array FollowerIds { get; set; }
        public bool Recurrent { get; set; }
        public Array SuperTaskIds { get; set; }
        public Array SubTaskIds { get; set; }
        public Array DependencyIds { get; set; }
        public Array Metadata { get; set; }
        public Array CustomFields { get; set; }
        public string BillingType { get; set; }
        public object EffortAllocation { get; set; }
        public object Finance { get; set; }
    }
}
