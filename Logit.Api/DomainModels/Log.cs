using System;

namespace Logit.Api.DomainModels
{
    public class Log
    {
        public int Id { get; internal set; }
        public DateTime CreatedDate { get; internal set; }
        public string CreatedBy { get; internal set; }
        public string Description { get; internal set; }
        public LogStatus Status { get; internal set; }
    }
}