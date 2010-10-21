using System;

namespace nothinbutdotnetstore.web.core
{
    public interface Request
    {
        InputModel map<InputModel>();
    	Uri get_url();
    }
}