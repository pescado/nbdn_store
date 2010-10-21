using System;
using System.Collections;
using System.Collections.Generic;
using nothinbutdotnetstore.web.application;

namespace nothinbutdotnetstore.web.core.stubs
{
    public class StubSetOfCommands : IEnumerable<WebCommand>
    {
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<WebCommand> GetEnumerator()
        {
        	List<WebCommand> allCommands = new List<WebCommand>();

			allCommands.Add(new DefaultWebCommand(x => x.get_url().ToString().Contains("department.store"), new ViewDepartmentsInDepartment()));
			allCommands.Add(new DefaultWebCommand(x => true, new ViewProductsInADepartment()));
            allCommands.Add(new DefaultWebCommand(x => true, new ViewMainDeparmentsInTheStore()));

        	return allCommands.GetEnumerator();
        }
    }
}