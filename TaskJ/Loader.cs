using System;
using System.Collections.Generic;

internal static class Loader
{
    public static bool flag = true;
    public static bool flagCnt = true;
    public static List<string> checkList = new();
    public static int content = 0;
    public static int game = 0;
    public static int movie = 0;
    public static int track = 0;

    public static void Download(List<IDownload> downloadsQueue)
    {

        foreach (var item in downloadsQueue)
        {
            
            item.DownloadContent();
        }
    }
}