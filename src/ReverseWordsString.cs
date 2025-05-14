/* Given a string, you need to reverse the order of characters in each word within a sentence while still preserving whitespace and initial word order.

Example 1:
Input: "Let's take LeetCode contest"
Output: "s'teL ekat edoCteeL tsetnoc"
Note: In the string, each word is separated by single space and there will not be any extra space in the string.
*/

public class Solution {
    public string ReverseWords(string s) {
        
        string[] words = s.Split(" ");
        string reversedS = "";    
        for(int i = 0; i < words.Length; i++){
            string reversed = "";
            for(int j = words[i].Length-1; j >= 0; j--){
                reversed += words[i][j];
            }
            reversedS += reversed;
            reversedS += " ";
        }
        return reversedS.Substring(0,reversedS.Length - 1);
    }
}
