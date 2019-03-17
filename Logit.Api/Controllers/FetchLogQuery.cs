using Logit.Api.DomainModels;
using System;

namespace Logit.Api.Controllers
{
    public class FetchLogQuery
    {
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string Description { get; set; }
        public LogStatus Status { get; set; }
    }
}