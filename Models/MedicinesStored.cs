using System;
using System.Collections.Generic;

namespace PharmaCite_Pharmacy_Managment_System.Models
{
    public partial class MedicinesStored
    {
        public MedicinesStored()
        {
            MedicinesSold = new HashSet<MedicinesSold>();
            UserCompliants = new HashSet<UserCompliants>();
        }

        public long MedicineId { get; set; }
        public string MedicineName { get; set; }
        public string Category { get; set; }
        public decimal UnitPrice { get; set; }
        public long AvailableQuantity { get; set; }
        public DateTime StoredDate { get; set; }

        public virtual ICollection<MedicinesSold> MedicinesSold { get; set; }
        public virtual ICollection<UserCompliants> UserCompliants { get; set; }
    }
}
