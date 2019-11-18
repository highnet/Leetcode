/*
Write a function that takes an unsigned integer and return the number of '1' bits it has (also known as the Hamming weight).
*/

public class Solution {
    public int HammingWeight(uint n) {
        
        string binary = Convert.ToString(n, 2);
        Console.WriteLine(binary);
        int count = 0;
        for(int i = 0; i < binary.Length; i++){
            if (binary[i] == '1'){
                count++;
            }
        }
        return count;
    }
}
