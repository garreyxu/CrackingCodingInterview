public class StrStrSulution
{
    public static int StrStr(string haystack, string needle)
    {
        int output = -1;

        if(string.IsNullOrEmpty(needle))
        {
            return 0;
        }

        if(string.IsNullOrEmpty(haystack)){
            return output;
        }
        
        int j;
        int haystackLen = haystack.Length;
        int needleLen = needle.Length;

        for(int i = 0; i < haystackLen - needleLen + 1 ; i++)
        {
            for(j = 0; j < needleLen; j++)
            {
                if(haystack[i + j] != needle[j])
                {
                    break;
                }
            }
            if(j == needleLen)
            {
                output = i;
                break;
            }
        }
        return output;
    }   
}