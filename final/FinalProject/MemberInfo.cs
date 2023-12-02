using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace FinalProject;

public class MemberInfo
{
    private int _recordmember;
    private string _firstname;
    private string _lastname;
    private int _age;
    private int _joined;
    private string _gender;
    private int _recordnumber;
    private Menu _menu = new();

    // public MemberInfo(int recordNumber)
    // {
    //     _recordnumber = recordNumber;
    // }

// Getters and Setters Section
    public string GetFirstName()
    {
        return _firstname;
    }
    public string GetLastName()
    {
        return _lastname;
    }
    public int GetAge()
    {
        return _age;
    }
    public int GetDateJoined()
    {
        return _joined;
    }
    public string GetGender()
    {
        return _gender;
    }
    public int GetRecordNumber()
    {
        return _recordnumber;
    }
    public void SetFirstName(string firstName)
    {
        _firstname = firstName;
    }
    public void SetLastName(string lastName)
    {
        _lastname = lastName;
    }
    public void SetAge(int age)
    {
        _age = age;
    }
    public void SetDateJoined(int joined)
    {
        _joined = joined;
    }
    public void SetGender(string gender)
    {
        _gender = gender;
    }
    public void SetRecordNumber(int recordNumber)
    {
        if (MemberRecords().ContainsKey(recordNumber))
        {
            _recordnumber = recordNumber;
        }
        else
        {
            Console.WriteLine("RecordNumber does not Exist!!");
        }
    }
    public virtual void ViewInfo()
    {}
    public virtual void SearchMemberInfo()
    {}
    public virtual void EditInfo(int mrn)
    {
        Dictionary<int, List<string>> memberRecords = MemberRecords();
        _menu.Editmenu();
        int editOption = int.Parse(Console.ReadLine());
        // this is to enble modification of the items in the directory
        if (editOption == 1)
        {
            Console.Write("Enter Firstname: ");
            string firstName = Console.ReadLine().ToLower();
            memberRecords[mrn][0] = firstName;
        }

        else if (editOption == 2)
        {
            Console.Write("Enter lastname: ");
            string lastname = Console.ReadLine().ToLower();
            memberRecords[mrn][1] = lastname;
        }
        
        else if (editOption == 3)
        {
            Console.Write("Enter Age: ");
            string age = Console.ReadLine().ToLower();
            memberRecords[mrn][2] = age;
        }
        
        else if (editOption == 4)
        {
            Console.Write("Enter Date Joined: ");
            string dateJoined = Console.ReadLine();
            memberRecords[mrn][3] = dateJoined;
        }
        
        else if (editOption == 5)
        {
            Console.Write("Enter Gender: ");
            string Gender = Console.ReadLine();
            memberRecords[mrn][4] = Gender;
        }
        
        else if (editOption == 6)
        {
            Console.Write("Enter Calling: ");
            string calling = Console.ReadLine();
            memberRecords[mrn][5] = calling;
        }
        

    }
    public Dictionary<int, List<string>> MemberRecords()
    {
        MemberList memberList = new();
        return memberList.MemberDirectory();
    }
    // public void BoundCheck(int start, int end)
    // {
    //     if 
    // }

}
