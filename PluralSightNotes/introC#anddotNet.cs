// .Net framework only works on windows machine.
// .Net Core (Linux, Mac, Windows, ARM)

// break down .Net into two parts
// CLR common language runtime - .Net is a runtime, .Net provides a space for you to run c#, bring program to life, and mange the memory. 
// FCL(framwork class library)

// SDK(software development kit)  includes the .Net Core and all the library that we needs for .Net Core library.

// .Net CLI
// nuget package to implement the features, and dotnet restore is to look through the csproj file to see if i have the external dependencies.
// package functionality
// for node, it is npm
// for python,  it is pip
// nuget packages is a central part of development

// dotnet build, to compile all the source code.
// the C# compiler that is running behind the scenes as a tool
// it can analyze my c# source code and transform or translate that source code into an efficient binary format that is faster to execute when i need to run my application 
// take all of the cs files source code and produce a single output file that is a binary representation of my source code.
// dll - dynamic linked library, but not the same case for dotnet core
// in dotnet core, we call it assembly
// obj is a temporary files during the restore and build process, you can safely delete
// what matters is the srouce code and csproj file

// Main 
// string interpretation 
$"Hello {args[0]}!";