﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _18.ExtractEmails
{
    class ExtractEmail
    {
        static void Main(string[] args)
        {
            string text = "Contact Telerik at telerik@telerik.com or nakov@gmail.com";
            foreach (var item in Regex.Matches(text, @"\w+@\w+.\w+"))
            {
                Console.WriteLine(item);
            }
        }
    }
}
