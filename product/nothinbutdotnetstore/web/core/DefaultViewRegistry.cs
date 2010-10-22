using System;
using System.Collections.Generic;

namespace nothinbutdotnetstore.web.core
{
	public class DefaultViewRegistry : ViewRegistry
	{
		private readonly IDictionary<Type, string> _registry;

		public DefaultViewRegistry(IDictionary<Type, string> registry)
		{
			_registry = registry;
		}

		public string get_the_path_to_the_view_that_can_display<ViewModel>()
		{
			return _registry[typeof(ViewModel)];
		}
	}
}