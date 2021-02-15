using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterJug
{
    class Program
    {
      public  struct node
        {
            public int x;
            public int y;
            public List<node> child;

        }
        public static List<node> yy = new List<node>();
        int Fillnode(node x)
        {
            int p = 0;
            int maxX = 4;
            int maxy = 3;
            node a = new node();
            
            a.child = new List<node>();
            a.x = x.x;
            a.y = x.y;
      
            if (a.x != maxX)
            {
                a.x = maxX;
                a.child.Add(a);
            }
            a.x = x.x;
            a.y = x.y;
            if (a.y != maxy)
            {
                a.y = maxy;
                a.child.Add(a);
            }
            a.x = x.x;
            a.y = x.y;
            if (a.x > 0)
            {
                a.x = 0;
                a.child.Add(a);
            }
            a.x = x.x;
            a.y = x.y;
            if (a.y > 0)
            {
                a.y = 0;
                a.child.Add(a);
            }
            a.x = x.x;
            a.y = x.y;
            while (a.x < 4 && a.y != 0)
            { p++;
                a.x += 1;
                a.y -= 1;
               
            }
            if (p != 0) { 
                a.child.Add(a);
                a.x = x.x;
                a.y = x.y;
            }
            p = 0;
            while (a.x != 0 && a.y < 3)
            {
                p++;
                a.x -= 1;
                a.y += 1;   
            }
            if (p != 0) { 
                a.child.Add(a);
                a.x = x.x;
                a.y = x.y;
            }
            int gg = 0;
            foreach(var e in a.child)
            {
              
                for (int i = 0; i < yy.Count; i++)
                {
                    if (e.x==yy[i].x&&e.y==yy[i].y)
                    {
                        gg++;
                    }
                }
                if (gg == 0)
                {
                    yy.Add(e);
                    if (e.x == 1 && e.y == 0)
                    {
                        Console.WriteLine("Achieved");
                        return 1;
                    }
                }
                gg = 0;
            }

            return 0;
        }

        static void Main(string[] args)
        {
            Program n = new Program();
           
            node f = new node();
            f.x = 0;
            f.y = 0;
          
            yy.Add(f);
            //while (true)
            //{
            //    n.Fillnode(x);
            //}
            int i = 0;
            while (true)
            {
                if (i == yy.Count) { break; }
                var aa = yy[i];
               int ggo= n.Fillnode(aa);
                if (ggo == 1) { break; }
                i++;
                
            }
           
            foreach(var ff in yy)
            {
                Console.WriteLine(ff.x+"     "+ff.y);
            }
            Console.ReadKey();
            //foreach(var u in yy)
            //{
            //    n.Fillnode(u);
            //}

        }
    }
}
