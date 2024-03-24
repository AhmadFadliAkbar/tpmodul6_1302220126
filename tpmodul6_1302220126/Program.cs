﻿// See https://aka.ms/new-console-template for more information

using TPMOD06_1302220093;

public class Program
{
    public static void Main(string[] args)
    {
        // state awal untuk video berisikan null
        SayaTubeVideo_1302220126 video = null;

        // Design Contract
        try
        {
            // Prekondisi
            video = new SayaTubeVideo_1302220126("Tutorial Design By Contract - Ahmad Fadli Akbar");
            for (int i = 0; i < 10000000; i++)
            {
                video.IncreasePlayCount(1);
            }
        }
        // tes Exception
        catch (Exception tes)
        {
            Console.WriteLine("Error: " + tes.Message);
        }
        finally
        {
            // printoutput jika tidak terdeteksi error
            if (video != null)
            {
                video.PrintVideoDetails();
            }
        }
    }
}