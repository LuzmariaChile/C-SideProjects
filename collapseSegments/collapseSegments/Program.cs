using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collapseSegments
{
    class Segment
    {
        public int Low { get; set; }
        public int High { get; set; }
        public Segment(int low, int high) 
        {
            Low = low;
            High = high;
        }

        public void Print()
        {
            Console.WriteLine("[" + this.Low+"," + this.High + "]");
        }
    }


    class Program
    {
        static List<Segment> collapseSegments(List<Segment> seg) 
        {
            var newSeg = new List<Segment>();
            seg.Sort(delegate(Segment x, Segment y)
            {
                var c =  x.Low.CompareTo(y.Low);
                if (c == 0)
                {
                    c = x.High.CompareTo(y.High);
                }
                return c;
            });
            
            var min = seg[0].Low;
            var max = seg[0].High;

            for (var i = 1; i < seg.Count; i++)
            {
                if (seg[i].Low > max)

                {
                    newSeg.Add(new Segment(min, max));
                    min = seg[i].Low;
                    max = seg[i].High;
                }
                else if (seg[i].High >= max)
                {
                    max = seg[i].High;
                }
            }
            newSeg.Add(new Segment(min, max));
            return newSeg;
        }
 
        static void Main(string[] args)
        {
            var firstList = new List<Segment>();
            firstList.Add(new Segment(0, 7));
            firstList.Add(new Segment(3, 15));
            firstList.Add(new Segment(7, 12));
            firstList.Add(new Segment(13, 15));
            
            foreach (var segment in firstList) 
            {
                segment.Print();
            }

            var newList = collapseSegments(firstList);
            foreach (var segment in newList) 
            {
                segment.Print();
            }
            Console.ReadKey();
        }
    }
}
