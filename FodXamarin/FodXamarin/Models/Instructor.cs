using System;
using System.Collections.Generic;
using System.Text;

namespace FodXamarin.Models
{
    public class Instructor
    {
        Random r = new Random();
        public Instructor(string name, string language, string nationality, string gender, string phone, string email, string education, string oneLineTitle, string description, string experience, string hourlyRate, string courseDomain, string city, string imagePath)
        {
            int randomNumber = r.Next(1, 51);
            Id=randomNumber;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Language = language ?? throw new ArgumentNullException(nameof(language));
            Nationality = nationality ?? throw new ArgumentNullException(nameof(nationality));
            Gender = gender ?? throw new ArgumentNullException(nameof(gender));
            Phone = phone ?? throw new ArgumentNullException(nameof(phone));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            Education = education ?? throw new ArgumentNullException(nameof(education));
            OneLineTitle = oneLineTitle ?? throw new ArgumentNullException(nameof(oneLineTitle));
            Description = description ?? throw new ArgumentNullException(nameof(description));
            Experience = experience ?? throw new ArgumentNullException(nameof(experience));
            HourlyRate = hourlyRate ?? throw new ArgumentNullException(nameof(hourlyRate));
            CourseDomain = courseDomain ?? throw new ArgumentNullException(nameof(courseDomain));
            City = city ?? throw new ArgumentNullException(nameof(city));
            ImagePath = imagePath ?? throw new ArgumentNullException(nameof(imagePath));
        }
        public Instructor()
        {

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Language { get; set; }
        public string Nationality { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Education { get; set; }
        public string OneLineTitle { get; set; }
        public string Description { get; set; }
        public string Experience { get; set; }
        public string HourlyRate { get; set; }
        public string CourseDomain { get; set; }
        public string City { get; set; }
        public string ImagePath { get; set; }
    }
}
