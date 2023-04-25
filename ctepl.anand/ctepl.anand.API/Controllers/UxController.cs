using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ctepl.anand.DTO;
using ctepl.anand.Service;
using Microsoft.AspNetCore.Mvc;

namespace ctepl.anand.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class UxController : ControllerBase
    {
        private readonly IUxService _uxService;

        public UxController(IUxService uxService)
        {
            _uxService = uxService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UxDTO>>> Get()
        {
            return await _uxService.GetUxDesigns();
        }

        [HttpPost]
        public async Task<ActionResult<UxDTO>> Post(UxDTO uxDTO)
        {
            return await _uxService.CreateUxDesign(uxDTO);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<UxDTO>> Put(int id, UxDTO uxDTO)
        {
            return await _uxService.UpdateUxDesign(id, uxDTO);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _uxService.DeleteUxDesign(id);
            return NoContent();
        }
    }
}