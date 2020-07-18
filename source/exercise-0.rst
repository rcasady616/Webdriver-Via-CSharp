.. exercise-0:

=====================================================
Exercise 0 - Setting up the environment
=====================================================

.. admonition:: Goals

    Setting up the development environment in Windows
        + Install the software and tools used in these exercises 
        + Configure your your browsers for running automation



Install software and tools form script
--------------------------------------
Installing a package manager **Chocolatey** and **Boxstarter** then installing a free IDE **Visual Studio 2017 Community Edition**
    #. From the start menu, open a **Powershell** window as Admin
    #. Check the version of ``$PSVersionTable.PSVersion`` it should be version 3+
    #. Run the following command ``iwr https://chocolatey.org/install.ps1 -UseBasicParsing | iex`` to install **Chocolatey**
    #. Run the following command ``choco install visualstudio2017community -y --allow-empty-checksums`` to install **Visual Studio 2017**
    #. From the start menu, open **Visual Studio 2017 Community Edition** and confirm its installed 
    #. Install Boxstarter

Install software and tools manually
-----------------------------------
Installing free IDE **Visual Studio 2017 Community Edition**
    #. Download **Visual Studio 2017 Community Edition** from the following url: https://visualstudio.microsoft.com/vs/older-downloads/
    #. You may need to create an account if you don't already have open
    #. need to finish

Configure IE
------------------
Configure IE 
    #. From the start menu, open a **Powershell** window as Admin

.. admonition:: Summary

    - You should have a working IDE installed capable of building and debugging C# applications