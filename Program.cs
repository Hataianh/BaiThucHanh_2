using System;
namespace BaiThucHanh_2
    //Bai2
{
    class PS
    {
        private int ts, ms;
        public PS()
        {
            ts = 0; ms = 1;
        }
        public PS(int ts, int ms)
        {
            this.ts = ts;
            this.ms = ms;
        }
        public PS tong(PS t2)
        {
            PS t = new PS();
            t.ts = this.ts * t2.ms + this.ms * t2.ts;
            t.ms = this.ms * t2.ms;
            return t;
        }
        public PS hieu(PS t2)
        {
            PS t = new PS();
            t.ts = this.ts * t2.ms - this.ms * t2.ts;
            t.ms = this.ms * t2.ms;
            return t;
        }
        public PS Nhan(PS t2)
        {
            PS t = new PS();
            t.ts = this.ts * t2.ts;
            t.ms = this.ms * t2.ms;
            return t;
        }
        public PS Chia(PS t2)
        {
            PS t = new PS();
            t.ts = this.ts * t2.ms;
            t.ms = this.ms * t2.ts;
            return t;

        }
        public void KTra(PS t2)
        {
            if (this.ts * t2.ms == this.ms * t2.ts)
                Console.WriteLine("2 phan so bang nhau");
            else
                Console.WriteLine("2 phan so ko bang nhau");

        }
        public void Hien()
        {
            if (ms == 1)
                Console.WriteLine("{0}", ts);
            else
                Console.WriteLine("{0},{1}", ts, ms);
        }
        static void Main(string[] args)
        {

        }
    }
}
//bài 4
public class Dathuc
{
    private int n;
    private double x;
    private double[] a;
    public Dathuc()
    {
        n = 0;
        a = null;
    }
    public Dathuc(mt bac)
    {
        n = bac
        as = newdouble[n];
    }
    public void Nhap()
    {
        Console.Write("nhập hệ số =");
        n = Convert.ToInt16(Console.ReadLine());
        Console.Write("nhập x=");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("nhập hệ số");
        a = rewdouble[n];
        for (int i = 0, i < n, ++i) ;
        Console.Write("a [{0]}", 'i');
        a['i'] = Convert.ToDouble(Console.ReadLine());
    }
    public Dathuc Tong(Dathuc t2)
    {
        if (this.n == t2.n)
        {
            Dathuc t = new Dathuc();
            for (int i = 0; i < n; ++i)
                t.a[i] = this.a[i] + t2.a[i];
            return t;
        }
        else return null;
    }
    public Dathuc Hieu(Dathuc t2)
    {
        if (this.n == t2.n)
        {
            Dathuc t = new Dathuc();
            for (int i = 0; i < n; ++i)
                t.a[i] = this.a[i] - t2.a[i];
            return t;
        }
        else return null;
    }
}
//Bai1
class Stack
{
    private int top;
    private int[] a;
    public bool empty()
    {
        return (top == -1);
    }
    public bool full()
    {
        return (top >= a.Length);
    }
    public Stack()
    {
        a = new int[20];
        top = -1;
    }
    public void push(int x)
    {
        if (!full())
        {
            top = top + 1;
            a[top] = x;
        }
        else
            Console.Write("stack tran");
    }
    public int pop()
    {
        if (empty())
        {
            Console.Write("stack can");
            return 0;
        }
        else
            return a[top--];
    }
}
class hecoso
{
    static void Main()
    {
        int n;
        Console.Write("Nhap vao so can doi:");
        n = int.Parse(Console.ReadLine());
        Stack T = new Stack();
        string st = "0123456789ABCDEF";
        while (n != 0)
        {
            T.push((int)st[n % 16]);
            n = n / 16;
        }
        Console.Write("Ket qua doi sang he 16 :");
        while (!T.empty())
        {
            Console.Write("{0}", (char)T.pop());
        }
        Console.ReadLine();
    }
}