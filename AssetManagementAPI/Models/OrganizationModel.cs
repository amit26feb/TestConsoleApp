using System;
using System.Collections.Generic;
using System.Text;

namespace AssetManagementAPI.Models
{
    public class OrganizationModel
    {
        public int OrgId { get; set; }
        public string OrgName { get; set; }
        public List<string> Assets { get; set; }
    }
}
