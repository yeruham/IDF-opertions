using System;
using System.Collections.Generic;
public class Menu
{
    IDFcommand command;
    public Menu(IDFcommand command)
    {
        this.command = command;
    }

    static void showMainMenu()
    {
        string[] mainMenu = { "--- Information ---", "--- action ---" };
        foreach(string option in mainMenu)
        {
            Console.WriteLine(option);
        }
    }

    public void showInnerMenu(int choose)
    {
        Dictionary<int, string[]> InnerMenu = new Dictionary<int, string[]>
        {
            {1, new string[] {"1..Information about all terrorists..",
                              "2..Information about the most senior terrorist..",
                              "3..The most dangerous terrorist.." }},
            {2, new string[] { "1..Elimination of a terrorist by name..", "2..Automatic elimination.."} },
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
            Console.WriteLine(lastNum == 2 ?"please enter a number of the menu, to exit press 'exit'.": "Select the desired action.");
            choose = Console.ReadLine();
            if(int.TryParse(choose, out int resoult))
            {
                finalChoos = Convert.ToInt32(choose);
            }else if(choose == "exit")
            {
                finalChoos = 0;
                break;
            }
        } while (finalChoos <= firstNum || finalChoos > lastNum);
        return finalChoos;
    }

    public void displayMenu()
    {
        int firstChoos;
        int innerMenu;
        string terroristName  = "";
        do
        {
            showMainMenu();
            firstChoos = userInput(0, 2);
            if(firstChoos == 0)
            {
                break;
            }
            showInnerMenu(firstChoos);
            if(firstChoos == 1)
            {
                innerMenu = userInput(0, 3);
            }
            else{
                innerMenu = userInput(0,2);
                innerMenu += 10;
            }
            if(innerMenu == 11)
            {
                Console.WriteLine("Pleas enter the name of the terrorist.");
                terroristName = Console.ReadLine();
            }
            activateSelection(innerMenu, terroristName);

        } while (firstChoos != 0);

    }

    public void activateSelection(int innerMenu, string terorist)
    {
        switch (innerMenu)
        {
            case 1:
                command.getDataOfTerorist();
                break;
            case 2:
                command.mostSenior();
                break;
            case 3:
                command.mostDangerous();
                break;
            case 11:
                command.killTerrorist(terorist);
                break;
            case 12:
                command.action();
                break;
        }
    }

}