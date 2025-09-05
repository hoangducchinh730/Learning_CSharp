using System.Collections.Generic;
using System.ComponentModel;

Console.WriteLine("Hello!\n");

List<string> list = new List<string>();

do
{
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");

    string? userChoice = Console.ReadLine();

    userChoice = userChoice?.ToUpper();

    switch (userChoice)
    {
        case "S":
            if(list.Count == 0)
                ShowMessage("No TODOs have been added yet.");
            else 
                ShowAllTodo();
            break;
        case "A":
            while (true)
            {
                Console.WriteLine("Enter the TODO description: ");
                string? todo = Console.ReadLine();
                if (string.IsNullOrEmpty(todo))
                    Console.WriteLine("The description cannot be empty.");
                else if (list.Contains(todo.ToUpper()) == true)
                    Console.WriteLine("The description must be unique.");
                else
                {
                    list.Add(todo.ToUpper());
                    ShowMessage($"TODO successfully added: {todo.ToUpper()}");
                    break;
                }
            }
            break;
        case "R":
            while (true)
            {
                if (list.Count == 0)
                {
                    ShowMessage("No TODOs have been added yet.");
                    break;
                }
                ShowMessage("Select the index of the TODO you want to remove:");
                ShowAllTodo();
                string? input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                    Console.WriteLine("Selected index cannot be empty.");
                else
                {
                    var index = int.Parse(input);
                    if (index < 1 || index > list.Count)
                        Console.WriteLine("The given index is not valid.");
                    else
                    {
                        string removedTodo = list[index - 1];
                        list.RemoveAt(index - 1);
                        ShowMessage($"TODO removed: {removedTodo}");
                        break;
                    }
                }
            }
            break;
        case "E":
            return;
        default:
            ShowMessage("Incorrect input");
            break;
    }
    Console.WriteLine();
} while (true);


void ShowMessage(string message)
{
    Console.WriteLine(message);
}

void ShowAllTodo()
{
    for (int i = 0; i < list.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {list[i].ToUpper()}");
    }
}