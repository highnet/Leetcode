/*
Write an algorithm to determine if a number is "happy".
A happy number is a number defined by the following process: Starting with any positive integer,
replace the number by the sum of the squares of its digits, 
and repeat the process until the number equals 1 (where it will stay), 
or it loops endlessly in a cycle which does not include 1.
Those numbers for which this process ends in 1 are happy numbers.
/*

public class Solution {
    public bool IsHappy(int n) {
 
        List<int> cycle = new List<int>();
        
        while(true){
            
        int nCopy = n;
        int sum = 0;
        int prevSum = 0;
        while (nCopy > 0){
            sum += (int) Math.Pow(nCopy%10,2);
            nCopy /= 10;
        }
        Console.WriteLine(sum);
        if (sum == 1){
            return true;
        }
            
        if (cycle.Contains(sum)){
            return false;
        }
            
        cycle.Add(sum);
        
    
        n = sum;
    

        }
        
        return false;
    }
}
