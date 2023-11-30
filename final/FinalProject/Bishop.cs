﻿namespace FinalProject;

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

        // displaing information
        Console.WriteLine($"Firstname: {firstName}");
        Console.WriteLine($"Lastname: {lastName}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Gender: {gender.ToUpper()}");
        Console.WriteLine($"DateJoined: {dateJoined}");
        Console.WriteLine($"calling: {calling}");
    }
    public void SearchMemberinfoByName(string search)
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
    public bool IsBishop(int mrn) // authenticates bishops identity
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
}