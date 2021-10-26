public class Solution {
    public string DayOfTheWeek(int day, int month, int year) {
        
        string[] days = new string[]{"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};
        DateTime dt = new DateTime(year,month,day);
        return days[(int) dt.DayOfWeek];
    }
}
