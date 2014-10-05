.. exercise-0:

=========================================
Exercise 0 - Setup the Enviroment for developing with WebDriver
=========================================

**Topics covered**
  * `Creating Project`_
  * `Add a refrence to WebDriver`_
  * `Build for the first time`_

Creating Project
----------------
Create your fist Visual Studio project
  + Create a working folder where all you work will be stored
     + Open explorer and go to the C drive
     + Create a folder called "CSharpSeleniumExamples"
  + Open Visual Studio
  + In the top menue Select: File > New > Project
  + In the left tree Select: Templates > Visual C# > Windows
  + Select the project type "Console Aplication"
     + Type "Example_0" in the Name textbox 
     + Change the location to "c:\CSharpSeleniumExamples\"
     + Deselect the checkbox "Create a directory for solotion"
     + Click "Ok" button
  + Now save the project by clicking the "Save All" icon, or (Ctrl+Shift+S)

So now you should have a new folder called "CSharpSeleniumExamples" with a new project saved inside a folder called "Example_0".

Add a refrence to WebDriver
---------------------------

  * Download the latest C# WebDriver Bindings from Selenium
     * Go to url: http://www.seleniumhq.org/download/
     * Find the "Selnium Client & Webdriver Language Bindings"
     * Download the C# bindings
     * Create folders to hold the "C# WebDriver Bindings"
        * Create a folder called "externals" at this location "c:\CSharpSeleniumExamples\"
        * Create another called "webdriver" inside the "externals" folder
     * Extract the zip file
     * Copy the extracted files to the new folder named "webdriver"
  * If you dont have the project open already, open it now
     * Open Visual Studio
     * In the top menue Select: File > Open > Project/Solotion
     * browse to the folder "c:\CSharpSeleniumExamples\Example_0" and select the file named "example_0.csproj"
  * If do you already have the project open
     * Find the "Solution Explorer"
        * If the "Solution Explorer" missing go to the top menue Select: View > Solution Explorer 
     * View the refrences already in you project by expanding the "refrences" node in "Solution explorer"
        * There should be bunch of differnt refrences (System, System.Data, System.Xml)
     * Right Click "Refrences" and click "Add Refrences"
     * In the left menue Click "Browse"
     * At the lower right Click the "Browse" button
        * Browse to ""c:\CSharpSeleniumExamples\externals\webdriver\net40\"
        * Select the file named "WebDriver.dll"
        * Click "Add"
     * Click "Ok"
     * Now you should see a "WebDriver" in the list of "Refrences" in "Solution Explorer"
	 * Now save the project by clicking the "Save All" icon, or (Ctrl+Shift+S)
     
Build for the first time
-----------------------_
  * If you dont have the project open already, open it now
      * Open Visual Studio
      * In the top menue Select: File > Open > Project/Solotion
      * browse to the folder "c:\CSharpSeleniumExamples\Example_0" and select the file named "example_0.csproj"
  * If do you already have the project open
      * Find the "Solution Explorer" and double click to open, the file named "Program.cs"
	  * Inside the file you should see special method called "Main"
	  * Type the following code in the Main() n method



