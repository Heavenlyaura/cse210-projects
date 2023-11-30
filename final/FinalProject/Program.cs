using System;
using System.Dynamic;
using FinalProject;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new();
        MemberInfo memberInfo = new();
        menu.DisplayMenu();
        int option = int.Parse(Console.ReadLine());

        if (option == 1)
        {
            Bishop bishop = new();
            Console.Write("Enter MRN: ");
            int bMrn = int.Parse(Console.ReadLine());
            menu.ClearConsole();
            memberInfo.SetRecordNumber(bMrn);
            if (bishop.IsBishop(bMrn)) // checks if the record number entered matches that of the bishop
            {
                menu.BishopMenu();
                int bo = int.Parse(Console.ReadLine());

                if (bo == 1)
                {
                    bishop.SetMemberRecordNumber(bMrn);
                    bishop.ViewInfo();
                }
                else if (bo == 2)
                {   
                    menu.BishopSearchOptions();
                    int so = int.Parse(Console.ReadLine());
                    menu.ClearConsole();

                    if (so == 1)
                    {
                        Console.Write("Enter Member MRN: ");
                        int mrn = int.Parse(Console.ReadLine());
                        bishop.SetMemberRecordNumber(mrn);
                        bishop.SearchMemberInfo();
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
            }
            else
            {
                Console.WriteLine("Sorry wrong Credentials, check and try again!"); // prompts the user to try again if there is a mismatch
            }
        }
    }
}