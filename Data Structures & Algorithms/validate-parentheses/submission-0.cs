public class Solution {
    public bool IsValid(string s) {
        Dictionary<string, string> closeToOpen = new Dictionary<string, string>
        {
            { ")", "(" },
            { "}", "{" },
            { "]", "[" }
        };
        Stack<string> stack = new Stack<string>();

        for(int i=0;i<s.Length;i++)
        {
            string currentChar = s[i].ToString();
            if(closeToOpen.ContainsKey(currentChar))
            {
                if(stack.Count==0 || stack.Peek() != closeToOpen[currentChar])
                {
                    return false;
                }
                else
                {
                    stack.Pop();
                }
            }
            else
            {
                stack.Push(currentChar);  
            }
        }

        return stack.Count == 0; 
    }
}
