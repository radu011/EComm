﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EComm.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class ProductTypeController : ControllerBase
    {
        private readonly IProductTypeService _productTypeService;

        public ProductTypeController(IProductTypeService productTypeService)
        {
            _productTypeService = productTypeService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<ProductTypeController>>>> GetProductTypes()
        {
            var response = await _productTypeService.GetProductTypes();
            return Ok(response);
        }

		[HttpPost]
		public async Task<ActionResult<ServiceResponse<List<ProductTypeController>>>> AddProductType(ProductType productType)
		{
			var response = await _productTypeService.AddProductType(productType);
			return Ok(response);
		}

		[HttpPut]
		public async Task<ActionResult<ServiceResponse<List<ProductTypeController>>>> UpdateProductType(ProductType productType)
		{
			var response = await _productTypeService.UpdateProductType(productType);
			return Ok(response);
		}
	}
}
