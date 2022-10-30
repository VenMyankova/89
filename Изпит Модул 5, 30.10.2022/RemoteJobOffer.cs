using System;
using System.Collections.Generic;
using System.Text;

public class RemoteJobOffer : JobOffer
{
    private bool fullyRemote;

    public RemoteJobOffer(string jobTitle, string company, double salary, bool fullyRemote) : base(jobTitle, company, salary)
    {
        jobTitle = jobTitle;
        Company = company;
        Salary = salary;
        FullyRemote = fullyRemote;
    }

    public bool FullyRemote
    {
        get { return fullyRemote; }
        set { fullyRemote = value; }
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine($"Job Title: {JobTitle}");
        stringBuilder.AppendLine($"Company: {Company}");
        stringBuilder.AppendLine($"Salary: {Salary:f2} BGN");
       

        
        return stringBuilder.ToString();
    }
}

