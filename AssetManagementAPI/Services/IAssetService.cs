using AssetManagementAPI.Models;
using Models.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementAPI.Services
{
    public interface IAssetService
    {
        List<dynamic> GetAssetsDetails(int assetId);
        int CreateAsset<T>(T asset, AssetType assetType);
    }
}
