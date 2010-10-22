using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Machine.Specifications;
using Machine.Specifications.DevelopWithPassion.Rhino;
using nothinbutdotnetstore.domain;
using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.specs.web
{
	class ViewRegistrySpecs
	{
		public abstract class concern : Observes<ViewRegistry, DefaultViewRegistry>
		{

		}

		[Subject(typeof(DefaultViewRegistry))]
		public class when_getting_the_path_to_the_view_for_a_viewmodel : concern
		{
			Establish c = () =>
          	{
          		view_model_type = typeof (Department);
          		expected_path = "blah";

				registry = new Dictionary<Type, string>();
				registry.Add(view_model_type, expected_path);
				provide_a_basic_sut_constructor_argument<IDictionary<Type, string>>(registry);
          	};

			Because b = () =>
				result = sut.get_the_path_to_the_view_that_can_display<Department>();

			private It should_return_the_correct_path = () =>
			     result.ShouldEqual(expected_path);

		static Type view_model_type;
	    static Dictionary<Type, string > registry;
		static string result;
		static string expected_path;
		}
	}
}
