using System;
using System.IO;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Text;

namespace Nullify
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var path = @"p:\temp\test.cs";
            var sourceText = OpenFile(path);
            var syntaxTree = SyntaxFactory.ParseSyntaxTree(sourceText);
            Console.WriteLine("nullify");
            Console.WriteLine(syntaxTree.ToString());
        }

        internal static SourceText OpenFile(string filePath)
        {
            using var fileStream = new FileStream(
                filePath,
                FileMode.Open,
                FileAccess.Read,
                FileShare.ReadWrite);
            return SourceText.From(fileStream);
        }
    }
}
