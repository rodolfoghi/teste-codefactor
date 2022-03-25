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
    }
}