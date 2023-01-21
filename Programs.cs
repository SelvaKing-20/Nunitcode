using System.Linq.Expressions;

namespace exercise_NUnit_test_programs
{
    public class Programs
    {
        public static double CalculateDiscount(double amount)
        {
            double DiscountPrice = 0.0;
            if (amount == 0 || amount < 0)
            {
                throw new Exception("Sale amount cannot be -ve or 0'");
            }
            else if (amount >= 1000 && amount < 2000)
            {
                DiscountPrice = amount - (amount * 0.05);
            }
            else if (amount >= 2000 && amount < 5000)
            {
                DiscountPrice = amount - (amount * 0.1);
            }
            else if (amount >= 5000 && amount < 20000)
            {
                DiscountPrice = amount - (amount * 0.5);
            }
            else
            {
                DiscountPrice = amount;
            }
            return DiscountPrice;
            // implement the logic for calculating the discounted price based on the conditions
            /*
             * if amount = 0 or < 0 then ArgumentException must be thrown with error message 'Sale amount cannot be -ve or 0'
             * if amount >= 1000 and amount < 2000 then 5% discount
             * if amount >= 2000 and  amount < 5000 then 10% discount
             * if amount >= 5000 and amount < 20000 then 50% discount
             * else No Discount
             */
            return DiscountPrice;
        }
        public static int countwords(string str)
        {
            int count = 0;
            int myword = 1;
            if (str == null)
            {
                myword = 0;
            }
            else
            {
                while (count <= str.Length - 1)
                {
                    if (str[count] == ' ' || str[count] == '\t')
                    {
                        myword++;
                    }
                    count++;
                }
            }
            //implement the logic for  counting the total words in given string.
            // if string is null then the count must return 0
            return myword;
        }
        public static string ReverseString(string str)
        {
            string reverseString = string.Empty;
            if (str == null)
            {
                reverseString = null;
            }
            else
            {
                for (int i = str.Length - 1; i >= 0; i--)
                {
                    reverseString += str[i];
                }
            }
            //implement the logic for  reversing the given string.
            // if string is null then the reverse string must be null
            return reverseString;
        }






}   }    