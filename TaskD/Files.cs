using System;
using System.Collections.Generic;

internal class Files
{
    Dictionary<string, string> files = new();
    private string fileName;
    public void CreateFile(string filename)
    {
        fileName = filename;
        files.Add(filename, Permissions.Default.ToString());
    }

    public void AddPermission(string filename, string permission)
    {
        switch (permission)
        {
            case "Default":
                if (!files[filename].Contains(permission))
                {
                    files[filename] = files[filename] + " " + Permissions.Default.ToString();
                }
                break;
            case "UserRead":
                if (!files[filename].Contains(permission))
                    files[filename] = files[filename] + " " + Permissions.UserRead.ToString();
                break;
            case "UserWrite":
                if (!files[filename].Contains(permission))
                    files[filename] = files[filename] + " " + Permissions.UserWrite.ToString();
                break;
            case "UserExecute":
                if (!files[filename].Contains(permission))
                    files[filename] = files[filename] + " " + Permissions.UserExecute.ToString();
                break;
            case "GroupRead":
                if (!files[filename].Contains(permission))
                    files[filename] = files[filename] + " " + Permissions.GroupRead.ToString();
                break;
            case "GroupWrite":
                if (!files[filename].Contains(permission))
                    files[filename] = files[filename] + " " + Permissions.GroupWrite.ToString();
                break;
            case "GroupExecute":
                if (!files[filename].Contains(permission))
                    files[filename] = files[filename] + " " + Permissions.GroupExecute.ToString();
                break;
            case "EveryoneRead":
                if (!files[filename].Contains(permission))
                    files[filename] = files[filename] + " " + Permissions.EveryoneRead.ToString();
                break;
            case "EveryoneWrite":
                if (!files[filename].Contains(permission))
                    files[filename] = files[filename] + " " + Permissions.EveryoneWrite.ToString();
                break;
            case "EveryoneExecute":
                if (!files[filename].Contains(permission))
                    files[filename] = files[filename] + " " + Permissions.EveryoneExecute.ToString();
                break;

        }
    }

    public void RemovePermission(string filename, string permission)
    {
        string wow;
        switch (permission)
        {
            case "Default":
                wow = files[filename];
                files[filename] = wow.Replace(permission, "");
                break;
            case "UserRead":
                wow = files[filename];
                files[filename] = wow.Replace(permission, "");
                break;
            case "UserWrite":
                wow = files[filename];
                files[filename] = wow.Replace(permission, "");
                break;
            case "UserExecute":
                wow = files[filename];
                files[filename] = wow.Replace(permission, "");
                break;
            case "GroupRead":
                wow = files[filename];
                files[filename] = wow.Replace(permission, "");
                break;
            case "GroupWrite":
                wow = files[filename];
                files[filename] = wow.Replace(permission, "");
                break;
            case "GroupExecute":
                wow = files[filename];
                files[filename] = wow.Replace(permission, "");
                break;
            case "EveryoneRead":
                wow = files[filename];
                files[filename] = wow.Replace(permission, "");
                break;
            case "EveryoneWrite":
                wow = files[filename];
                files[filename] = wow.Replace(permission, "");
                break;
            case "EveryoneExecute":
                wow = files[filename];
                files[filename] = wow.Replace(permission, "");
                break;

        }
    }
    public override string ToString()
    {
        List<string> a = new();
        string[] l = new string[] { "Default",
"UserRead",
"UserWrite",
"UserExecute",
"GroupRead",
"GroupWrite",
"GroupExecute",
"EveryoneRead",
"EveryoneWrite",
"EveryoneExecute",
 };
        foreach (var item in files)
        {
            for (int i = 0; i < l.Length; i++)
            {
                if (item.Value.Contains(l[i]))
                {
                    a.Add(l[i]);
                }
            }
            string[] lolococacola = a.ToArray();
            files[item.Key] = string.Join(" ", lolococacola);
            a.Clear();
        }
        foreach (var item in files)
        {
            string[] kk = item.Value.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            string wowow = string.Join(" ", kk);
            // test = string.Join(",", test).Split(new string[] { "," }, Stringsplitoptions.Removeemptyentries);

            Console.WriteLine($"{item.Key}: {wowow}");
        }
        return "";
    }
}
