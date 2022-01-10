using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq; // You can remove this if you don't need dynamic type in .NET Standard frends Tasks

#pragma warning disable 1591

namespace Frends.Community.Utilities
{
    public static class SmallFUnctions
    {
        /// <summary>
        /// Returns input.
        /// Documentation: https://github.com/CommunityHiQ/Frends.Community.Utilities
        /// </summary>
        /// <param name="input">What to repeat.</param>
        /// <returns>string Replication</returns>
        public static string Echo(string input)
        {

            return input;
        }

        /// <summary>
        /// Returns true
        /// Documentation: https://github.com/CommunityHiQ/Frends.Community.Utilities
        /// </summary>
        /// <returns>bool true</returns>
        public static bool AlwaysTrue()
        {
            return true;
        }

        /// <summary>
        /// Throws an exception
        /// Documentation: https://github.com/CommunityHiQ/Frends.Community.Utilities
        /// </summary>
        /// <param name="message">Error message.</param>
        /// <returns>bool undefined (Error is always threw before anything is returned).</returns>
        public static bool ThrowException(string message)
        {
            throw new Exception(message);
        }


        /// <summary>
        /// Replaces parts from strings that match a regular expression pattern with a specified replacement string.
        /// Documentation: https://github.com/CommunityHiQ/Frends.Community.Utilities
        /// </summary>
        /// <returns>string true</returns>
        /// <param name="input">A string where parts are replaced.</param>
        /// <param name="pattern">A regular expression pattern.</param>
        /// <param name="replacement">A string with replacement in place.</param>
        public static string Replace(string input, string pattern, string replacement)
        {
            return Regex.Replace(input, pattern, replacement);
        }

        /// <summary>
        /// Returns the results from a single regular expression.
        /// Documentation: https://github.com/CommunityHiQ/Frends.Community.Utilities
        /// </summary>
        /// <param name="input">A string where parts are matched.</param>
        /// <param name="pattern">A regular expression pattern.</param>
        /// <returns>A first occurrence of matches.</returns>
        public static string Match(string input, string pattern)
        {
            var match = Regex.Match(input, pattern);
            if (match.Success)
            {
                return match.Value;
            }
            return "";
        }

        /// <summary>
        /// Splits an input string into an array of substrings at the positions defined by a regular expression match.
        /// Documentation: https://github.com/CommunityHiQ/Frends.Community.Utilities
        /// </summary>
        /// <param name="input">A string where parts are matched.</param>
        /// <param name="pattern">A regular expression pattern.</param>
        /// <returns>A array of substrings.</returns>
        public static string[] Split(string input, string pattern)
        {
            return Regex.Split(input, pattern);
        }

        /// <summary>
        /// A cancellable task that will complete after a time delay.
        /// Documentation: https://github.com/CommunityHiQ/Frends.Community.Utilities
        /// </summary>
        /// <param name="hours">Hours being waited.</param>
        /// <param name="minutes">Minutes being waited.</param>
        /// <param name="seconds">Seconds being waited.</param>        
        /// <param name="milliseconds">Milliseconds being waited.</param>        
        /// <returns>bool true</returns>
        public async static Task<bool> Sleep(int hours, int minutes, int seconds, int milliseconds, CancellationToken cancellationToken)
        {

            var delay = new TimeSpan(0, hours, minutes, seconds, milliseconds);
            await Task.Delay(delay, cancellationToken).ConfigureAwait(false);

            return true;
        }


        /// <summary>
        /// If input is not already a JArray this Task returns JArray, with input it's only item.
        /// Documentation: https://github.com/CommunityHiQ/Frends.Community.Utilities
        /// </summary>
        /// <param name="input">A string where parts are matched.</param>
        /// <returns>JArray</returns>
        public static JArray ConvertToJArray(dynamic input)
        {
            if (input.GetType() == typeof(JArray))
            {
                return input;
            }

            var emptyArray = new JArray
            {
                input
            };
            return emptyArray;
        }

        public class DumpOutput
        {
            /// <summary>
            /// Type of an object.
            /// </summary>
            public string Type { get; set; }
            /// <summary>
            /// Object serialized to human-readable string.
            /// </summary>
            public string ConsoleStyle { get; set; }
            /// <summary>
            /// Object serialized to  C# code.
            /// </summary>
            public string CSharpStyle { get; set; }

        }

        /// <summary>
        /// If input is not already a JArray this Task returns JArray, with input it's only item.
        /// Documentation: https://github.com/CommunityHiQ/Frends.Community.Utilities
        /// </summary>
        /// <param name="input">A string where parts are matched.</param>
        /// <returns>JArray</returns>
        public static DumpOutput Dump(dynamic input)
        {

            var ret = new DumpOutput
            {
                Type = input.GetType().ToString(),
                ConsoleStyle = ObjectDumper.Dump(input),
                CSharpStyle = ObjectDumper.Dump(input, DumpStyle.CSharp)

            };

            return ret;
        }
    }
}
