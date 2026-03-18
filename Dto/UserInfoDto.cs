using PL_VehicleRental.Services.Security;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagementSystem.Dto
{
    public class UserInfoDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }
        public bool isDefaultPassword { get; set; }
        public bool isActive { get; set; }
        public bool isDeleted { get; set; }
        public byte[] UserImage { get; set; }
        public string ImagePath { get; set; }
        public bool isImageChanged { get; set; }

    }

    public class CurrentUser
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public UserRole Role { get; set; }
        public string UserImagePath { get; set; }
    }

    public class AuditLog
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string ActionType { get; set; }
        public string Description { get; set; }
        public string TableAffected { get; set; }
        public DateTime CreatedAt { get; set; }
        public int RecordId { get; set; }
        public string OldValues { get; set; }
        public string NewValues { get; set; }
    }
}
