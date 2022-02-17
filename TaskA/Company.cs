using System;
using System.Collections.Generic;

internal class Company
{
    public List<TeamLead> TeamLeads;

    public int cntOfTeamLead { get; }
    public int[] cntOfProgrammers { get; }
    public Company(int teamLeadsAmount, int[] programmersAmount)
    {
        cntOfTeamLead = teamLeadsAmount;
        cntOfProgrammers = programmersAmount;

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

 

    public void PrintTeams()
    {
        foreach (var item in TeamLeads)
        {
            Console.WriteLine($"Team lead #{item.Id.ToString()}");
            Console.WriteLine($"Amount of programmers in team: {item.Programmers.Count.ToString()}");
            int cnt = 0;

            foreach (var prog in item.Programmers)
            {
                cnt += prog.GetAlmostRandomNumber();
            }
            cnt += item.GetAlmostRandomNumber();
            Console.WriteLine($"Written lines of code: {cnt}");
        }
        Console.WriteLine();
    }
}