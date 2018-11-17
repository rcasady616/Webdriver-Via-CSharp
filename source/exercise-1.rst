.. exercise-1:

================================================================
Exercise 1 - Creating a first WebDriver project
================================================================

If you already know Visual Studio and how to create a C# project you can move on to the next exercise otherwise the steps below will outline how to create a project and add the needed references for using Selenium WebDriver. 
You are going to create a folder where all your work from these exercises will be saved

1. Creating a Solution for the Exercises
----------------------------------------
In these lessons we will use this one solution to hold and build all exercises.

.. sidebar:: Notes

  Solutions are containers used to organize one or more related projects and there compilation. 
  When you open a solution in Visual Studio, it automatically loads all the projects it contains.

+ Open Visual Studio
+ In the top menu Select: ``File`` > ``New`` > ``Project``
+ In the left tree Select: ``Other Project Types`` > ``Visual Studio Solutions``
+ Select the project type ``Blank Solution``
    + Type "WebDriverViaCSharp" in the ``Name`` textbox 
    + Change the location to where you want them stored
    + Click ``Ok`` button
+ Now save the project by clicking the ``Save All`` icon, or (Ctrl+Shift+S)

So now you should have a new solution called: **"WebDriverViaCSharp"**

2. Create a C# Console App project
----------------------------------
Create a project for **Exercise-1**, the project will be in the language of C# and will compile into a exe (executable) that can be run by double clicking

+ From the ``Solution Explorer`` 
    + Right click the solution ``WebDriverViaCSharp``
    + Select ``Add``
    + Select ``New Project...``
+ From the ``Add New Project`` dialog
    + Select ``Visual C#``
    + Select ``Console App(.NET Framework)``
    + Type "Exercise-1" in the ``Name`` textbox 
    + Click ``Ok`` button


3. Add a reference to WebDriver and ChromeDriver
------------------------------------------------
.. sidebar:: Notes

  **NuGet** is a package manager for adding build dependencies in a quick and light weight way

  **Selenium.WebDriver** NuGet package contains the Selenium Webdriver C# binaries needed for creating UI Automation.

  **Selenium.WebDriver.ChromeDriver** NuGet package is the browser specific server needed by WebDriver to interact with Chrome. (FireFox and IE require there own versions in order to work.)

+ From the ``Solution Explorer`` 
      + Right click the solution: ``WebDriverViaCSharp``
      + Select ``Manage NuGet Package For Solution...``
      + To add **Selenium.WebDriver** NuGet package
          + From the ``NuGet Solution*`` dialog
          + Select ``Browse`` from the top Tabs
          + Type ``WebDriver`` in the ``Search`` textbox
          + Click on ``Selenium.WebDriver`` from the list
          + In the right pain click the checkbox next to the project named: ``Exercise-01``
          + Click ``Install``
      + To add **Selenium.WebDriver.ChromeDriver** NuGet package
          + From the ``NuGet Solution*`` dialog
          + Select ``Browse`` from the top Tabs
          + Type ``ChromeDriver`` in the ``Search`` textbox
          + Click on ``Selenium.WebDriver.ChromeDriver`` from the list
          + In the right pain click the checkbox next to the project named: ``Exercise-01``
          + Click ``Install``     

Now you should a have a working C# project that is referencing the needed Selenium WebDriver libraries for Web UI automation

4. Add some code and run it 
---------------------------
Lets add the code to create a browser driver, navigate to a specific url, and then close the browser and end the session.

+ In the ``Solution Explorer`` in the project **Exercise-1**  
    + Double click the file named: "Program.cs" 
	  + Inside the file you should see special method called "Main"
	  + Add the following code (lines 5-7) into the Main() method

.. code-block:: csharp
  :linenos:
  :emphasize-lines: 5,6,7

  class exercise1
  {
    static void Main(string[] args)
    {
      var cDriver = new OpenQA.Selenium.Chrome.ChromeDriver();
      cDriver.Navigate().GoToUrl("http://RickCasady.com");
      cDriver.Dispose();
    }
  }

+ To compile the code and lunch the exe with a debugger attached 
    + Click the ``Start`` button in the toolbar at the top
        + You can accomplish the same by (Clicking ``Debug`` > ``Start Debugging``) or (use the key ``F5``) 

.. topic:: Summary

  - You should be able to create solutions and add projects. 
  - You also should be able to add NuGet packages to you projects. 
  - You should be able to compile, run and  debug your code