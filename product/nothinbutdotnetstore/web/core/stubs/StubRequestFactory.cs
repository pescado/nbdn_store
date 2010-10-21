using System;
using System.Web;
using nothinbutdotnetstore.domain;

namespace nothinbutdotnetstore.web.core.stubs
{
    public class StubRequestFactory : RequestFactory
    {
        public Request create_request_from(HttpContext http_context)
        {
            return new StubRequest(http_context.Request.Url);
        }



        class StubRequest : Request
        {
			private Uri _url;

        	public StubRequest(Uri url)
        	{
        		this._url = url;
        	}
			


            public InputModel map<InputModel>()
            {
                throw new NotImplementedException();
            }

        	Uri Request.get_url()
        	{
        		return _url;
        	}
        }
    }
}