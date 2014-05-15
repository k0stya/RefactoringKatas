using System.Collections.Generic;
using System.Web;
using Refactoring.SroutClass;

namespace Refactoring.SproutClass
{
	public class ActiveCustomer
	{
		private readonly HttpContext _context;

		public string Name { get; set; }
		public int Id { get; set; }
		public List<Client> Clients { get; set; } 

		public ActiveCustomer(HttpContext context)
		{
			_context = context;
			LoadCustomerFromDataBase();
		}

		private void LoadCustomerFromDataBase()
		{
			// Loads customer from data base
		}

		public void AddActiveCustomerToCookie()
		{
			_context.Response.Cookies.Add(new HttpCookie("activecustomer", ToString()));
		}
	}
}
