BankOCRKata
===========
###Dependencies
1. Visual Studio 2012
2. .NET 4.5
3. NUnit (committed with the project)
4. Fluent Assertions (committed with the project)

###Getting Started
1. Open BankOCR.sln in Visual Studio
2. Compile the solution
3. Open a command line to the output folder: `BankOCR.cli\bin\debug`
4. Run the program with the included test file or any other, e.g. ` .\BankOCR.cli.exe .\testFile1.ocr`

###Decisions
* Since this is a simple tool, I didn't go to ~~great~~ any lengths to separate tests from implementation. Obviously, with code that needs to run in a production environment, tests would be in an entirely separate project.
* I chose to write more coarse grained [specs](https://github.com/mattflo/BankOCRKata/blob/master/BankOCR/Specs) that actually read sample testfiles e.g. [testFile1.ocr](https://github.com/mattflo/BankOCRKata/blob/master/BankOCR/testFile1.ocr) from disk. For a larger test suite I would probably want to use more fine grained tests to cover behavior.
* I tried to avoid mutable structures to stay as much as possible within a functional approach even though I was in C#.

###Key Files
* [BankOCRSpec.cs](https://github.com/mattflo/BankOCRKata/blob/master/BankOCR/Specs/BankOCRSpec.cs)
* [Account.cs](https://github.com/mattflo/BankOCRKata/blob/master/BankOCR/Account.cs)
* [BankOCR.cs](https://github.com/mattflo/BankOCRKata/blob/master/BankOCR/BankOCR.cs)
* [Program.cs](https://github.com/mattflo/BankOCRKata/blob/master/BankOCR.cli/Program.cs)
* [testFile1.ocr](https://github.com/mattflo/BankOCRKata/blob/master/BankOCR/testFile1.ocr)
* [UserStory1Spec](https://github.com/mattflo/BankOCRKata/blob/master/BankOCR/Specs/UserStory1Spec.cs)
* [UserStory1.ocr](https://github.com/mattflo/BankOCRKata/blob/master/BankOCR/Specs/UserStory1.ocr)
* [UserStory2Spec](https://github.com/mattflo/BankOCRKata/blob/master/BankOCR/Specs/UserStory2Spec.cs)
* [UserStory2.ocr](https://github.com/mattflo/BankOCRKata/blob/master/BankOCR/Specs/UserStory2.ocr)
* [UserStory3Spec](https://github.com/mattflo/BankOCRKata/blob/master/BankOCR/Specs/UserStory3Spec.cs)
* [UserStory3.ocr](https://github.com/mattflo/BankOCRKata/blob/master/BankOCR/Specs/UserStory3.ocr)
