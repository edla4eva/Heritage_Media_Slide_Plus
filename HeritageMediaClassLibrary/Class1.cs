using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeritageMediaClassLibrary
{
    public class ClassP

    {
        public string test()
        {
            return "Hello Olae DLL";
            //System.Windows.Forms.Screen.AllScreens
            //Screen[] screens = Screen.AllScreens;
        }

       
        /* If there was, you could write it like this: */

       /* public static IEnumerable<string> SplitCommandLine(string commandLine)
        {
            bool inQuotes = false;

            return commandLine.Split(c =>
            {
                if (c == '\"')
                    inQuotes = !inQuotes;

                return !inQuotes && c == ' ';
            })
                              .Select(arg => arg.Trim().TrimMatchingQuotes('\"'))
                              .Where(arg => !string.IsNullOrEmpty(arg));
        }
        * */

        /////* Although having written that, why not write the necessary extension methods. Okay, you talked me into it...

        ////Firstly, my own version of Split that takes a function that has to decide whether the specified character should split the string: */

        ////public static IEnumerable<string> Split(this string str,
        ////                                        Func<char, bool> controller)
        ////{
        ////    int nextPiece = 0;

        ////    for (int c = 0; c < str.Length; c++)
        ////    {
        ////        if (controller(str[c]))
        ////        {
        ////            yield return str.Substring(nextPiece, c - nextPiece);
        ////            nextPiece = c + 1;
        ////        }
        ////    }

        ////    yield return str.Substring(nextPiece);
        ////}

        /////* It may yield some empty strings depending on the situation, but maybe that information will be useful in other cases, so I don't remove the empty entries in this function.

        ////Secondly (and more mundanely) a little helper that will trim a matching pair of quotes from the start and end of a string. It's more fussy than the standard Trim method - it will only trim one character from each end, and it will not trim from just one end: */

        ////public static string TrimMatchingQuotes(this string input, char quote)
        ////{
        ////    if ((input.Length >= 2) &&
        ////        (input[0] == quote) && (input[input.Length - 1] == quote))
        ////        return input.Substring(1, input.Length - 2);

        ////    return input;
        ////}

        /////* And I suppose you'll want some tests as well. Well, alright then. 
        //// * But this must be absolutely the last thing! First a helper function that 
        //// * compares the result of the split with the expected array contents: */

        ////public static void Test(string cmdLine, params string[] args)
        ////{
        ////    string[] split = SplitCommandLine(cmdLine).ToArray();

        ////    Debug.Assert(split.Length == args.Length);

        ////    for (int n = 0; n < split.Length; n++)
        ////        Debug.Assert(split[n] == args[n]);
        ////}

        /////* Then I can write tests like this:

        ////        Test("");
        ////        Test("a", "a");
        ////        Test(" abc ", "abc");
        ////        Test("a b ", "a", "b");
        ////        Test("a b \"c d\"", "a", "b", "c d");

        //// Here's the test for your requirements:

        ////        Test(@"/src:""C:\tmp\Some Folder\Sub Folder"" /users:""abcdefg@hijkl.com"" tasks:""SomeTask,Some Other Task"" -someParam",
        ////             @"/src:""C:\tmp\Some Folder\Sub Folder""", @"/users:""abcdefg@hijkl.com""", @"tasks:""SomeTask,Some Other Task""", @"-someParam"); */

        /////* Note that the implementation has the extra feature that it will remove quotes around an argument if that makes sense (thanks to the TrimMatchingQuotes function). I believe that's part of the normal command-line interpretation. */

    }
}
