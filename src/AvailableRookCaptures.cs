public class Solution {
    public int NumRookCaptures(char[][] board) {
        int rookY = 0;
        int rookX = 0;
        int hits = 0;
        
        int[] rookPos = FindRookXY(board);
        rookX = rookPos[0];
        rookY = rookPos[1];
        
        string[] directions = new string[]{"up","down","left","right"};
        
        foreach(string dir in directions){
            hits += RayCast(dir,rookX,rookY,board)? 1:0;
        }
        
        return hits;
    }
    
    public bool RayCast(string direction,int rookX, int rookY, char[][] board){
        
        int scanX = rookX;
        int scanY = rookY;
        bool stopScan = false;
        bool hit = false;
        while (scanX >= 0 && scanX < 8 && scanY >= 0 && scanY < 8 && !stopScan)
        {
            if (board[scanY][scanX] == 'B')
            {
                stopScan = true;
            }
            if (board[scanY][scanX] == 'p')
            {
                hit = true;
                stopScan = true;
            }
            switch(direction){
                case "up":
                    scanY--;
                    break;
                case "down":
                    scanY++;
                    break;
                case "right":
                    scanX++;
                    break;
                case "left":
                    scanX--;
                    break;
            }
        }
        return hit;
    }
    
    public int[] FindRookXY(char[][] board){
        int rookX = 0;
        int rookY = 0;
        for(int y = 0; y < board.Length; y++){
            for(int x = 0; x < board[y].Length; x++){
                if(board[y][x] == 'R'){
                    rookX = x;
                    rookY = y;
                }
            }
        }
        return new int[]{rookX,rookY};
    }
    
}
