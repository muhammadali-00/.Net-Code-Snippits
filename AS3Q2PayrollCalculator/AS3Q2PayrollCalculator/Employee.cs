using System;
using System.Collections.Generic;
using System.Text;

namespace AS3Q2PayrollCalculator
{
    class Employee
    {
        public int id;
        public string name;
    }
    class SalaryEmployee : Employee,iPayRollCalculator
    {
        public float CalculatePayroll()
        {
            return 0;
        }
    }
    class HourlyEmployee : Employee, iPayRollCalculator

    {
        public float CalculatePayroll()
        {
            return 0;
        }
    }
    class ComissionEmployee: SalaryEmployee,iPayRollCalculator
    {
        public float CalculatePayroll()
        {
            return 0;
        }
    }
    class Manager : SalaryEmployee,IWorker
    {
        public void Work(int hours)
        {

        }
    }
    class Secratary : SalaryEmployee, IWorker
    {
        public void Work(int hours)
        {

        }
    }
    class SalesPerson : ComissionEmployee,IWorker
    {
        public void Work(int hours)
        {

        }
    }
    class FactoryWorker:HourlyEmployee,IWorker 
    {
        public void Work(int hours)
        {

        }
    }
    interface IWorker
    {
         void Work(int hours);
    }
    interface iPayRollCalculator
    {
        public float CalculatePayroll();
        
    }

    

}
