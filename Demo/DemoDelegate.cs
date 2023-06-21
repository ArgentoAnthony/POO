using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public delegate void myDel(int a, int b);

    public delegate void Action();
    public delegate string Func();
    public delegate bool Predicate();
    public class DemoDelegate
    {
       public myDel del;
    }
}
