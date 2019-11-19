/*
Given a date, return the corresponding day of the week for that date.

The input is given as three integers representing the day, month and year respectively.

Return the answer as one of the following values {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"}.
*/
public class Solution {
    public string DayOfTheWeek(int day, int month, int year) {
        
        string[] days = new string[]{"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};
        DateTime dt = new DateTime(year,month,day);
        return days[(int) dt.DayOfWeek];
    }
}
