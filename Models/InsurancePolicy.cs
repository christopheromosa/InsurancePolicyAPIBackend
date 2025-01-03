using System;
using System.ComponentModel.DataAnnotations;

namespace InsurancePolicyAPIBackend.Models
{
    public class InsurancePolicy
    {
        [Key]
        public int Id { get; set; } // Primary Key

        [Required]
        [MaxLength(100)]
        public string PolicyNumber { get; set; } = ""; // Unique Identifier for the policy

        [Required]
        [MaxLength(200)]
        public string PolicyHolderName { get; set; } = "";// Name of the policyholder

        [Required]
        [MaxLength(100)]
        public string PolicyType { get; set; } = ""; // E.g., Health, Vehicle, Life, etc.

        [Required]
        public DateTime StartDate { get; set; } // Policy Start Date

        [Required]
        public DateTime EndDate { get; set; } // Policy End Date

        [Required]
        [Range(0, double.MaxValue)]
        public decimal PremiumAmount { get; set; } // Policy premium cost

        [Required]
        public bool IsActive { get; set; } // Indicates if the policy is currently active
    }
}
