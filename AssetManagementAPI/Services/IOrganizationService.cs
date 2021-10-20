using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementAPI.Services
{
    public interface IOrganizationService
    {
        List<string> GetAssets(int organizationId);
    }
}
