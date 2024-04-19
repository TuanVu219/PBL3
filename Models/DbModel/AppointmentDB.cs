﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using PBL3Hos.Models.DbModel;
namespace PBL3Hos.Models.DbModel
{
  

  
        public class AppointmentDB
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

            public int Id { get; set; } // Khóa chính của Appointment

        public DateTime Date { get; set; } // Thời gian cuộc hẹn

            // Khóa ngoại trỏ đến Doctor
            [ForeignKey("Doctor")]
            public string DoctorId { get; set; }
            public UserDoctor Doctor { get; set; }

            // Khóa ngoại trỏ đến Patient
            [ForeignKey("Patient")]
            public string PatientId { get; set; }
            public UserPatient Patient { get; set; }
        }

    

}
