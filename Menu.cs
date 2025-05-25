using System;
using System.Collections.Generic;
public class Menu
{

    static void showMenu()
    {
        string[] mainMenu = { "--- Information ---", "--- updating ---", "--- action ---" };
        foreach(string option in mainMenu)
        {
            Console.WriteLine(option);
        }
    }

    public void showInnerMenu(int choose)
    {
        Dictionary<int, string[]> InnerMenu = new Dictionary<int, string[]>
        {
            {1, new string[] {"..Information about all terrorists..",
                              "..Information about the most senior terrorist..",
                              "..The most dangerous terrorist.." }},
            {2, new string[] { "..Elimination of a terrorist by name..", "..Automatic elimination.."} },
        };

        foreach(string innerChoos in InnerMenu[choose])
        {
            Console.WriteLine(innerChoos);
        }
    }

    public int userInput(int firstNum, int lastNum)
    {
        string choose;
        int finalChoos = 0;
        do
        {
            Console.WriteLine($"please enter a number of the menu, to exit press 'exit'.");
            choose = Console.ReadLine();
            if(int.TryParse(choose, out int resoult))
            {
                finalChoos = Convert.ToInt32(choose);
            }else if(choose == "exit")
            {
                break;
            }
        } while (finalChoos <= firstNum || finalChoos > lastNum);
        return finalChoos;
    }

    public void displayMenu()
    {
        int firstChoos;
        int innerMenu;
        do
        {
            showMenu();
            firstChoos = userInput(0, 2);
            showInnerMenu(firstChoos);
            if(firstChoos == 1)
            {
                innerMenu = userInput(0, 3);
            }
            else{
                innerMenu = userInput(0,2);
            }

        } while (firstChoos != 0);

    }

    public void activateSelection(int innerMenu)
    {
        switch (innerMenu)
        {
            case 1:

                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;
        }
    }

}