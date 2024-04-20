﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO {
    public class DTO_Payment {
        public string PaymentId { get; set; }
        public DateTime DateCreated { get; set; }
        public int Month {  get; set; }
        public string Status { get; set; }
        public string Note { get; set; }
        public float Promotion {  get; set; }
        public int Number_Of_Session {  get; set; }

        public DTO_Payment( string paymentId, DateTime dateCreated, int month, string status, string note, float promotion, int n_session ) { 
            PaymentId = paymentId;
            DateCreated = dateCreated;
            Month = month;
            Status = status;
            Note = note;
            Promotion = promotion;
            Number_Of_Session = n_session;
        }

    }
}