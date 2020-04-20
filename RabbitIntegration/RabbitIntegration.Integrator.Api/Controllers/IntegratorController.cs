using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RabbitIntegration.Integrator.Application.Interfaces;
using RabbitIntegration.Integrator.Application.Models;

namespace RabbitIntegration.Integrator.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IntegratorController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public IntegratorController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CoverValidation orderModel)
        {
            _orderService.EnterOrder(orderModel);
            return Ok(orderModel);
        }
    }
}
