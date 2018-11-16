.. exercise-1:

================================================================
Exercise 1 - Creating a first C# project
================================================================

If you already know Visual Studio and how to create a C# project you can move on to the next exercise otherwise the steps below will outline how to create a project and add the needed references for using Selenium WebDriver. 
You are going to create a folder where all your work from these exercises will be saved

Creating a C# Project
---------------------
Create your fist Visual Studio project
  + Create a working folder where all you work will be stored
     + Open explorer and go to the C drive
     + Create a folder called "CSharpSeleniumExamples"
  
  + Open Visual Studio
  + In the top menu Select: `File` > `New` > `Project`
  + In the left tree Select: `Other Project Types` > `Visual Studio Solutions`
  + Select the project type `Blank Solution`
     + Type `CSharpSeleniumExamples` in the Name textbox 
     + Change the location to where you want them stored
     + Click "Ok" button
     
  + Now save the project by clicking the "Save All" icon, or (Ctrl+Shift+S)

So now you should have a new folder called "CSharpSeleniumExamples" with a new project saved inside a folder called "Exercise_0".

Add a reference to WebDriver
----------------------------
  * Download the latest C# WebDriver Bindings from Selenium
     * Go to url: http://www.seleniumhq.org/download/
     * Find the "Selenium Client & Webdriver Language Bindings"
     * Download the C# bindings
     * Create folders to hold the "C# WebDriver Bindings"
        * Create a folder called "externals" at this location "c:\CSharpSeleniumExamples\"
        * Create another called "webdriver" inside the "externals" folder
     * Extract the zip file
     * Copy the extracted files to the new folder named "webdriver"
  * If you dont have the project open already, open it now
     * Open Visual Studio
     * In the top menu Select: File > Open > Project/Solution
     * browse to the folder "c:\CSharpSeleniumExamples\Exercise_0" and select the file named "exercise_0.csproj"
  * If do you already have the project open
     * Find the "Solution Explorer"
        * If the "Solution Explorer" missing go to the top menu Select: View > Solution Explorer 
     * View the references already in you project by expanding the "references" node in "Solution explorer"
        * There should be bunch of different references (System, System.Data, System.Xml)
     * Right Click "References" and click "Add References"
     * In the left menu Click "Browse"
     * At the lower right Click the "Browse" button
        * Browse to ""c:\CSharpSeleniumExamples\externals\webdriver\net40\"
        * Select the file named "WebDriver.dll"
        * Click "Add"
     * Click "Ok"
     * Now you should see a "WebDriver" in the list of "References" in "Solution Explorer"
	 * Now save the project by clicking the "Save All" icon, or (Ctrl+Shift+S)

Now you should a have a working C# project that is referencing the needed Selenium WebDriver libraries for Web UI automation

Build for the first time
------------------------
  * If you dont have the project open already, open it now
      * Open Visual Studio
      * In the top menu Select: File > Open > Project/Solution
      * browse to the folder "c:\CSharpSeleniumExamples\Exercise_0" and select the file named "exercise_0.csproj"
  * If do you already have the project open
      * Find the "Solution Explorer" and double click to open, the file named "Program.cs"
	  * Inside the file you should see special method called "Main"
	  * Type the following code in the Main() n method

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
