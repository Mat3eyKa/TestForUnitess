﻿using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TestForUnitess.Data;
using TestForUnitess.Models;

namespace TestForUnitess.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly UnitessContext db;
        public HomeController(UnitessContext database) =>
            db = database;

        [HttpGet]
        public IQueryable<Person> Get(int start, int end)
        {
            if (start is 0 && end is 0)
                return db.Events;
            if (start > end)
                (start, end) = (end, start);
            start--;
            if (start < 1)
                return db.Events.Take(end);
            return db.Events.Skip(start).Take(end - start);
        }
    }
}
