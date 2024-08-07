public class Solution {
    public string NumberToWords(int num) {
       string[] numbers = new string[]{"One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"};
        string[] tens = new string[]{"Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"};
        string[] other = new string[]{"Thousand", "Million", "Billion"};
        
        if (num == 0) {
            return "Zero";
        }
        
        return Helper(num, numbers, tens).Trim();
    }

    private string Helper(int num, string[] numbers, string[] tens) {
        if (num < 20) {
            return numbers[num - 1] + " ";
        } else if (num < 100) {
            return tens[num / 10 - 2] + (num % 10 > 0 ? " " + Helper(num % 10, numbers, tens) : " ");
        } else if (num < 1000) {
            return numbers[num / 100 - 1] + " Hundred " + (num % 100 > 0 ? Helper(num % 100, numbers, tens) : "");
        } else if (num < 1000000) {
            return Helper(num / 1000, numbers, tens) + "Thousand " + (num % 1000 > 0 ? Helper(num % 1000, numbers, tens) : "");
        } else if (num < 1000000000) {
            return Helper(num / 1000000, numbers, tens) + "Million " + (num % 1000000 > 0 ? Helper(num % 1000000, numbers, tens) : " ");
        } else {
            return Helper(num / 1000000000, numbers, tens) + "Billion " + (num % 1000000000 > 0 ? Helper(num % 1000000000, numbers, tens) : " ");
        } 
    }
}