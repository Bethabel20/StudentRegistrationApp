using System;
using System.ComponentModel.DataAnnotations;

namespace StudentRegistrationApp.Models
{
	public class Student
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "Name is required")]
		[Display(Name = "Full Name")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Email is required")]
		[EmailAddress]
		public string Email { get; set; }

		[Required(ErrorMessage = "Phone number is required")]
		[Phone]
		public string Phone { get; set; }

		[DataType(DataType.Date)]
		[Display(Name = "Enrollment Date")]
		public DateTime EnrollmentDate { get; set; } = DateTime.Now;
	}
}
