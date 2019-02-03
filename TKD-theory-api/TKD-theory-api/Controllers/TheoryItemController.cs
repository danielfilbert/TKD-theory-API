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

        [Route("kor/")]
        [HttpGet]
        public ActionResult<IEnumerable<KorTheoryItem>> GetKorTheoryItems()
        {
            var korItems = _context.GetKorTheoryItems();
            return new ActionResult<IEnumerable<KorTheoryItem>>(korItems);
        }
        
        [Route("dan/")]
        [HttpGet]
        public ActionResult<IEnumerable<DanTheoryItem>> GetDanTheoryItems()
        {
            var danItems = _context.GetDanTheoryItems();
            return new ActionResult<IEnumerable<DanTheoryItem>>(danItems);
        }

        [Route("eng/")]
        [HttpGet]
        public ActionResult<IEnumerable<EngTheoryItem>> GetEngTheoryItems()
        {
            var engItems = _context.GetEngTheoryItems();
            return new ActionResult<IEnumerable<EngTheoryItem>>(engItems);
        }

        [Route("kor/{id}")]
        [HttpGet]
        public ActionResult<KorTheoryItem> GetKorTheoryItem(int id)
        {
            var korItem = _context.GetKorTheoryItem(id);
            if(korItem == null)
            {
                return NotFound();
            }
            return new ActionResult<KorTheoryItem>(korItem);
        }
        
        [Route("dan/{id}")]
        [HttpGet]
        public ActionResult<DanTheoryItem> GetDanTheoryItem(int id)
        {
            var danItem = _context.GetDanTheoryItem(id);
            if(danItem == null)
            {
                return NotFound();
            }
            return new ActionResult<DanTheoryItem>(danItem);
        }

        [Route("eng/{id}")]
        [HttpGet]
        public ActionResult<EngTheoryItem> GetEngTheoryItem(int id)
        {
            var engItem = _context.GetEngTheoryItem(id);
            if(engItem == null)
            {
                return NotFound();
            }
            return new ActionResult<EngTheoryItem>(engItem);
        }

        //[Route("dan/")]
        //[HttpPost]
        //public ActionResult<DanTheoryItem> PostDanTheoryItem()
        //{
        //    return null;
        //}
    }
}