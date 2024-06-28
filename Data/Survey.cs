using System.ComponentModel.DataAnnotations;

namespace ChaserFood.Data
{
    public class Survey
    {
        [Key] public int SurveyId { get; set; }
        public int StudentId { get; set; } // Primary Key
        public int Focus { get; set; } // 1-5 option
        public int Attendance { get; set; } // 1-5 option
        public int Grades { get; set; } // 1-5 option
        public int Enrolled { get; set; } // 1-5 option
        public int WorkBetter { get; set; } // 1-5 option
        public int StayEmployed { get; set; } // 1-5 option
        public int Treatment { get; set; } // 1-5 option
        public int HoursGood { get; set; } // 1-5 option
        public string? AdditionalProducts { get; set; } // LongText
        public string? AdditionalServices { get; set; } // LongText
        public string? Improvements { get; set; } // LongText
        public string? Comments { get; set; } // LongText
        public bool VolunteerDonor { get; set; }
        public bool VolunteerCommittee { get; set; }
        public string? VolunteerOther { get; set; }
        public int NeedForPantry { get; set; } // 1-5 option
        //1-strongly disagree, 2-disagree, 3-undecided, 4-agree, 5-strongly agree
    }
}
