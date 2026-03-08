using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_VehicleRental.Services.Security
{
    public static class RolePermissionMap
    {
        public static readonly Dictionary<UserRole, List<Permission>> Map =
            new Dictionary<UserRole, List<Permission>>()
            {
                {
                    UserRole.Superadmin,
                    Enum.GetValues(typeof(Permission))
                        .Cast<Permission>()
                        .ToList()
                },
                {
                    UserRole.Admin,
                    new List<Permission>
                    {
                        Permission.ManageUsers,
                        Permission.AddUser,
                        Permission.EditUser,
                        Permission.DeleteUser,
                        Permission.ManageVehicles,
                        Permission.ViewReports
                    }
                },
                {
                    UserRole.Staff,
                    new List<Permission>
                    {
                        Permission.ManageVehicles
                    }
                }
            };
    }
}
