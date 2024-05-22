﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    //Create an abstract class called Person with two properties: string firstName and string lastName.
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        //Create method SayName()
        public abstract void SayName();
    }
}
