using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacketGenerator
{
    public class Foo : IBufferReader, IBufferWrite
    {
        public byte b;
        public short s;
        public int i;
        public long l;
        public char c;
        public float f;
        public double d;
        public bool bl;
        public DateTime date;
        public string str;
        public Foo() { }
        public Foo(byte _b, short _s, int _i, long _l, char _c, float _f, double _d, bool _bl,
            DateTime _date, string _str)
        {
            b = _b;
            s = _s;
            i = _i;
            l = _l;
            c = _c;
            f = _f;
            d = _d;
            bl = _bl;
            date = _date;
            str = _str;
        }
        public void WriteToBuffer(ByteBuffer bb)
        {
            bb.Write(b);
            bb.Write(s);
            bb.Write(i);
            bb.Write(l);
            bb.Write(c);
            bb.Write(f);
            bb.Write(d);
            bb.Write(bl);
            bb.Write(date);
            bb.Write(str);
        }
        public void ReaderFromBuffer(ByteBuffer bb)
        {
            //b = bb.ReadByte();
            //s = bb.ReadShort();
            //i = bb.ReadInt();
            //l = bb.ReadLong();
            //c = bb.ReadChar();
            //f = bb.ReadFloat();
            //d = bb.ReadDouble();
            //bl = bb.ReadBoolean();
            //date = bb.ReadDate();
            //str = bb.ReadString();
            bb.Read(out b);
            bb.Read(out s);
            bb.Read(out i);
            bb.Read(out l);
            bb.Read(out c);
            bb.Read(out f);
            bb.Read(out d);
            bb.Read(out bl);
            bb.Read(out date);
            bb.Read(out str);
        }
    }

    public class Foo1 : IBufferReader, IBufferWrite
    {
        public List<int> listI = new List<int>();
        public List<char> listC = new List<char>();
        public List<bool> listB = new List<bool>();
        public List<double> listD = new List<double>();
        public List<string> listS = new List<string>();
        public void WriteToBuffer(ByteBuffer bb)
        {
            bb.Write(listI);
            bb.Write(listC);
            bb.Write(listB);
            bb.Write(listD);
            bb.Write(listS);
        }
        public void ReaderFromBuffer(ByteBuffer bb)
        {
            //listI = bb.ReadListInt();
            //listC = bb.ReadListChar();
            //listB = bb.ReadListBool();
            //listD = bb.ReadListDouble();
            //listS = bb.ReadListString();
            bb.Read(listI, 0, 0);
            bb.Read(listC, 0, 0);
            bb.Read(listB, 0, 0);
            bb.Read(listD, 0, 0);
            bb.Read(listS, 0, 0);
        }
    }

    public class Foo2 : IBufferReader, IBufferWrite
    {
        public List<Foo> listFoo = new List<Foo>();
        public Foo1 foo1 = new Foo1();
        public void WriteToBuffer(ByteBuffer bb)
        {
            bb.Write(listFoo);
            bb.Write(foo1);
        }
        public void ReaderFromBuffer(ByteBuffer bb)
        {
            listFoo = bb.ReadListObject<Foo>();
            foo1 = bb.Read<Foo1>();
        }
    }

    public static class ByteBufferTest
    {
        public static void Test()
        {
            Foo2 a = new Foo2();
            Foo1 b = new Foo1();
            a.foo1 = b;
            b.listI = new List<int>() { 1, 2, 3, 4, 5 };
            b.listC = new List<char>() { 'a', 'b' };
            b.listB = new List<bool>() { false, false, true, false };
            b.listD = new List<double>() { 1.0, 1.1, 1.11111, 1.123456789 };
            b.listS = new List<string>() { "c#", "Cpp", "java", "lua" };
            List<Foo> listFoo = new List<Foo>(3);
            a.listFoo = listFoo;
            listFoo.Add(new Foo ( 1, 11, 111, 1111, 'a', 1.0f, 1.1, true, new DateTime(2018, 12, 12, 12, 12, 12), "a"));
            listFoo.Add(new Foo(2, 22, 222, 2222, 'b', 2.0f, 2.1, false, new DateTime(2017, 12, 12, 12, 12, 12), "b"));
            listFoo.Add(new Foo(3, 33, 333, 3333, 'c', 3.0f, 3.1, false, new DateTime(2016, 12, 12, 12, 12, 12), "c"));
            ByteBuffer bb = new ByteBuffer();
            a.WriteToBuffer(bb);
            Foo2 foo2 = new Foo2();
            foo2.ReaderFromBuffer(bb);
        }
    }
}
