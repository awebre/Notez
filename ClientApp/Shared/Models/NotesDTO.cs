using System;

namespace Notez.Shared.Models
{
    public class NotesDTO
    {
        public Boolean Private { get; set; }
        public int LectureID { get; set; }
        public String Note { get; set; }
        public DateTime Created { get; set; }
    }
}