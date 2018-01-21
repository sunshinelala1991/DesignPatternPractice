using System;
using System.Collections.Generic;
using System.Text;
namespace Coding.Exercise
{
    public class CodeBuilder
    {
        public readonly StringBuilder code = new StringBuilder();
        public readonly StringBuilder codeContent = new StringBuilder();
        public CodeBuilder(string className)
        {
            code.AppendLine("public class " + className);
        }

        public CodeBuilder AddField(string name, string ftype)
        {
            codeContent.AppendLine("  public " + ftype + " " + name + ";");
            return this;
        }

        public override string  ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(code);
            sb.AppendLine("{");
            sb.Append(codeContent);
            sb.AppendLine("}");

            return sb.ToString();
        }
    }



public class test
    {
        //static void Main()
        //{
        //    var cb = new CodeBuilder("Person").AddField("Name", "string").AddField("Age", "int");
        //    Console.WriteLine(cb);
        //    Console.ReadKey();
        //}
    }
}
