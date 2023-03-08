using System;
using System.Collections.Generic;
using System.Text;

namespace AS3Q7Car
{
    class Car
    {
        public string model;
        public enum CarType {SUV,SED,LUX,HATCH }
        public int MgYear;
        public double price;

        public Car(string m, int my, double p)
        {
            this.model = m;
            this.MgYear = my;
            this.price = p;
        }


        public void Print()
        {
            Console.WriteLine("Car Model: "+model+"\nCar Type: "+CarType.LUX+"\nMg Year: "+MgYear+"\nPrice: "+price);
        }


    }

   abstract class Insurance_Policy
    {
        public string policyHolderName;
        public int id;
        public Car car;
        public int NoOFClaims;

        public Insurance_Policy(string phn,int i,Car c, int noc)
        {
            this.policyHolderName = phn;
            this.id = i;
            this.car = c;
            this.NoOFClaims = noc;

        }
        public abstract double Calcpayment(int flatrate);


    }

    class ThirdPartyPolicy : Insurance_Policy
    {
        public string Comments;
        public ThirdPartyPolicy(string com, string phn, int i, Car c, int noc):base(phn,i,c,noc)
        {
            this.Comments=com;
        }
       

        public override double Calcpayment(int flatrate)
        {
            double premium = (car.price / 100) + (NoOFClaims * 200) + flatrate;
            return premium;
        }

        public void ToStrings()
        {
            Console.WriteLine("Policy Holder Name : "+policyHolderName+"ID : "+id+"No of Claims : "+NoOFClaims);
            Console.WriteLine("Comments : "+Comments);
        }



    }

    class ComprehensivePolicy : Insurance_Policy
    {
        public int driverAge;
        public int Level;

        public ComprehensivePolicy(int da, int l,string phn, int i, Car c, int noc) : base(phn, i, c, noc)
        {
            this.driverAge = da;
            this.Level = l;
        }
        public override double Calcpayment(int flatrate)
        {
            double prem;
            prem = (car.price / 50) + (NoOFClaims * 200) + flatrate;
            if (driverAge < 30)
            {
                prem = (50*driverAge) + prem;
                return prem;
            }
            else 
            {
                return prem;
            }
        }
        public void ToStrings()
        {
            Console.WriteLine("Driver Age : "+driverAge+"Level : "+Level+ "Policy Holder Name : " + policyHolderName + "ID : " + id + "No of Claims : " + NoOFClaims);
        }

    }

}
