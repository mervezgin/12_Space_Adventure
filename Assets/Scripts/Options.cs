using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Options 
{
    public static string easy = "easy";
    public static string medium = "medium";
    public static string hard = "hard";

    public static string easyPoint = "easyPoint";
    public static string mediumPoint = "mediumPoint";
    public static string hardPoint = "hardPoint";

    public static string easyGolden = "easyGolden";
    public static string mediumGolden = "mediumGolden";
    public static string hardGolden = "hardGolden";

    public static string musicOpen = "musicOpen";

    public static void EasyValueSend(int easy) { PlayerPrefs.SetInt(Options.easy, easy); }
    public static int EasyValueRead() { return PlayerPrefs.GetInt(Options.easy); }

    public static void MediumValueSend(int medium) { PlayerPrefs.SetInt(Options.medium, medium); }
    public static int MediumValueRead() { return PlayerPrefs.GetInt(Options.medium); }

    public static void HardValueSend(int hard) { PlayerPrefs.SetInt(Options.hard, hard); }
    public static int HardValueRead() { return PlayerPrefs.GetInt(Options.hard); }

    public static void EasyPointValueSend(int easyPoint) { PlayerPrefs.SetInt(Options.easyPoint, easyPoint); }
    public static int EasyPointValueRead() { return PlayerPrefs.GetInt(Options.easyPoint); }

    public static void MediumPointValueSend(int mediumPoint) { PlayerPrefs.SetInt(Options.mediumPoint, mediumPoint); }
    public static int MediumPointValueRead() { return PlayerPrefs.GetInt(Options.mediumPoint); }

    public static void HardPointValueSend(int hardPoint) { PlayerPrefs.SetInt(Options.hardPoint, hardPoint); }
    public static int HardPointValueRead() { return PlayerPrefs.GetInt(Options.hardPoint); }

    public static void EasyGoldenValueSend(int easyGolden) { PlayerPrefs.SetInt(Options.easyGolden, easyGolden); }
    public static int EasyGoldenValueRead() { return PlayerPrefs.GetInt(Options.easyGolden); }

    public static void MediumGoldenValueSend(int mediumGolden) { PlayerPrefs.SetInt(Options.mediumGolden, mediumGolden); }
    public static int MediumGoldenValueRead() { return PlayerPrefs.GetInt(Options.mediumGolden); }

    public static void HardGoldenValueSend(int hardGolden) { PlayerPrefs.SetInt(Options.hardGolden, hardGolden); }
    public static int HardGoldenValueRead() { return PlayerPrefs.GetInt(Options.hardGolden); }

    public static void MusicOpenSend(int musicOpen) { PlayerPrefs.SetInt(Options.musicOpen, musicOpen); }
    public static int MusicOpenRead() { return PlayerPrefs.GetInt(Options.musicOpen); }

    public static bool IsTheRecord()
    {
        if (PlayerPrefs.HasKey(Options.easy) || PlayerPrefs.HasKey(Options.medium) || PlayerPrefs.HasKey(Options.hard))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool MusicOpenIsThereRecord()
    {
        if (PlayerPrefs.HasKey(Options.musicOpen))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
