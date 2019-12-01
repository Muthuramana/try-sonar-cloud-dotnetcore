using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MK.TrySonarCloud.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class TreatsController : ControllerBase
    {
        public IEnumerable<string> WhatCanIGet() => new string[] { "colouring", "lego", "ipad", "tv", "chocolates" };
        public string Good(string action) => "lego";
    }
}