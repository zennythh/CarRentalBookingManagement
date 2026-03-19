using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace VehicleManagementSystem.Classes {
    public static class Helpers {

        public static Color GetStatusColor(string status) {
            switch (status.ToLower()) {
                case "rented":
                    return Color.FromArgb(142, 154, 175);
                case "inmaintenance":
                    return Color.FromArgb(255, 183, 3);
                case "outofservice":
                    return Color.FromArgb(230, 57, 70);
                default:
                    return Color.FromArgb(82, 183, 136);
            }
        }

        public static Image GetVehicleImage(string ImagePath) {
            string fullImagePath = Path.Combine(
                AppConfig.AppData.RootPath,
                ImagePath
            );

            if (File.Exists(fullImagePath)) {
                return Image.FromFile(fullImagePath);
            }

            return global::VehicleManagementSystem.Properties.Resources.default_car_model;
        }

        static public string SaveImageToAppData(string sourceImagePath, string subFolder) {
            string targetPath = Path.Combine(
                AppConfig.AppData.RootPath, 
                AppConfig.AppData.ImagesPath, 
                subFolder
            );

            Directory.CreateDirectory(targetPath);

            string fileName = Guid.NewGuid().ToString() + Path.GetExtension(sourceImagePath);
            string destinationPath = Path.Combine(targetPath, fileName);

            File.Copy(sourceImagePath, destinationPath, true);

            return Path.Combine(AppConfig.AppData.ImagesPath, subFolder, fileName);
        }

        static public string SaveDocumentToAppData(string sourceImagePath, string subFolder, string fileName) {
            string targetPath = Path.Combine(
                AppConfig.AppData.RootPath,
                AppConfig.AppData.DocumentsPath,
                subFolder
            );

            Directory.CreateDirectory(targetPath);

            string destinationPath = Path.Combine(targetPath, fileName);

            File.Copy(sourceImagePath, destinationPath, true);

            return Path.Combine(AppConfig.AppData.DocumentsPath, subFolder, fileName);
        }

        static public string ConvertToCapitalized(string value) {
            if(string.IsNullOrEmpty(value)) return value;

            string _value = value.Trim();

            return char.ToUpper(_value[0]) + _value.Substring(1);
        }

    }
}
