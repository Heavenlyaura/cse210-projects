namespace FinalProject;

public class Member : MemberInfo
{
    // protected int _recordNumber;
    // public Member()
    // {

    // }

    public override void ViewInfo()
    {
        Dictionary<int, List<string>> memberRecords = MemberRecords();
        int recordNumber = GetRecordNumber();
        List<string> memberInformation = memberRecords[recordNumber];
        string firstName = memberInformation[0];
        string lastName = memberInformation[1];
        int age = int.Parse(memberInformation[2]);
        int dateJoined = int.Parse(memberInformation[3]);
        string gender = memberInformation[4];
        string calling = memberInformation[5];

        if (calling == "r")
        {
            calling = "member";
            Console.WriteLine($"Firstname: {firstName}");
            Console.WriteLine($"Lastname: {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"DateJoined: {dateJoined}");
            Console.WriteLine($"calling: {calling}");
        }
    }
}
