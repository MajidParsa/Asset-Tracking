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
		private IEnumerable<Currency> _currencies =>
			new List<Currency>()
			{
				new Currency(1, "Rial", "Iran", 100, DateTime.Now),
				new Currency(2, "Dollar", "USA", 1000, DateTime.Now)
			};


		public CurrencyController()
		{
		}

		[HttpGet("getCurrencies")]
		public ActionResult<IEnumerable<Currency>> GetCurrencies()
		{
			return Ok(_currencies);
		}

		[HttpGet("getCurrency")]
		public ActionResult<Currency> GetCurrency(int id)
		{
			var currency = _currencies.FirstOrDefault(c => c.Id == id);
			return Ok(currency);
		}

		[HttpPost("Add")]
		public ActionResult<Currency> AddCurrency([FromBody] Currency currency)
		{
			currency.Rate = currency.Rate * 2;
			return Ok(currency);
		}

		[HttpPost("Update")]
		public ActionResult<Currency> UpdateCurrency([FromBody] Currency currency)
		{
			currency.Name = "Test";
			return Ok(currency);
		}
	}

	public class Currency
	{
		public Currency(int id, string name, string country, int rate, DateTime date)
		{
			Id = id;
			Name = name;
			Country = country;
			Rate = rate;
			Date = date;
		}

		public Currency()
		{
		}

		public int Id { get; set; }
		public string Name { get; set; }
		public string Country { get; set; }
		public int Rate { get; set; }
		public DateTime Date { get; set; }
	}
}
