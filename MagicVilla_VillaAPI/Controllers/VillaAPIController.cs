﻿using MagicVilla_VillaAPI.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace MagicVilla_VillaAPI.Controllers
{
    [Route("api/VillaAPI")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<VillaDTO> GetVillas()
        {
            return new List<VillaDTO>
            {
                new VillaDTO { Id = 1 , Name = "Pool View"},
                new VillaDTO { Id = 2, Name = "Beach View"}
            };
        }
    }
}