using Konditer.Context.Contracts.Models;
using Microsoft.AspNetCore.Mvc;

namespace Konditer.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TovarController : ControllerBase
    {
        private readonly IContext context1;
        public TovarController(IContext context1)
        {
            this.context1 = context1;
        }
        [HttpGet] //localhost:111224/group
        public IActionResult GetAllTovar()
        {
            var tovarlist = context1.Tovars.ToList();
            return Ok(tovarlist);
        }
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var tovarlist = context1.Tovars.FirstOrDefault(x => x.Id == id);
            return Ok(tovarlist);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var group3 = context1.Tovars.FirstOrDefault(x => x.Id == id);
            if (group3 != null)
            {
                context1.Tovars.Remove(group3);
            }
            return Ok();
        }
        [HttpPost]
        public IActionResult Create(Tovar model)
        {
            var item3 = new Tovar
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
                Opis = model.Opis,
                Value = model.Value,
                CreatedAT = DateTime.Now,
                CreatedBy = "Я",
                UpdatedAt = DateTime.Now,
                UpdatedBy = "Я богатырь!"
            };
            context1.Tovars.Add(item3);
            return Ok(item3);
        }
        [HttpPut("{id}")]
        public IActionResult Edit(Guid Id, Tovar model)
        {
            var group3 = context1.Tovars.FirstOrDefault(x => x.Id == Id);
            if (group3 != null)
            {
                return NotFound();
            }
            group3.Name = model.Name;
            group3.Opis = model.Opis;
            group3.Value = model.Value;
            group3.UpdatedAt = DateTime.Now;
            return Ok(group3);
        }
    }
}
