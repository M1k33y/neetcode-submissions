public class Solution {
    public bool IsValid(string s) 
    {
        Stack<char> stack=new Stack<char>();

        for(int i=0;i<s.Length;i++)
        {
            if(s[i]=='['||s[i]=='('||s[i]=='{')
                stack.Push(s[i]);

            else if(s[i]==')'){
                if( stack.Count==0||stack.Peek()!='(')
                    return false;
                stack.Pop();
            }

            else if(s[i]==']'){
                if(stack.Count==0||stack.Peek()!='[')
                    return false;
                stack.Pop();
            }
            else if(s[i]=='}')
            {
                if( stack.Count==0||stack.Peek()!='{')
                    return false;
                stack.Pop();
            }

        }

        if(stack.Count==0)
            return true;

        return false;

    }
}
