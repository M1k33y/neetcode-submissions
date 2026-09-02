public class Solution {
    public bool IsValidSudoku(char[][] board) 
    {

        HashSet<char>[] rows = new HashSet<char>[9];
        HashSet<char>[] cols = new HashSet<char>[9];
        HashSet<char>[] squares = new HashSet<char>[9];
        
        for(int i=0;i<9;i++)
        {
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            squares[i] = new HashSet<char>();
        }

        for(int i=0;i<9;i++)
        {
            
            for(int j=0;j<9;j++)
            {
                char value = board[i][j];

                if (value == '.')
                    continue;

                int square= (i/3)*3 +j/3;

                if(rows[i].Contains(value)|| cols[j].Contains(value)||squares[square].Contains(value))
                    return false;

                rows[i].Add(value);
                cols[j].Add(value);
                squares[square].Add(value);
            }
        }

        return true;

    }
}
