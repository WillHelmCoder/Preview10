using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preview10
{
    public class ExampleViewModel
    {
        public string AppName { get; set; } = "Preview 10";
        public string Description { get; set; } = "Preview 10 desc";
        //public List<Foo> Foos { get; set; }

    }

    public class Foo
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
