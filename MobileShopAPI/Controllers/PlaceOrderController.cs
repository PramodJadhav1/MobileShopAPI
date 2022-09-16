using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileShopAPI.Model;
using MobileShopAPI.Services;

namespace MobileShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaceOrderController : ControllerBase
    {
        private readonly IPlaceOrderService _service;
        public PlaceOrderController(IPlaceOrderService service)
        {
            _service = service;
        }
        [HttpGet]
        [Route("GetAllPlaceOrders")]
        public IActionResult GetAllPlaceOrders()
        {
            try
            {
                return new ObjectResult(_service.GetAllPlaceOrders());

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }
        [HttpGet]
        [Route("GetPlaceOrderById/{id}")]
        public IActionResult GetPlaceOrderById(int? id)
        {
            try
            {
                return new ObjectResult(_service.GetPlaceOrderById(id));

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        [HttpPost]
        [Route("AddPlaceOrder")]
        public IActionResult AddPlaceOrder([FromBody] PlaceOrder o)
        {
            try
            {
                int res = _service.AddPlaceOrder(o);
                if (res == 1)
                {
                    return StatusCode(StatusCodes.Status201Created);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }
        [HttpPost]
        [Route("UpdatePlaceOrder")]
        public IActionResult UpdatePlaceOrder([FromBody] PlaceOrder o)
        {
            try
            {
                int res = _service.UpdatePlaceOrder(o);
                if (res == 1)
                {
                    return StatusCode(StatusCodes.Status200OK);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }
        [HttpGet]
        [Route("DeletePlaceOrder/{id}")]
        public IActionResult DeletePlaceOrder(int? id)
        {
            try
            {
                int res = _service.DeletePlaceOrder(id);
                if (res == 1)
                {
                    return StatusCode(StatusCodes.Status200OK);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }



    }
}
