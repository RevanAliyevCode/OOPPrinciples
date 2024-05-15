// See https://aka.ms/new-console-template for more information

using Documents;

UserInput: Console.WriteLine("Which type you want buy (basic, pro, expert)");

string package = Console.ReadLine();
dynamic program;

switch (package)
{
    case "basic":
        program = new DocumentProgram();
        break;
    case "pro":
        program = new ProDocumentProgram();
        break;
    case "expert":
        program = new ExpertDocumentProgram();
        break;
    default:
        goto UserInput;
}

program.OpenDocument();
program.EditDocument();
program.SaveDocument("pdf");