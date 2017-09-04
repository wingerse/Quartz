using System;
using System.Collections.Generic;
using System.Linq;
using Quartz.Text;

namespace Quartz
{
    public sealed class Program
    {
        public static void Main(string[] args)
        {
            var test = "§1R§2e§3d§4s§5t§6o§7n§8e §9§l§mC§ar§be§ca§dt§ei§fo§1n§§";
            var tokenizer = new Tokenizer(test, Token.DefaultControlChar);
            for (var i = 0; i < 100; i++)
            {
                foreach (var t in tokenizer)
                {
                    Console.WriteLine(t);
                }
            }
        }
    }
}
