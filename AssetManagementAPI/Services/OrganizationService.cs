using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementAPI.Services
{
    public class OrganizationService : IOrganizationService
    {
        public List<string> GetAssets(int organizationId)
        {
            List<string> assetList = new List<string>();
            string assetCSVNameList = "Computer,Printer";
            foreach (string item in assetCSVNameList.Split(","))
            {
                assetList.Add(item);
            }
            return assetList;
        }

    }
}
