﻿using BL.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApi.Controllers
{
    [Route("api/images")]
    [Authorize]
    public class ImageController : ControllerBase
    {
        private readonly IImageService _imageService;
        
        public ImageController(IImageService imageService)
        {
            _imageService = imageService;
        }

        [HttpGet("{id}")]
        public Task<IActionResult> GetImage(int id)
        {
            return Ok();
        }
    }
}
