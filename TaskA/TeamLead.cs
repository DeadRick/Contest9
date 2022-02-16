using System;
using System.Collections.Generic;

internal class TeamLead : Programmer
{
    public TeamLead(int id, List<Programmer> programmers) : base(id)
    {
        Programmers = programmers;
    }

    public List<Programmer> Programmers { get; set; }

    public void HuntProgrammers(List<TeamLead> teamLeads)
    {


        foreach (var teamLead in teamLeads)
        {
            List<Programmer> helpArr = new();

            if (Id != teamLead.Id)
            {
                foreach (var pro in teamLead.Programmers)
                {
                    if (pro.GetAlmostRandomNumber() % (Id + 1) == 0)
                    {
                        helpArr.Add(pro);
                    }
                }
            }
            foreach (var prog in helpArr)
            {
                teamLeads[Id - 1].Programmers.Add(prog);
                teamLeads[teamLead.Id - 1].Programmers.Remove(prog);
            }
        }


    }
}