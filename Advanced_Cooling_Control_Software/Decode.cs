using System;
using System.Collections.Generic;
using System.IO;

namespace Advanced_Cooling_Control_Software
{
    public class Decode
    {
        public static string KeyNotfoundstr = "KEY NOT FOUND!";
        // detects m-codes and messages from txt file, stores it
        // into dictionary like data structue[MCODE_DICT <str, str>]
        public string SearchCmdInDict(string _code, string _path = @"codes.txt")
        {
            var MCODES_DICT = new Dictionary<string, string>();
            char bound_char = ':';
            int msgSIndex, msgEIndex;
            string sline, code, cmsg, fcmd;

            var lines = File.ReadAllLines(_path);  // read file from @_path

            for (int i = 0; i < lines.Length; i += 1)
            {
                sline = lines[i];
                msgSIndex = sline.IndexOf(bound_char);
                msgEIndex = sline.IndexOf(bound_char, msgSIndex + 1);

                code = sline.Substring(0, msgSIndex);
                cmsg = sline.Substring(msgSIndex + 1, msgEIndex - msgSIndex - 1);

                // @debug.try [if d.cons: true]
                //Console.WriteLine(sline);
                //Console.WriteLine("msgSIndex: " + msgSIndex);
                //Console.WriteLine("msgEIndex: " + msgEIndex);
                //Console.WriteLine("line length: " + sline.Length);
                //Console.WriteLine("LINE NO: " + (i + 1));
                //Console.WriteLine("<" + code + "> !<" + MCODES_DICT[code] + ">!");

                MCODES_DICT.Add(code, cmsg);
            }
            try
            {
                fcmd = MCODES_DICT[_code];
            }
            catch (KeyNotFoundException)
            {
                fcmd = KeyNotfoundstr + Environment.NewLine;
            }
            // Console.WriteLine("[ MSG: dictionary initiated success <code> <msg> ]");
            return fcmd;
        }
    }
}
