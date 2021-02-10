﻿using BL.Interfaces;
using BL.Models;
using DAL.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Shared.Infrastructure.Filters;
using System.Threading.Tasks;
using WebApi.ViewModels;

namespace WebApi.Controllers
{
    [Route("api/vendors")]
    [Authorize]
    public class VendorController : ControllerBase
    {
        private readonly IVendorService _vendorService;
        private readonly UserManager<User> _userManager;

        public VendorController(IVendorService vendorService, UserManager<User> userManager)
        {
            _vendorService = vendorService;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetVendors()
        {
            return Ok(await _vendorService.GetVendorsAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetVendorById(int id)
        {
            return Ok(await _vendorService.GetVendorByIdAsync(id));
        }

        [HttpGet("{id}/discounts")]
        public async Task<IActionResult> GetVendorDiscounts(int id, SortModel sortModel)
        {
            return Ok(await _vendorService.GetVendorDiscountsAsync(id, sortModel, await _userManager.FindByNameAsync(User.Identity.Name)));
        }

        [HttpPost]
        [Authorize(Roles = "Admin, Moderator")]
        [ValidateModelFilter]
        public async Task<IActionResult> CreateVendor([FromBody] VendorViewModel vendorViewModel)
        {
            return Ok(await _vendorService.CreateVendorAsync(vendorViewModel));
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Admin, Moderator")]
        [ValidateModelFilter]
        public async Task<IActionResult> UpdateVendor(int id, [FromBody]VendorViewModel vendorViewModel)
        {
            vendorViewModel.Id = id;
            return Ok(await _vendorService.UpdateVendorAsync(vendorViewModel));
        }
    }
}
