using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusinessAccessLayer.UnitOfWork.Interface;
using Newtonsoft.Json;

namespace ThreeTireArchitechture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemorandumController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public MemorandumController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [Route("GetMemorandum")]
        public IActionResult GetMemorandum()
        {
            var data = _unitOfWork.MemorandumService.GetMemorandum();
            return Ok(JsonConvert.SerializeObject(data));
        }
    }
}
