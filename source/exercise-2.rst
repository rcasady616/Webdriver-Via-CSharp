.. exercise-2:

=================================
Exercise 2 - A Good First Program
=================================


.. code-block :: csharp

	FirefoxDriver ff = new FirefoxDriver();
	ff.Navigate().GoToUrl("http://RickCasady.com");
	ff.Dispose();
	  
Now your code should look like this


.. code-block:: csharp

	using OpenQA.Selenium.Firefox;
	class exercise1
	{
		static void Main(string[] args)
		{
			FirefoxDriver ff = new FirefoxDriver();
			ff.Navigate().GoToUrl("http://RickCasady.com");
			ff.Dispose();
		}
	}
