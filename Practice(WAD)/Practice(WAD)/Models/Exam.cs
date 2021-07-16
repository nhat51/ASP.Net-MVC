using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Practice_WAD_.Models;

namespace Practice_WAD_.Models
{
    public class Exam
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string StartTime { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public string RoomName { get; set; }
        [Required]
        public string ExamDate { get; set; }
        [Required]
        public int Duration { get; set; }
        [Required]
        public string FacNamee { get; set; }
    }
}