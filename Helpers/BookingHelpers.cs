using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagementSystem.Dto;

namespace VehicleManagementSystem.Helpers
{
    public static class BookingHelpers
    {
        public static string GenerateCustomBookingID()
        {
            string yearMonth = DateTime.Now.ToString("yyyyMM");
            int randomPart = new Random().Next(1000, 9999);

            return $"BK{yearMonth}-{randomPart}";
        }

    public static PendingInfosDto MapToPendingInfo(BookingDto b)
        {
            return new PendingInfosDto
            {
                BookingID = b.BookingID,
                FirstName = b.FirstName,
                LastName = b.LastName,
                LicenseNumber = b.LicenseNumber,
                Email = b.Email,
                PhoneNumber = b.PhoneNumber,
                VehicleVIN = b.VehicleVIN,
                VehicleName = b.VehicleName,
                LicensePlate = b.LicensePlate,
                ImagePath = b.ImagePath,
                DateSchedOut = b.DateSchedOut,
                DateDue = b.DateDue,
                DateSubmitted = b.DateSubmitted,
                DailyRate = b.DailyRate,
                ProjectedPrice = b.ProjectedPrice
            };
        }

        public static string GetTimeAgo(this DateTime dateTime)
        {
            TimeSpan timeSpan = DateTime.UtcNow - dateTime;

            if (timeSpan.TotalSeconds < 0) return "Just now";

            if (timeSpan.TotalMinutes < 1) return "Just now";
            if (timeSpan.TotalMinutes < 2) return "1 min ago";
            if (timeSpan.TotalMinutes < 60) return $"{(int)timeSpan.TotalMinutes} mins ago";

            if (timeSpan.TotalHours < 2) return "1 hr ago";
            if (timeSpan.TotalHours < 24) return $"{(int)timeSpan.TotalHours} hrs ago";

            if (timeSpan.TotalDays < 2) return "1 day ago";
            if (timeSpan.TotalDays < 7) return $"{(int)timeSpan.TotalDays} days ago";

            return dateTime.ToString("MMM dd, yyyy");
        }

        public static string GetFormattedDate(DateTime date)
        {
            return date.ToString("MM/dd/yyyy hh:mm tt");
        }

        public static string GetRentalDuration(DateTime start, DateTime end)
        {
            TimeSpan duration = end - start;
            if (duration.TotalSeconds <= 0) return "Invalid Dates";
            int days = duration.Days;
            int hours = duration.Hours;
            string dayPart = days > 0 ? $"{days} {(days == 1 ? "Day" : "Days")}" : "";
            string hourPart = hours > 0 ? $"{hours} {(hours == 1 ? "Hour" : "Hrs")}" : "";
            return (days > 0 && hours > 0) ? $"{dayPart}, {hourPart}" : (string.IsNullOrEmpty(dayPart) ? hourPart : dayPart);
        }
    }
}