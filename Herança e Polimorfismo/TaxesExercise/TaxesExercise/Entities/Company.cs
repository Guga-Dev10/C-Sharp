﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TaxesExercise.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }
        public Company()
        {
        }

        public Company(string name, double anualIncome, int numberOfEmployees)
            : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }
        public override double Tax()
        {
            double tax = 0;
            if(NumberOfEmployees <= 10)
            {
                tax = AnualIncome * 0.16;
            }
            else if(NumberOfEmployees > 10)
            {
                tax = AnualIncome * 0.14;
            }
            return tax;
        }
    }
}