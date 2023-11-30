 namespace FinalProject;

public class MemberList
{
      public Dictionary<int, List<string>> MemberDirectory()
    {
        Dictionary<int, List<string>> memberList = new()
        {
            { 001, new List<string> { "alice", "okafor", "22", "2003", "f", "r"} },
            { 002, new List<string> { "james", "sam", "26", "2018", "m", "r" } },
            { 003, new List<string> { "allen", "david", "42", "2008", "m", "r" } },
            { 004, new List<string> { "david", "gabriel", "62", "2002", "m", "r" } },
            { 005, new List<string> { "samuel", "ben", "33", "2002", "m", "r" } },
            { 006, new List<string> { "gabriella", "james", "18", "2001", "f", "r" } },
            { 007, new List<string> { "promise", "prosper", "32", "2014", "f", "r" } },
            { 008, new List<string> { "ebenezer", "rey", "26", "2016", "m", "r" } },
            { 009, new List<string> { "emmanuel", "gordon", "22", "2020", "m", "bishop" } },
            { 0010, new List<string> { "micheal", "mahaman", "21", "2016", "m", "" } },
            { 0011, new List<string> { "wisdom", "nathan", "20", "2007", "m", "r" } },
            { 0012, new List<string> { "veronica", "okafor", "29", "2007", "f", "r" } },
            { 0013, new List<string> { "favour", "jerry", "38", "2008", "f", "r" } },
            { 0014, new List<string> { "racheal", "okafor", "18", "2009", "f", "r" } },
            { 0015, new List<string> { "jennifer", "okafor", "17", "2005", "f", "r" } },
            { 0016, new List<string> { "heaven", "okafor", "28", "2010", "f", "rs" } },
            { 0017, new List<string> { "chinedu", "penny", "40", "2011", "m", "eq" } },
            { 0018, new List<string> { "soludo", "gabriel", "23", "2013", "m", "r" } },
            { 0019, new List<string> { "prosper", "simon", "21", "2012", "m", "r" } },
            { 0020, new List<string> { "florence", "solomon", "33", "2022", "f", "r" } },
            { 0021, new List<string> { "florence", "peter", "23", "2012", "f", "r" } }
        };

        return memberList;
    }
}