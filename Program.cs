
namespace Coding
{
  public class Program
  {
    public static void Main()
    {
      string orig = "this is a sentence. do you like it? what a great day! let's go";
      Console.WriteLine($"The original sentence [{orig}]");
      string final = FixSentence(orig);
      
      Console.WriteLine($"The final sentence [{final}]");
    }

    public static String FixSentence(String original) 
    {
        char[] chars = original.ToCharArray();
        bool beginOfSentence = true;
        for (int i = 0; i < chars.Length; i++)
        {
            if (beginOfSentence && Char.IsLetter(chars[i]) )
            {
                chars[i] = Char.ToUpper( chars[i] );
                beginOfSentence = false;
            } 
            else if (chars[i] == '!' || chars[i] == '.' || chars[i] == '?')
            {                
                beginOfSentence = true;
            }
        }

        return new string(chars);
    }
  }
}