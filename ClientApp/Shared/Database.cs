using System;
using System.Collections.Generic;
using Notez.Shared.Models;

namespace Notez
{
    public static class Database
    {
        public static List<NotesDTO> Notes = new List<NotesDTO>();

        public static List<LectureDTO> Lectures = new List<LectureDTO>();
    }
}