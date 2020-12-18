using Lab01;

using System;
using System.Text;


namespace Lab04
{
    public class StudentExtended : Student
    {
        public DateTime BirthDate;
        public DateTime Admission;
        public string Faculty; 
        public string Specialty_number; 
        public int Age
        {
            get
            {
                var age = DateTime.Today.Year - BirthDate.Year;
                if (BirthDate.Date > DateTime.Today.AddYears(-age)) age--;
                return age;
            }
        }
        public int CourseNo
        {
            get
            {
                var courseNo = DateTime.Today.Year - Admission.Year;
                if (DateTime.Today.Month > 8) courseNo++;
                return courseNo;
            }
        }
        public int SemesterNO
        {
            get
            {
                var semesterNo = CourseNo * 2;
                if (DateTime.Today.Month > 8 || DateTime.Today.Month < 2) semesterNo--;
                return semesterNo;
            }
        }
        public string GroupNo
        {
            get
            {
                return $"{Faculty}{Specialty_number}{Admission.ToString("yy")}";
            }
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Name: {FirstName} ");
            sb.AppendLine($"Lastname: {LastName} ");
            sb.AppendLine($"Phone: {PhoneNumber} ");
            sb.AppendLine($"Email: {EMail} ");
            sb.AppendLine($"BirthDate: {BirthDate.ToString("yyyy,MM,dd")} ");
            sb.AppendLine($"Date of Admission: {Admission.ToString("yyyy,MM,dd")} ");
            sb.AppendLine($"Faculty:{Faculty} ");
            sb.AppendLine($"Specialty Number: {Specialty_number} ");
            sb.AppendLine($"Age: {Age} ");
            sb.AppendLine($"CourseNo:{CourseNo} ");
            sb.AppendLine($"SemesterNo:{SemesterNO} ");
            sb.AppendLine($"GroupeNo: {GroupNo}");
            return sb.ToString();
        }
    }
}