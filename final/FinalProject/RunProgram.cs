namespace FinalProject;

public class RunProgram
{
    public void Run()
    {
        Menu menu = new();
        MemberInfo memberInfo = new();
        menu.DisplayMenu();
        int option = int.Parse(Console.ReadLine());
        Console.Clear();

        if (option == 1)
        {
            Bishop bishop = new();
            Console.WriteLine("Login: ");
            Console.Write("Enter MRN: ");
            int bMrn = int.Parse(Console.ReadLine());
            Console.Clear();
            memberInfo.SetRecordNumber(bMrn);
            if (bishop.IsMember(bMrn)) // checks if the record number entered matches that of the bishop
            {
                while (true) // keeps the menu options in the bishops account till the user chooses to go back to the main menu
                {
                    menu.BishopMenu();
                    int bo = int.Parse(Console.ReadLine());
                    Console.Clear();

                    if (bo == 1)
                    {
                        bishop.SetMemberRecordNumber(bMrn);
                        bishop.ViewInfo();
                        Console.WriteLine();
                    }
                    else if (bo == 2)
                    {
                        menu.SearchOptions();
                        int so = int.Parse(Console.ReadLine());
                        Console.Clear();

                        if (so == 1)
                        {
                            Console.Write("Enter Member MRN: ");
                            int mrn = int.Parse(Console.ReadLine());
                            bishop.SetMemberRecordNumber(mrn);
                            bishop.SearchMemberInfo();
                            Console.WriteLine();
                            Console.WriteLine("Edit Info? ");
                            Console.WriteLine("1. Yes");
                            Console.WriteLine("2. No ");
                            Console.Write("> ");
                            int edit = int.Parse(Console.ReadLine());
                            Console.Clear();
                        }
                        else if (so == 2)
                        {
                            Console.Write("Enter Member Name: ");
                            string mName = Console.ReadLine().ToLower();
                            bishop.SearchMemberinfoByName(mName);
                        }
                    }
                    else if (bo == 3)
                    {
                        bishop.WardDirectory();
                    }
                    else if (bo == 4)
                    {
                        bishop.CreateMemberrecord();
                    }
                    else if (bo == 5)
                    {
                        Console.Clear();
                        Run(); // restarts the program from the top
                    }
                }
            }
            else
            {
                Console.WriteLine("Sorry wrong Credentials, check and try again!"); // prompts the user to try again if there is a mismatch
            }
        }
        else if (option == 2)
        {
            EldersQurom eldersQurom = new();
            Console.WriteLine("Login");
            Console.WriteLine("Enter MRN: ");
            Console.Write("> ");
            int eMrn = int.Parse(Console.ReadLine());

            if (eldersQurom.IsMember(eMrn))
            {
                while (true)
                {
                    menu.EldersQuromMenu();
                    int choose = int.Parse(Console.ReadLine());

                    if (choose == 1)
                    {
                        eldersQurom.SetMemberRecordNumber(eMrn);
                        eldersQurom.ViewInfo();
                        Console.WriteLine();
                    }
                    else if (choose == 2)
                    {
                        menu.SearchOptions();
                        int so = int.Parse(Console.ReadLine());
                        Console.Clear();

                        if (so == 1)
                        {
                            Console.Write("Enter Member MRN: ");
                            int mrn = int.Parse(Console.ReadLine());
                            eldersQurom.SetMemberRecordNumber(mrn);
                            eldersQurom.SearchMemberInfo();
                            Console.WriteLine();
                        }
                        else if (so == 2)
                        {
                            Console.Write("Enter Member Name: ");
                            string mName = Console.ReadLine().ToLower();
                            eldersQurom.SearchMemberinfoByName(mName);
                        }
                    }
                    else if (choose == 3)
                    {
                        eldersQurom.WardDirectory();
                    }
                    else if (choose == 4)
                    {
                        Console.Clear();
                        Run();
                    }
                }
            }
            else
            {
                Console.WriteLine("Wrong credentials, trya again!");
            }



        }
    }
}
