.. exercise-2:

=========================================
Exercise 2 - Comments
=========================================

Comments are a very useful for explaining and documenting code. 

.. code-block:: csharp
	class Exercise2
	{
		static void Main(string[] args)
		{
			// Simple inline comment you can place anything here and its ignored by the compiler 
			
			Console.WriteLine("Code and comment on same line"); // This is the comment
			
			/* line one
			Multi line comment
			*/ line three
			
			// You can also use a comment to disable a piece of code 
			//Console.WriteLine("This wont run");
		}
	}