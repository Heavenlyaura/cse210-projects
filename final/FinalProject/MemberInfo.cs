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
