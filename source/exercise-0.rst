.. exercise-0:

=====================================================
Exercise 0 - Setting up the environment
=====================================================
Setting up the development environment by installing a package manager **Chocolatey** and then installing a free IDE **Visual Studio 2017 Community Edition**

Install Developer tools
--------------------------------
#. From the start menu, open a **Powershell** window as Admin
#. Check the version of ``$PSVersionTable.PSVersion`` it should be version 3+
#. Run the following command ``iwr https://chocolatey.org/install.ps1 -UseBasicParsing | iex`` to install **Chocolatey**
#. Run the following command ``choco install visualstudio2017community -y --allow-empty-checksums`` to install **Visual Studio 2017**
#. From the start menu, open **Visual Studio 2017 Community Edition** and confirm its installed 
#. Install Boxstarter
#. Configure IE