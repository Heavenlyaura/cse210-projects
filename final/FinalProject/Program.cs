using System;
using System.Dynamic;
using FinalProject;

class Program
{
    static void Main(string[] args)
    {
        MemberInfo memberInfo = new();
        Console.WriteLine("Welcome to Kubwa Ward 1");
        Console.WriteLine("Choose Option: ");
        Console.WriteLine("1. Bishop: ");
        Console.WriteLine("2. Relief Society: ");
        Console.WriteLine("3. Elders Quourm: ");
        Console.WriteLine("4. Member: ");
        Console.Write("> ");
        int option = int.Parse(Console.ReadLine());

        if (option == 1)
        {
            Bishop bishop = new();
            Console.Write("Enter MRN: ");
            int bMrn = int.Parse(Console.ReadLine());
            memberInfo.SetRecordNumber(bMrn);
            if (bishop.IsBishop(bMrn)) // checks if the record number entered matches that of the bishop
            {
                Console.WriteLine("Welcome Bishop");
                Console.WriteLine("1. View Personal Information");
                Console.WriteLine("2. Search Member");
                Console.WriteLine("3. View Ward Directory");
                Console.WriteLine("4. Create Member Record");
                Console.Write("Enter Option: ");
                int bo = int.Parse(Console.ReadLine());

                if (bo == 1)
                {
                    bishop.SetMemberRecordNumber(bMrn);
                    bishop.ViewInfo();
                }
                else if (bo == 2)
                {
                    Console.WriteLine("1. Search MRN: ");
                    Console.WriteLine("2. Search Name: ");
                    Console.Write("> ");
                    int so = int.Parse(Console.ReadLine());

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