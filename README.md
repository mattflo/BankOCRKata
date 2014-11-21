BankOCRKata
===========
###Dependencies
1. Visual Studio 2012
2. .NET 4.5

###Getting Started
1. Open BankOCR.sln in Visual Studio
2. Compile the solution
3. Open a command line to the output folder: `BankOCR.cli\bin\debug`
4. Run the program with the included test file or any other, e.g. ` .\BankOCR.cli.exe .\testFile1.ocr`

###Decisions
* I decided not to cover the Account.ToString() with tests since it was responsible for renderring the final command line output. This output was easily verified manually and is likely subject to the most change.
* Since this is a simple tool, I didn't go to ~~great~~ any lengths to separate tests from implementation. Obviously, with code that needs to run in a production environment, tests would be in an entirely separate project.
* I chose to write more coarse grained [specs](https://github.com/mattflo/BankOCRKata/blob/master/BankOCR/BankOCRSpec.cs) that actually read a sample [testfile](https://github.com/mattflo/BankOCRKata/blob/master/BankOCR/testFile1.ocr) from disk. For a larger test suite I would probably want to use more fine grained tests to cover more behavior.
* I tried to avoid mutable structures to stay as much as possible within a functional approach even though I was in C#.

###Key Files
* [BankOCRSpec](https://github.com/mattflo/BankOCRKata/blob/master/BankOCR/BankOCRSpec.cs)
* [Account](https://github.com/mattflo/BankOCRKata/blob/master/BankOCR/Account.cs)
* [BankOCR](https://github.com/mattflo/BankOCRKata/blob/master/BankOCR/BankOCR.cs)
* [Program.cs](https://github.com/mattflo/BankOCRKata/blob/master/BankOCR.cli/Program.cs)
* [testFile1.ocr](https://github.com/mattflo/BankOCRKata/blob/master/BankOCR/testFile1.ocr)
