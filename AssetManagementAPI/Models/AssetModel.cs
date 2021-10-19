using Models.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssetManagementAPI.Models
{
    public class AssetModel
    {
        public int AssetId { get; set; }
        public string AssetName { get; set; }

        //public Asset AssetType { get; set; }
        public int PurchaseYear { get; set; }
        public int CurrentValue { get; set; }
        public int AssetLife { get; set; }

        public AssetStatus AssetStatus { get; set; }
    }
}
