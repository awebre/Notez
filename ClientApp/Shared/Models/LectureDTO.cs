using System;

namespace Notez.Shared.Models
{
    public class LectureDTO
    {
        public Guid SessionGuid { get; set; } = Guid.Empty;

        public string Name { get; set; }

        public string Link { get; set; }

        public DateTimeOffset? StartDateTime { get; set; }

        public DateTimeOffset? EndDateTime { get; set; }

        public bool CanStart => !IsStarted;

        public bool CanEnd => IsStarted && !IsEnded;

        public bool IsStarted => StartDateTime.HasValue;

        public bool IsEnded => EndDateTime.HasValue;
    }
}