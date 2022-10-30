using System;
using System.Collections.Generic;
using System.Text;


public class OnSiteJobOffer : JobOffer
{
    private string city;

    public string City
    {
        get { return city; }
        
        
        set
        {
            if (value.Lenght() <= 3 || value.Lenght() >= 30)
            {
                throw new ArgumentException("City should be between 3 and 30 characters!");
            }
            city = value;
        }
    }

    public OnSiteJobOffer(string jobTitle, string company, double salary, string city) : base(jobTitle, company, salary)
    {
        
    }

    public override string ToString()
    {
        stringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine($"Job Title: {JobTitle}");
        stringBuilder.AppendLine($"Company: {Company}");
        stringBuilder.AppendLine($"Salary: {Salary:f2} BGN");
        stringBuilder.AppendLine($"City: {City}");
        return stringBuilder.ToString();
    }
}

