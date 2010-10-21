using nothinbutdotnetstore.domain;
using nothinbutdotnetstore.domain.stubs;
using nothinbutdotnetstore.web.core;
using nothinbutdotnetstore.web.core.stubs;

namespace nothinbutdotnetstore.web.application
{
    public class ViewProductsInADepartment : ApplicationCommand
    {
        ResponseEngine response_engine;
        ProductRepository product_repository;

    	public ViewProductsInADepartment():this(new StubResponseEngine(), new StubProductRepository())
    	{
    		
    	}

        public ViewProductsInADepartment(ResponseEngine response_engine, ProductRepository product_repository)
        {
            this.response_engine = response_engine;
            this.product_repository = product_repository;
        }

        public void process(Request request)
        {
            response_engine.display(product_repository.get_the_products_in(request.map<Department>()));
        }
    }
}