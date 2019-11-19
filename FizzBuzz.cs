/*
Write a program that outputs the string representation of numbers from 1 to n.

But for multiples of three it should output “Fizz” instead of the number and for the multiples of five output “Buzz”. For numbers which are multiples of both three and five output “FizzBuzz”.
*/

public class Solution {
    public IList<string> FizzBuzz(int n) {
        
        IList<string> result = new List<string>();
        for(int i = 1; i <= n; i++){
            string s = "";
            if (i % 3 == 0){
                s += "Fizz";
            } if (i % 5 == 0){
                s += "Buzz";
            } 
            if (s != ""){
                result.Add(s);
            }
            else {
                result.Add(i + "");
            }
        }
        return result;
    }
}
