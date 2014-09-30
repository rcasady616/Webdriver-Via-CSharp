.. example-1:

=========================================
Example 1 - A Good First Program
=========================================


.. code-block:: csharp
	FirefoxDriver ff = new FirefoxDriver();
	ff.Navigate().GoToUrl("http://RickCasady.com");
	ff.Dispose();
	  
Now your code should look like this

.. code-block:: csharp

	using OpenQA.Selenium.Firefox;

	namespace example_0
	{
		class Program
		{
			static void Main(string[] args)
			{
				FirefoxDriver ff = new FirefoxDriver();
				ff.Navigate().GoToUrl("http://RickCasady.com");
				ff.Dispose();
			}
		}
	}
	
