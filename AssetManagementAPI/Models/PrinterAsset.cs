using AssetManagementAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssetManagementAPI.Models
{
    public class PrinterAsset : AssetModel
    {
        public int PrintPerPage { get; set; }

        public string Location { get; set; }
    }
}
