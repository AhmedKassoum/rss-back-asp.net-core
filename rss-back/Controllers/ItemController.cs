using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using rss_back.Services;
using rss_back.Models;

namespace rss_back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        ItemService _service;

        public ItemController(ItemService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<Item> GetAll() { return _service.GetAll(); }

        [HttpGet("{guid}")]
        public ActionResult<Item> GetByGuid(Guid guid) 
        {
            var item = _service.GetByGuid(guid);
            if(item is not null)
            {
                return item;
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public ActionResult Create(Item newItem)
        {
            var item=_service.Create(newItem);
            return CreatedAtAction(nameof(GetByGuid), new { guid = item.Guid }, item);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid guid)
        {
            var item = _service.GetByGuid(guid);

            if (item is not null)
            {
                _service.Delete(guid);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
