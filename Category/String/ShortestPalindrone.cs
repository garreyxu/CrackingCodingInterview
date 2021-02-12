class ShortestPalindroneSolution
{
    public ShortestPalindroneSolution()
    {

    }
    public static string ShortestPalindrome(string s) 
    {
        string output = string.Empty;

        int Len = s.Length;
        string rev = string.Empty;
        char[] charArray = s.ToCharArray();
        System.Array.Reverse(charArray);
        rev = new string(charArray);

        for(int i = 0; i < Len; i++)
        {
            if(s.Substring(0, Len - i) == rev.Substring(i))
            {
                output = string.Format("{0}{1}", rev.Substring(0, i), s);
                break;
            }
        }
        return output;
    }

    public static string ShortestPalindrome1(string s)
    {
        string output = string.Empty; 

        

        return output;
    }
}