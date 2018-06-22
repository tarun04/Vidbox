﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VidBox.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? BirthDate { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }

        //public MembershipType MembershipType { get; set; }
        //public byte MembershipTypeId { get; set; }
    }
}