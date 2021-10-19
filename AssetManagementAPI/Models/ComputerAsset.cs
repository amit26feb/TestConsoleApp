using AssetManagementAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssetManagementAPI.Models
{
    public class ComputerAsset : AssetModel
    {
        public int RAMCapacity { get; set; }

        public decimal CPU { get; set; }
    }
}
