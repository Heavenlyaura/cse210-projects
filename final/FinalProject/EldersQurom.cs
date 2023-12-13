namespace FinalProject;

public class EldersQurom : MemberInfo
{
    private MemberList _memberRecord = new();
    private int _memberrecordnumber;


    public override void SearchMemberInfo()
    {
        List<string> memberInformation = _memberdirectory[_memberrecordnumber];

        if (memberInformation[4] == "m")
        {
            /* unpacking items from the memberInformation list*/
            string firstName = memberInformation[0];
            string lastName = memberInformation[1];
            int age = int.Parse(memberInformation[2]);
            int dateJoined = int.Parse(memberInformation[3]);
            string gender = memberInformation[4];
            string calling = memberInformation[5];
            int? key = null;
            foreach (var kvp in _memberdirectory) // get the key to display membership record member
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
        else
        {
            Console.WriteLine("You do not have permission to view this record!");
        }
    }

    public void SearchMemberinfoByName(string search)
    {
        List<int> foundkeys = new();
        foreach (var kvp in _memberdirectory)
        {
            if (kvp.Value.Count > 0 && kvp.Value[0] == search)
            {
                foundkeys.Add(kvp.Key);
            }
        }
        foreach (var item in foundkeys)
        {
            List<string> memberInformation = _memberdirectory[item];

            if (memberInformation[4] == "m") // checks if the record searched for is male
            {
                SetMemberRecordNumber(item);
                Console.WriteLine();
                SearchMemberInfo();
            }
            else
            {
                Console.WriteLine("Yod do not have permission to view this record!");
                break;
            }
        }
    }

    public override bool IsMember(int mrn)
    {
        List<string> list = _memberdirectory[mrn];
        string calling = list[5];
        if (calling == "elders quorom")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override void EditInfo(int mrn)
    {

    }
    public override void ViewInfo()
    {
        SearchMemberInfo();
    }

    public void SetMemberRecordNumber(int recordNumber)
    {
        _memberrecordnumber = recordNumber;
    }

    public void WardDirectory() // this is to view the entire ward directory
    {
        foreach (var pair in _memberdirectory)
        {
            int keys = pair.Key;
            List<string> list = _memberdirectory[keys];
            if (list[4] == "m")
            {
                Console.WriteLine($"MRN: {pair.Key} Name: {pair.Value[0].ToUpperInvariant()} {pair.Value[1]}");
            }
        }
    }
}
