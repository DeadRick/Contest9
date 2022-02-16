using System;
using System.Collections.Generic;

internal class Download<T> : IDownload
    where T: Content
{
   
    public List<T> box = new();
    public Dictionary<string, int> count = new();
    public T val;
    

    public Download(T item)
    {
        
        val = item;
        Content cont = ((Content)val);

        if ((Program.FreeSpace - cont.size > 0) && Loader.flag)
        {
            Program.FreeSpace -= cont.size;
            Console.WriteLine($"{cont.size}/{cont.size} MB");
            if (val is Movie) Loader.movie += 1;
            else if (val is Track) Loader.track += 1;
            else if (val is Game) Loader.game += 1;
            else Loader.content += 1;

            box.Add(val);
        }
        else if(Program.FreeSpace != 0 && Program.FreeSpace - cont.size < 0 && Loader.flag)
        {
            Console.WriteLine($"{Program.FreeSpace}/{cont.size} MB");
            Program.FreeSpace -= Program.FreeSpace;
        }
        else if (Program.FreeSpace == 0 && Loader.flag)
        {
           
            Loader.flag = false;
            Console.WriteLine("Not enough free space!");
            Console.WriteLine();
            Console.WriteLine("Downloaded content:");
        }

    }
   

    public bool DownloadContent()
    {
        

        //if (Loader.flagCnt)
        //{
        //    foreach (var item in box)
        //    {
        //        Console.WriteLine(item.GetType().ToString());
        //        Console.WriteLine(Loader.movie);
        //        if (item is Game) Loader.game += 1;
        //        else if (item is Track) Loader.track += 1;
        //        else if (item is Movie) Loader.movie += 1;
        //        else Loader.content += 1;
        //    }

        //}

        if (Loader.flagCnt)
        {

            if (box.Contains(val))
            {
                foreach (var item in box)
                {
                    if (!Loader.checkList.Contains(val.GetType().ToString()))
                    {
                        if (item is Movie) Console.WriteLine($"{val.GetType().ToString()}: {Loader.movie}");
                        else if (item is Track) Console.WriteLine($"{val.GetType().ToString()}: {Loader.track}");
                        else if (item is Game) Console.WriteLine($"{val.GetType().ToString()}: {Loader.game}");
                        else Console.WriteLine($"{val.GetType().ToString()}: {Loader.content}");
                    }
                    Loader.checkList.Add(val.GetType().ToString());
                }
               
            }
            return true;
        }
        else
        {
            Loader.checkList.Add(val.information);
            return false;
        }
    }
}