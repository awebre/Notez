using System;

namespace Notez.Shared.Models
{
    public class LectureDTO
    {
        public Guid Id { get; set; } = Guid.Empty;

        public string Name { get; set; }

        public string VideoLink { get; set; }

        public DateTimeOffset? StartDateTime { get; set; }

        public DateTimeOffset? EndDateTime { get; set; }

        public bool CanStart => !IsStarted;

        public bool CanEnd => IsStarted && !IsEnded;

        public bool IsStarted => StartDateTime.HasValue;

        public bool IsEnded => EndDateTime.HasValue;

        public string JoinLink => $"https://localhost:5001/notes/{Id}";
    }
}