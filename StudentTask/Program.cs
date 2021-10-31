using System;

namespace StudentTask
{
    class Student
    {
        public string fullName;
        public byte course;
        public string subject;
        public string university;
        public string email;
        public string phoneNumber;
        public Student(string fullName)
        {
            this.fullName = fullName;
        }
        public Student(string fullName, byte course)
        {
            this.fullName = fullName;
            this.course = course;
        }
        public Student(byte course, string fullName)
        {
            this.course = course;
            this.fullName = fullName;
        }

        public string DisplayInf(string fullName, byte course, string subject, string university, string email, string phoneNumber)
        {
            this.fullName = fullName;
            this.course = course;
            this.subject = subject;
            this.university = university;
            this.email = email;
            this.phoneNumber = phoneNumber;
            return $"The student's full name is {fullName}, the is on {course} course, studying {subject}, in the {university}, the email is {email}, the phone number is {phoneNumber}";
        }
    }
}
