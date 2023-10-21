namespace Develop03;

public class Reference
{
    private string _reference = "Moroni 10:3-4";
    private string _verse = " Behold, I would exhort you that when ye shall read these things, if it be wisdom in God that ye should read them, that ye would remember how merciful the Lord hath been unto the children of men, from the creation of Adam even down until the time that ye shall receive these things, and ponder it in your hearts.";
    private string _endVerse = "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost.";

    public string GetReference()
    {
        return _reference;
    }

    public string GetVerse()
    {
        return _verse;
    }

    public string GetEndVerse()
    {
        return _endVerse;
    }
}
