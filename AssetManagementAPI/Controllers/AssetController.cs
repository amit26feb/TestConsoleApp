using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssetManagementAPI.Models;
using AssetManagementAPI.Services;
using Models.enums;

namespace AssetManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssetController : ControllerBase
    {
        public IAssetService _assetService;
        public AssetController(IAssetService assetService)
        {
            _assetService = assetService;
        }

        [HttpGet]
        [Route("AssetDetail/{assetId}")]
        [ProducesResponseType(typeof(List<dynamic>), 200)]
        [ProducesResponseType(204)]
        [ProducesResponseType(500)]
        public IActionResult Get(int assetId)
        {
            if (assetId != 0)
            {
                List<dynamic> asset = _assetService.GetAssetsDetails(assetId);
                if (asset != null)
                    return Ok(asset);
                else
                    return NoContent();
            }

            return BadRequest("Invalid Id");
        }        

        [HttpPost]
        [Route("NewAsset")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public IActionResult Create<T>(T asset, AssetType assetType)
        {
            if (asset != null)
            {
                int id = _assetService.CreateAsset<T>(asset, assetType);
                return Ok(id);
            }

            return BadRequest("Invalid Input");
        }
    }
}
