using System.Collections.Generic;
using System.Linq;

namespace nothinbutdotnetstore.domain.stubs
{
	public class StubProductRepository
	{
		public IEnumerable<Product> get_the_products_in_a_department(Department department)
		{
			return Enumerable.Range(1, 100).Select(x => new Product { name = x.ToString("A Product In A Department 0") });
		}
	}
}
