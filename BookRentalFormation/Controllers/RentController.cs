using BookRentalFormation.Application.Services.RentService;
using Microsoft.AspNetCore.Mvc;

namespace BookRentalFormation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RentController : ControllerBase
    {
        private readonly ILogger<RentController> _logger;
        private readonly IRentService _rentService;


        public RentController(ILogger<RentController> logger, IRentService rentService)
        {
            _logger = logger;
            _rentService = rentService;
        }

        [HttpPost]
        public async Task<IActionResult> RentBook(Guid bookId, Guid userId)
        {
            await _rentService.RentBook(bookId, userId);
            return Ok();
        }
    }
}