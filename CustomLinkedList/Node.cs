using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList
{
    public class Node
    {
        public object value { get; set; }
        public object? next { get; set; }

        public Node(object value)
        {
            this.value = value;
            this.next = null;
        }
    }
}
