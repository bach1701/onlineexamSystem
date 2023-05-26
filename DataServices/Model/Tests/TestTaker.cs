﻿using OnlineExamSystem.DataServicesLayer.Model.School;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExamSystem.DataServicesLayer.Model.Tests
{
    public class TestTaker
    {
        [Key]
        public int TestTakerId { get; set; }


        [ForeignKey("Test")]
        public int TestId;
        public virtual Test Test { get; set; }

        [ForeignKey("User")]
        public int UserId;
        public virtual User Student { get; set; }


        public int TotalTakeTime { get; set; }

        public virtual ICollection<TestTakerResult> TestTakerResults { get; set; }
    }

    public class TestTakerResult
    {
        [Key]
        public int TestTakerResultId { get; set; }

        [ForeignKey("TestTaker")]
        public int TestTakerId { get; set; } 
        public virtual TestTaker TestTaker { get; set; }

        public float FinalScore { get; set; }

        public int TimeTakenSeconds { get; set; }

        // total question answered
        public int SubmitedAnswerCount { get; set; }

        public int CorrectAnswerCount { get; set; }
    }
}
