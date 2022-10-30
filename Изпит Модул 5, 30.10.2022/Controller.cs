using System;
using System.Collections.Generic;
using System.Text;


public class Controller
{
	private readonly Dictionary<string, Category> categories;

    public Controller()
    {
		categories = new Dictionary<string, Category>();
    }

	public string AddCategory(List<string> args)
	{
		string name = args[0]; 
      
		return $"Created Category {name}!";
	}

	public string AddJobOffer(List<string> args)
	{
        string jobOffer = args[0];
		string company = args[1];
		double  salary = double.Parse(args[2]);
		string type = args[3];
		if (type == "onsite")
        {
			string city = args[4];
        }
		else (type == "remote")
		{
			bool fullyRemote = args[5];
        }
		return $" Created JobOffer {jobTitle} in Category {name}!";
	}

	public string GetAverageSalary(List<string> args)
	{
        //TODO: Implement me...
        throw new NotImplementedException();
	}

	public string GetOffersAboveSalary(List<string> args)
	{
        //TODO: Implement me...
        throw new NotImplementedException();
	}

	public string GetOffersWithoutSalary(List<string> args)
	{
        //TODO: Implement me...
        throw new NotImplementedException();
	}

}