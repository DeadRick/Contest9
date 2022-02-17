using System;
using System.Collections.Generic;

internal class TeamLead : Programmer
{
    public List<Programmer> Programmers { get; set; }

    public TeamLead(int id, List<Programmer> programmers) : base(id)
    {
        Programmers = programmers;
    }
    public void HuntProgrammers(List<TeamLead> teamLeads)
    {
        foreach (var teamLead in teamLeads)
        {
            List<Programmer> checkArr = new();

            if (Id != teamLead.Id)
            {
                foreach (var leads in teamLead.Programmers)
                {
                    if (leads.GetAlmostRandomNumber() % (Id + 1) == 0)
                    {
                        checkArr.Add(leads);
                    }
                }
            }
            foreach (var human in checkArr)
            {
                teamLeads[Id - 1].Programmers.Add(human);
                teamLeads[teamLead.Id - 1].Programmers.Remove(human);
            }
        }


    }
}