﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace CareerCloud.Pocos
{
    [Table("Applicant_Educations")]
    public class ApplicantEducationPoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }
       
        public Guid Applicant { get; set; }

        public string? Major { get; set; }

        [Column("Certificate_Diploma")]
        public String? CertificateDiploma { get; set; }
        
        [Column("Start_Date")]
        public DateTime? StartDate { get; set; }
                
        [Column("Completion_Date")]
        public DateTime? CompletionDate { get; set; }
        
        [Column("Completion_Percent")]
        public Byte? CompletionPercent { get; set; }
        
        [Column("Time_Stamp")]
        
        public Byte[]? TimeStamp { get; set; }

       
    }
}

