using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Category
{
    private string name;
    private List<JobOffer> jobOffers;

    public string Name
    {
        get { return name; }
        
        set
        {
            if (value.Lenght() <= 2 || value.Lenght() >= 40)
            {
                throw new ArgumentException("Name should be between 2 and 40 characters!");
            }
            name = value;
        }
    }

    public Category(string name)
    {
        Name = name;
    }

    public void AddJobOffer(JobOffer offer)
    {
        jobOffers.Add(offer);
    }

    public double AverageSalary()
    {
        double avg = 0;
        foreach(JobOffer offer in jobOffers)
        {
            avg = offer.Salary + avg;

        }

        return avg = avg / jobOffers.Count;
    }

    public List<JobOffer> GetOffersAboveSalary(double salary)
    {
        return jobOffers = jobOffers.Where(offer => offer.Salary >= AverageSalary())To List().OrderByDescending(j => j.JobTitle).ToList();    
    }

    public List<JobOffer> GetOffersWithoutSalary()
    {
        return jobOffers = jobOffers.Where(x => x.Salary == 0).OrderByDescending(x => x.Name).Tolist();
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine($"Category {Name}");
        stringBuilder.AppendLine($"Total Offers: {jobOffers.Count}");
        
        return stringBuilder.ToString();
    }
}