using System;
using System.Collections.Generic;
using System.IO;

class Program{
    static void Main(string[] args){
                    var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            string cat = @"\    /\
 )  ( ')
(  /  )
 \(__)|";
            sw.WriteLine(cat);            

            sr.Close();
            sw.Close();
    }
}
