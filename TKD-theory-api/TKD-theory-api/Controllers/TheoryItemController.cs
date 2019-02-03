using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using TKDTheoryApi.Models;

namespace TKDTheoryApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TheoryItemController : ControllerBase
    {
        private readonly ITKDTheoryAppContext _context;

        public TheoryItemController(ITKDTheoryAppContext context)
        {
            _context = context;
        }

        [Route("dan/")]
        [HttpGet]
        public ActionResult<IEnumerable<DanTheoryItem>> GetDanTheoryItems()
        {
            try
            {
                var danItems = _context.GetDanTheoryItems();
                return new ActionResult<IEnumerable<DanTheoryItem>>(danItems);
            }
            catch (Exception exc)
            {
                throw exc;
            }

        }

        [Route("dan/{id}")]
        [HttpGet]
        public ActionResult<DanTheoryItem> GetDanTheoryItem(int id)
        {
            var danItem = _context.GetDanTheoryItem(id);
            return danItem;
        }

        [Route("dan/")]
        [HttpPost]
        public ActionResult<DanTheoryItem> PostDanTheoryItem()
        {
            return null;
        }
    }
}