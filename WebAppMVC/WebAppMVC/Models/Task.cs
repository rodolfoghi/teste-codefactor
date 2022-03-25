using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppMVC.Models
{
    public class Task
    {
        public int Id { get; set; }

        public string Description { get; set; }

        private Dictionary<string, string> namespaceToNewPrefixMapping;

        public Task(Dictionary<string, string> namespaceToNewPrefixMapping)
        {
            this.namespaceToNewPrefixMapping = namespaceToNewPrefixMapping;
        }

        public static int Test()
        {
            var a = 10 + 20;
            var b = a * 2;
            return b;
        }

        public static int TestA()
        {
            var c = 10 + 20;
            var d = c * 2;
            return d;
        }

        public static int TestB()
        {
            var a = 10 + 20;
            var b = a * 2;
            return b;
        }
    }
}