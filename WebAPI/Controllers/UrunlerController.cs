using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UrunlerController : ControllerBase
    {

        IUrunService _urunService;

        public UrunlerController(IUrunService urunService)
        {
            _urunService = urunService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _urunService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("geturunbyurunid")]
        public IActionResult GetUrunByUrunId(int urunId)
        {
            var result = _urunService.GetById(urunId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }



    }
}
