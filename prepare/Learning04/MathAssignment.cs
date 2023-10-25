namespace Learning04;

public class MathAssignment : Assignment
{
   private string _textbooksection;
   private string _problems;

   public MathAssignment(string studentName, string topic, string textBookSection, string problem) : base(studentName, topic)
   {
        _textbooksection = textBookSection;
        _problems = problem;
   }

   public string GetHomeworkList()
   {
    return $"Section: {_textbooksection} Problem: {_problems}";
   }
}
