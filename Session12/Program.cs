using Day_01_G03;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Session12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Restriction Operators - where

            #region question1

            // 1. Find all products that are out of stock. 

            // Fluent Syntax
            //var result = ListGenerator.ProductsList.Where(p => p.UnitsInStock == 0);


            //Query Syntax
            //var result = from p in ListGenerator.ProductsList
            //             where p.UnitsInStock == 0
            //             select p;


            #endregion

            #region question2

            // 2. Find all products that are in stock and cost more than 3.00 per unit.

            // Fluent Syntax
            //var result2 = ListGenerator.ProductsList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00M);

            // Quesry syntax

            //var result =
            //            from p in ListGenerator.ProductsList
            //            where p.UnitsInStock > 0 && p.UnitPrice > 3.00M
            //            select p;

            #endregion

            #region question3

            // Returns digits whose name is shorter than their value.


            // Fluent syntax
            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result3 = Arr.Where((word, index) => word.Length < index);


            // Query Syntax
            //var result =
            //            from item in Arr.Select((word, index) => new { word, index })
            //            where item.word.Length < item.index
            //            select item.word;

            #endregion

            #endregion

            #region Element Operators

            #region question1

            // 1. Get first Product out of Stock  

            // Fluent syntax
            //var result = ListGenerator.ProductsList.FirstOrDefault(p => p.UnitsInStock == 0);

            // Query syntax
            //var result =
            //            (from p in ListGenerator.ProductsList
            //             where p.UnitsInStock == 0
            //             select p).First();
            #endregion

            #region question2
            // 2.Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            //Fluent syntax
            //var result = ListGenerator.ProductsList.FirstOrDefault(p => p.UnitPrice > 1000);


            //Query syntax
            //var result =
            //            (from p in ListGenerator.ProductsList
            //             where p.UnitPrice > 1000
            //             select p).FirstOrDefault();
            #endregion

            #region question3

            // 3. Retrieve the second number greater than 5  

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //Fluent syntax
            //var result = Arr.Where(x => x > 5).ElementAt(1);

            //Query syntax
            //var result =
            //            (from n in Arr
            //             where n > 5
            //             select n).ElementAt(1);
            #endregion

            #endregion

            #region Aggregate Operators

            #region question1

            //1. Uses Count to get the number of odd numbers in the array 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // Fluent syntax
            //var result = Arr.Count(p => p % 2 != 0);

            // Query syntax
            //var result =
            //            (from n in Arr
            //             where n % 2 != 0
            //             select n).Count();

            #endregion

            #region question2 

            // 2. Return a list of customers and how many orders each has.


            //Fluent syntax
            //var result = ListGenerator.CustomersList.Select(c => new
            //                                                        {
            //                                                            CustomerName = c.CustomerName,
            //                                                            OrdersCount = c.Orders.Count()
            //                                                        });


            // Query syntax
            //var result =
            //            from c in ListGenerator.CustomersList
            //            select new
            //            {
            //                CustomerName = c.CustomerName,
            //                OrdersCount = c.Orders.Count()
            //            };
            #endregion

            #region question3

            // 3. Return a list of categories and how many products each has  (missed)

            // Fluent syntax
            //var result = ListGenerator.ProductsList
            //                                        .GroupBy(p => p.Category)
            //                                        .Select(g => new
            //                                        {
            //                                            Category = g.Key,
            //                                            ProductsCount = g.Count()
            //                                        });


            //Query syntax
            //var result =
            //            from p in ListGenerator.ProductsList
            //            group p by p.Category into g
            //            select new
            //            {
            //                Category = g.Key,
            //                ProductsCount = g.Count()
            //            };
            #endregion

            #region question4

            //4. Get the total of the numbers in an array. 

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };


            //Fluent Syntax
            //var result = Arr.Sum();

            //Query syntax

            //var result = (
            //                from n in Arr
            //                select n).Sum();
            #endregion

            #region question5

            //5. Get the total number of characters of all words in dictionary_english.txt
            //   (Read dictionary_english.txt into Array of String First).

            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //Fluent Syntax
            //var result = words.Sum(word => word.Length);

            //Query syntax
            //var result = (
            //                from word in words
            //                select word.Length).Sum();

            #endregion

            #region question6

            //6. Get the length of the shortest word in dictionary_english.txt
            //   (Read dictionary_english.txt into Array of String First).

            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //Fluent Syntax
            //var result = words.Min(word => word.Length);


            //Query syntax
            //var result = (
            //            from word in words
            //            select word.Length).Min();
            #endregion

            #region question7

            //7. Get the length of the longest word in dictionary_english.txt
            //   (Read dictionary_english.txt into Array of String First).

            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //Fluent Syntax
            //var result = words.Max(word => word.Length);


            //Query syntax
            //var result = (
            //                from word in words
            //                select word.Length).Max();
            #endregion

            #region question8

            //8. Get the average length of the words in dictionary_english.txt
            //   (Read dictionary_english.txt into Array of String First). 

            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //Fluent Syntax
            //var result = words.Average(word => word.Length);


            //Query syntax
            //var result = (
            //            from word in words
            //            select word.Length).Average();

            #endregion

            #endregion

            #region Ordering perations

            #region question1

            // 1. Sort a list of products by name

            // Fluent syntax
            //var result = ListGenerator.ProductsList.OrderBy(p => p.ProductName);

            // Query syntax
            //var result =
            //            from p in ListGenerator.ProductsList
            //            orderby p.ProductName
            //            select p;

            #endregion

            #region question2

            // 2. Uses a custom comparer to do a case-insensitive sort of the words in an array

            // string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            // Fluent syntax
            //var result = Arr.OrderBy(word => word, StringComparer.OrdinalIgnoreCase);

            // Query syntax
            //var result =
            //            from word in Arr
            //            orderby word.ToLower()
            //            select word;

            #endregion

            #region question3

            // 3. Sort a list of products by units in stock from highest to lowest

            // Fluent syntax
            //var result = ListGenerator.ProductsList.OrderByDescending(p => p.UnitsInStock);

            // Query syntax
            //var result =
            //            from p in ListGenerator.ProductsList
            //            orderby p.UnitsInStock descending
            //            select p;

            #endregion

            #region question4

            // 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself

            // string[] Arr = { "zero", "one", "two", "three", "four","five", "six", "seven", "eight", "nine" };

            // Fluent syntax
            //var result = Arr
            //                .OrderBy(word => word.Length)
            //                .ThenBy(word => word);

            // Query syntax
            //var result =
            //            from word in Arr
            //            orderby word.Length, word
            //            select word;

            #endregion

            #region question5

            // 5. Sort first by word length and then by a case-insensitive ,sort of the words in an array

            // string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH","BlUeBeRrY", "ClOvEr", "cHeRry" };

            // Fluent syntax
            //var result = Arr
            //                .OrderBy(word => word.Length)
            //                .ThenBy(word => word, StringComparer.OrdinalIgnoreCase);

            // Query syntax
            //var result =
            //            from word in Arr
            //            orderby word.Length, word.ToLower()
            //            select word;

            #endregion

            #region question6

            // 6. Sort a list of products, first by category,and then by unit price, from highest to lowest

            // Fluent syntax
            //var result = ListGenerator.ProductsList
            //                .OrderBy(p => p.Category)
            //                .ThenByDescending(p => p.UnitPrice);

            // Query syntax
            //var result =
            //            from p in ListGenerator.ProductsList
            //            orderby p.Category, p.UnitPrice descending
            //            select p;

            #endregion

            #region question7

            // 7. Sort first by word length and then by a case-insensitive
            //    descending sort of the words in an array

            // string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH","BlUeBeRrY", "ClOvEr", "cHeRry" };

            // Fluent syntax
            //var result = Arr
            //                .OrderBy(word => word.Length)
            //                .ThenByDescending(word => word, StringComparer.OrdinalIgnoreCase);

            // Query syntax
            //var result =
            //            from word in Arr
            //            orderby word.Length, word.ToLower() descending
            //            select word;
            #endregion

            #region question8

            // 8. Create a list of all digits in the array whose second letter is 'i'
            //    that is reversed from the order in the original array

            // string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            // Fluent syntax
            //var result = Arr
            //                .Where(word => word[1] == 'i')
            //                .Reverse();

            // Query syntax
            //var result =
            //            (from word in Arr
            //             where word[1] == 'i'
            //             select word).Reverse();

            #endregion


            #endregion

            #region Transformation Operators

            #region question1

            // 1. Return a sequence of just the names of a list of products

            // Fluent syntax
            //var result = ListGenerator.ProductsList.Select(p => p.ProductName);

            // Query syntax
            //var result =
            //            from p in ListGenerator.ProductsList
            //            select p.ProductName;
            #endregion

            #region question2

            // 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types)

            // string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            // Fluent syntax
            //var result = words
            //                .Select(word => new
            //                {
            //                    Upper = word.ToUpper(),
            //                    Lower = word.ToLower()
            //                });

            // Query syntax
            //var result =
            //            from word in words
            //            select new
            //            {
            //                Upper = word.ToUpper(),
            //                Lower = word.ToLower()
            //            };
            #endregion

            #region question3

            // 3. Produce a sequence containing some properties of Products,
            //    including UnitPrice which is renamed to Price in the resulting type

            // Fluent syntax
            //var result = ListGenerator.ProductsList
            //                .Select(p => new
            //                {
            //                    p.ProductName,
            //                    p.Category,
            //                    Price = p.UnitPrice
            //                });


            // Query syntax
            //var result =
            //            from p in ListGenerator.ProductsList
            //            select new
            //            {
            //                p.ProductName,
            //                p.Category,
            //                Price = p.UnitPrice
            //            };
            #endregion

            #region question4

            // 4. Determine if the value of int in an array match their position

            // int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // Fluent syntax
            //var result = Arr
            //                .Select((value, index) => new
            //                {
            //                    Value = value,
            //                    Index = index,
            //                    Match = value == index
            //                })
            //                .Where(x => x.Match);

            // Query syntax
            //var result =
            //            from item in Arr.Select((value, index) => new
            //            {
            //                Value = value,
            //                Index = index
            //            })
            //            where item.Value == item.Index
            //            select item;
            #endregion

            #region question5

            // 5. Returns all pairs of numbers from both arrays
            //    such that the number from numbersA is less than the number from numbersB

            // int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            // int[] numbersB = { 1, 3, 5, 7, 8 };

            // Fluent syntax
            //var result = numbersA
            //                .SelectMany(a => numbersB
            //                    .Where(b => a < b)
            //                    .Select(b => new
            //                    {
            //                        A = a,
            //                        B = b
            //                    }));

            // Query syntax
            //var result =
            //            from a in numbersA
            //            from b in numbersB
            //            where a < b
            //            select new
            //            {
            //                A = a,
            //                B = b
            //            };
            #endregion

            #region question6

            // 6. Select all orders where the order total is less than 500.00

            // Fluent syntax
            //var result = ListGenerator.CustomersList
            //                .SelectMany(c => c.Orders)
            //                .Where(o => o.Total < 500.00m);

            // Query syntax
            //var result =
            //            from c in ListGenerator.CustomersList
            //            from o in c.Orders
            //            where o.Total < 500.00m
            //            select o;
            #endregion

            #region question7
            
            // 7. Select all orders where the order was made in 1998 or later

            // Fluent syntax
            //var result = ListGenerator.CustomersList
            //                .SelectMany(c => c.Orders)
            //                .Where(o => o.OrderDate.Year >= 1998);

            // Query syntax
            //var result =
            //            from c in ListGenerator.CustomersList
            //            from o in c.Orders
            //            where o.OrderDate.Year >= 1998
            //            select o;
            #endregion
            #endregion

        }
    }
}
