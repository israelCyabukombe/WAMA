﻿using System.Collections.Generic;

namespace WAMA.Core.Models.DTOs
{
    public class UserAccount : TableRow
    {
        public string MemberId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UserAccountType AccountType { get; set; }
        public bool IsSuspended { get; set; }

        public virtual LogInCredential LogInCredential { get; set; }
        public virtual List<Certification> Certifications { get; set; }
        public virtual IList<Waiver> Waivers { get; set; }
        public virtual IList<CheckInActivity> CheckInActivities { get; set; }
    }
}