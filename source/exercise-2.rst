.. exercise-2:

======================================
Exercise 2 - What is a WebDriver
======================================

.. sidebar:: OpenQA.Selenium.Chrome.ChromeDriver

  The ``OpenQA.Selenium.Chrome.ChromeDriver`` is the Chrome implementation of the ``IWebDriver`` interface. 

``WebDriver`` and ``RemoteWebDriver`` are the class's through which the user (you) controls the browser. 
``ChromeDriver`` is a derived from the ``RemoteWebDriver``, ``ChromeDriver`` has all the functionality of its parent class ``RemoteWebDriver`` and some Chrome specific implementation as well.

The ``using`` directive allows the use of types in a namespace so that you do not have to qualify the use of a type in that namespace.
In Exercise-1 the first line of code in the ``Main()`` looked like this:  ``var cDriver = new OpenQA.Selenium.Chrome.ChromeDriver();`` 
but in this exercise the code wil look like this: ``var cDriver = new ChromeDriver();`` But first we will need to add a ``using`` directive on line one of the program. 

+ Create a new project the same way you did in :doc:`exercise-1` this time name it **Exercise-2**
+ Add the following lines of code (lines:1,9) to the the file named: "Program.cs" 

.. code-block:: csharp
  :linenos:
  :emphasize-lines: 1,9

  using OpenQA.Selenium.Chrome;

  namespace ConsoleApp1
  {
      class Program
      {
          static void Main(string[] args)
          {
            var cDriver = new ChromeDriver();
          }
      }
  }
