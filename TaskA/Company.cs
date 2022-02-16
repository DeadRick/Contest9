using System;
using System.Collections.Generic;

internal class Company
{
    public Company(int teamLeadsAmount, int[] programmersAmount)
    {
        TeamLeadsAmount = teamLeadsAmount;
        ProgrammersAmount = programmersAmount;

        TeamLeads = new();

        for (int i = 0; i < teamLeadsAmount; i++)
        {
            List<Programmer> progs = new List<Programmer>();

            for (int j = 0; j < programmersAmount[i]; j++)
            {
                progs.Add(new Programmer(int.Parse($"{i + 1}" + $"{j+1}")));
            }

            TeamLeads.Add(new TeamLead(i + 1, progs));
            
        }
    }

    public List<TeamLead> TeamLeads;

    public int TeamLeadsAmount { get; }
    public int[] ProgrammersAmount { get; }

    public void PrintTeams()
    {
        foreach (var item in TeamLeads)
        {
            int k = 0;
            Console.WriteLine($"Team lead #{item.Id}");
            Console.WriteLine($"Amount of programmers in team: {item.Programmers.Count}");
            foreach (var prog in item.Programmers)
            {
                k += prog.GetAlmostRandomNumber();
            }
            k += item.GetAlmostRandomNumber();
            Console.WriteLine($"Written lines of code: {k}");

            //Console.WriteLine(item);
        }
        Console.WriteLine();
    }
}