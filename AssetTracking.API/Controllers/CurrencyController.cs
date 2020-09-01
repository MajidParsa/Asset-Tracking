using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssetTracking.API.Controllers
{
	
	[Route("api/[controller]")]
	[ApiController]
	public class CurrencyController : ControllerBase
	{
		public CurrencyController()
		{
		}

		[HttpGet("getCurrencies")]
		public ActionResult<IEnumerable<Currency>> Get()
		{
			var currencies = new List<Currency>()
			{
				new Currency("Rial", "Iran", 100, DateTime.Now),
				new Currency("Dollar", "USA", 1000, DateTime.Now)
			};

			return Ok(currencies);
		}
	}

	public class Currency
	{
		public Currency(string name, string country, int rate, DateTime date)
		{
			Name = name;
			Country = country;
			Rate = rate;
			Date = date;
		}

		public string Name { get; set; }
		public string Country { get; set; }
		public int Rate { get; set; }
		public DateTime Date { get; set; }
	}
}
