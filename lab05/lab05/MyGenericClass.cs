using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace lab05
{
    class MyGenericClass<T, Y, U, I> : IComparable<MyGenericClass<T,Y,U,I>> where T : IComparable
    {
        public T Id { get; set; }
        public Y One { get; set; }
        public U Two { get; set; }
        public I Three { get; set; }

        public MyGenericClass()
        {
        }

        public MyGenericClass(T id, Y one, U two, I three)
        {
            Id = id;
            One = one;
            Two = two;
            Three = three;
        }

        public override string ToString() => Id + ", " + One + ", " + Two + ", " + Three;

        public override bool Equals(object obj) => this.ToString() == ToString();

        public override int GetHashCode() => this.ToString().GetHashCode();

        public int CompareTo(MyGenericClass<T, Y, U, I> other) => Id.CompareTo(other.Id);
    }
}
