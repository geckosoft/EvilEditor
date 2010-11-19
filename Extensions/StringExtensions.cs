using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Extensions
{

    public static class StringExtensions
    {
        public static string Left(this string s, int count)
        {
            return s.Substring(0, count);
        }

        public static string Right(this string s, int count)
        {
            return s.Substring(s.Length - count, count);
        }

        public static string Mid(this string s, int index, int count)
        {
            return s.Substring(index, count);
        }

        public static int ToInteger(this string s)
        {
            s = s.Replace(".", ",");
            // int integerValue = 0;
            double tmp = 0;
            double.TryParse(s, out tmp);

            //int.TryParse(s, out integerValue);
            return (int)tmp;
        }

        public static bool IsEvilDouble(this string s)
        {
            s = s.Replace(".", ",");
            // int integerValue = 0;
            double tmp = 0;
            return double.TryParse(s, out tmp);
        }

        public static bool IsInteger(this string s)
        {
            Regex regularExpression = new Regex("^-[0-9]+$|^[0-9]+$");
            return regularExpression.Match(s).Success;
        }

        public static string[] Explode(this string s, string splitter)
        {
            return s.Split(new string[] { splitter }, StringSplitOptions.None);
        }
        public static string[] Explode(this string s, string splitter, StringSplitOptions options)
        {
            return s.Split(new string[] { splitter }, options);
        }

        public static int CountOccurances(this string s, string search)
        {
            string t = s.Replace(search, "");
            return ((s.Length - t.Length) / search.Length);
        }
    }

}