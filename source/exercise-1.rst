.. exercise-1:

================================================================
Exercise 1 - Setup the Environment for developing with WebDriver
================================================================

**Topics covered**
  * `Creating Project`_
  * `Add a reference to WebDriver`_
  * `Build for the first time`_

Creating Project
----------------
Create your fist Visual Studio project
  + Create a working folder where all you work will be stored
     + Open explorer and go to the C drive
     + Create a folder called "CSharpSeleniumExamples"
  + Open Visual Studio
  + In the top menu Select: File > New > Project
  + In the left tree Select: Templates > Visual C# > Windows
  + Select the project type "Console Application"
     + Type "Example_0" in the Name textbox 
     + Change the location to "c:\CSharpSeleniumExamples\"
     + Deselect the checkbox "Create a directory for solution"
     + Click "Ok" button
  + Now save the project by clicking the "Save All" icon, or (Ctrl+Shift+S)

So now you should have a new folder called "CSharpSeleniumExamples" with a new project saved inside a folder called "Example_0".

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
     * browse to the folder "c:\CSharpSeleniumExamples\Example_0" and select the file named "example_0.csproj"
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
     
Build for the first time
------------------------
  * If you dont have the project open already, open it now
      * Open Visual Studio
      * In the top menu Select: File > Open > Project/Solution
      * browse to the folder "c:\CSharpSeleniumExamples\Example_0" and select the file named "example_0.csproj"
  * If do you already have the project open
      * Find the "Solution Explorer" and double click to open, the file named "Program.cs"
	  * Inside the file you should see special method called "Main"
	  * Type the following code in the Main() n method
