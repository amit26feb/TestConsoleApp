using AssetManagementAPI.Models;
using Models.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementAPI.Services
{
    public class AssetService : IAssetService
    {
        public int CreateAsset<T>(T asset, AssetType assetType)
        {
            int id = 0;
            switch (assetType)
            {
                case AssetType.Computer:
                    ComputerAsset computer = asset as ComputerAsset;
                    //insert in db
                    return id = 1;

                case AssetType.Printer:
                    PrinterAsset printer = asset as PrinterAsset;
                    //insert in db
                    return id = 2;
                default:
                    return id = 0;
            }

        }
       
        public List<dynamic> GetAssetsDetails(int assetId)
        {
            List<dynamic> assetList = new List<dynamic>();
            string assetCSVNameList = "Computer,Printer";

            foreach (string item in assetCSVNameList.Split(","))
            {
                switch (item.ToLower())
                {
                    case "computer":

                        ComputerAsset computerAsset = new ComputerAsset()
                        {
                            AssetName = "Computer",
                            AssetStatus = AssetStatus.InService,
                            CPU = 3.5m,
                            CurrentValue = GetValue(5000, 4, 2020),
                            PurchaseYear = 2020,
                            RAMCapacity = 32
                        };
                        assetList.Add(computerAsset);
                        break;
                    case "printer":
                        PrinterAsset printerAsset = new PrinterAsset()
                        {
                            AssetName = "Printer",
                            AssetStatus = AssetStatus.InService,
                            Location = "Bangalore",
                            CurrentValue = GetValue(5000, 6, 2020),
                            PurchaseYear = 2020,
                            PrintPerPage = 2
                        };
                        assetList.Add(printerAsset);
                        break;
                    default:
                        break;
                }
            }

            return assetList;
        }

        private int GetValue(int actualValue, int lifeOfAsset, int purchaseYear)
        {
            int currentYear = DateTime.Now.Year;
            int currentValue = actualValue;
            for (int i = 0; i < currentYear - purchaseYear; i++)
            {
                currentValue = currentValue / lifeOfAsset * 2;
            }

            return currentValue;
        }
    }
}
