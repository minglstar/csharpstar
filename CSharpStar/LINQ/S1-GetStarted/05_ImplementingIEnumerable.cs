﻿using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStar.LINQ.S1_GetStarted
{
    public class Params : IEnumerable<int>
    {
        private int a, b, c;

        public Params(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public IEnumerator<int> GetEnumerator()
        {
            yield return a;
            yield return b;
            yield break;
            yield return c;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Person
    {
        private string firstName, middleName, lastName;

        public Person(string firstName, string middleName, string lastName)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
        }

        public IEnumerable<string> Names
        {
            get
            {
                yield return firstName;
                yield return middleName;
                yield return lastName;
            }
        }
    }
    internal class _05_ImplementingIEnumerable
    {
        /*static void Main(string[] args)
        {
            var p = new Params(1, 2, 3);

            foreach (var x in p)
            {
                Console.WriteLine(x);
            }

            var person = new Person("Vladimir", "Ilyitch", "Lenin");

            foreach (var name in person.Names)
            {
                Console.WriteLine(name);
            }
        }*/
    }
}
