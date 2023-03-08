using System;
using System.Collections.Generic;
using System.Text;

namespace AS3Q3Polymorphism
{
    class Person
    {
        string name;
        string address;

       
        public Person(string n, string a)
        {
            this.name = n;
            this.address = a;
        }

        public string getName()
        {
            return name;
        }

        public string getAddress()
        {
            return address;
        }

        public void setName(string n)
        {
            this.name = n;
        }
        public void setAddress(string a)
        {
            this.address = a;
        }
        
        public virtual string toStrings()
        {
            return "Person [Name = " + getName() + " ,Address = " + getAddress()+" ]";
        }

    }
    class staff : Person
    {
        string school;
        double pay;
        public staff(string n,string a, string s, double p):base(n,a)
        {
            this.school = s;
            this.pay = p;
        }
        public string getSchool()
        {
            return school;
        }

        public double getPay()
        {
            return pay;
        }

        public void setSchool(string s)
        {
            this.school = s;
        }

        public void setPay(double p)
        {
            this.pay = p;
        }

        public override string toStrings()
        {
            return "Staff [" + base.toStrings() + ",School = " + getSchool() + ", " + getPay() + "] ";
        }
    }

    class student : Person
    {
        string program;
        int year;
        double fee;

        public student(string n, string a,string pr, int y,double f):base(n,a)
        {
            this.program = pr;
            this.year = y;
            this.fee = f;
        }

        public int getYear()
        {
            return year;
        }
        public double getFee()
        {
            return fee;
        }
        public string getProgram()
        {
            return program;
        }

        public void setYear(int y)
        {
            this.year = y;
        }

        public void setFee(double f)
        {
            this.fee = f;
        }
        public void setProgram(string pr)
        {
            this.program = pr;
        }

        public override string toStrings()
        {
            string s = "Student [" + base.toStrings() + ",  Program " + getProgram() + ",Year = " + getYear() + ",Fee = " + getFee();
            return s;
        }
    }
}
