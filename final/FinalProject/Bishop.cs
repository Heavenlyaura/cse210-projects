namespace FinalProject;

public class Bishop : MemberInfo
{
    protected int _memberrecordnumber;
    private Dictionary<int, List<string>> _memberRecords;
    // private static int recordNumber;

    public Bishop()
    {
        _memberRecords = MemberRecords(); // creates an instance of the MemberRecord Class
    }
    public override void ViewInfo()
    {
        SearchMemberInfo(); // calls the seach members information method to find the information of the bishop. (this is done to avoid redundancy)
    }
    public override void SearchMemberInfo()
    {
        // int recordNumber = GetRecordNumber(); // gets the current users record number
        List<string> memberInformation = _memberRecords[_memberrecordnumber]; 

        /* unpacking items from the memberInformation list*/
        string firstName = memberInformation[0];
        string lastName = memberInformation[1];
        int age = int.Parse(memberInformation[2]);
        int dateJoined = int.Parse(memberInformation[3]);
        string gender = memberInformation[4];
        string calling = memberInformation[5];
        int? key = null;
        foreach (var kvp in _memberRecords) // get the key to display membership record member
        {
            if (kvp.Value[0] == firstName)
            {
                key = kvp.Key;
            }
        }

        // displaing information
        Console.WriteLine($"Firstname: {firstName}");
        Console.WriteLine($"Lastname: {lastName}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Gender: {gender.ToUpper()}");
        Console.WriteLine($"DateJoined: {dateJoined}");
        Console.WriteLine($"calling: {calling}");
        Console.WriteLine($"MRN: {key}");
    }
    public  void SearchMemberinfoByName(string search)
    {
        List<int> foundkeys = new();
        foreach (var kvp in _memberRecords)
        {
            if (kvp.Value.Count > 0 && kvp.Value[0] == search)
            {
                foundkeys.Add(kvp.Key);
            }
        }
        foreach (var item in foundkeys)
        {
            SetMemberRecordNumber(item);
            Console.WriteLine();
            SearchMemberInfo();
        } 
    }
    public void SetMemberRecordNumber(int recordNumber)
    {
        _memberrecordnumber = recordNumber; // sets the members record number, this is to be used when the bishop wants to look up members by record number
    }
    public void WardDirectory() // this is to view the entire ward directory
    {
        foreach (var pair in _memberRecords)
        {
            Console.WriteLine($"MRN: {pair.Key} Name: {pair.Value[0].ToUpperInvariant()} {pair.Value[1]}");
        }
    }

    public override bool IsMember(int mrn)
    {
        List<string> isBishopList =  _memberRecords[mrn];
       string calling = isBishopList[5];
       if (calling == "bishop")
       {
        return true;
       }
       else
       {
        return false;
       }
    }

    public void CreateMemberrecord()
    {
        Console.Write("Enter Firstname: ");
        string firstName = Console.ReadLine().ToLower();
        
        Console.Write("Enter Lastname: ");
        string lastName = Console.ReadLine().ToLower();

        Console.Write("Enter age: ");
        string age = Console.ReadLine().ToLower();

        Console.Write("Enter JearJoined: ");
        string YearJoined = Console.ReadLine().ToLower();

        Console.Write("Enter gender (m/f): ");
        string gender = Console.ReadLine().ToLower();

        Console.Write("Enter Calling: ");
        string calling = Console.ReadLine().ToLower();
        int recordNumber = GeneraterecordNumber(); // Genrates a new record number
        _memberRecords.Add(recordNumber, new List<string> {firstName, lastName, age, YearJoined, gender, calling}); // adds new member to the dictionary
    }
    public int GeneraterecordNumber()
    {
        int lastKey = _memberRecords.Keys.LastOrDefault();  
        int newRecordNumber = lastKey += 1;

        return newRecordNumber;
    }
}
