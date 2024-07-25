using System;
using UnityEngine;
using System.Collections;
using Jackal;

public class GlobalValue : PersistentSingleton<GlobalValue>
{
    public static bool isSound = true;
    public static bool isMusic = true;
    public static bool isRestart = false;

    public static int levelPlaying = 1; //default = 1, this value is set by Level script, Level object in Menu scene
    public static int worldPlaying = 1; //default = 1

    public static bool checkpoint = false;
    public static bool isUsingJetpack = false;

    public static int checkpointstars = 0;
    public static int checkpointscore = 0;

    public static int Checkpointbullet
    {
        get => PlayerPrefs.GetInt("bullet", 3);
        set => PlayerPrefs.SetInt("bullet", value);
    }

    private void Start()
    {
    }
}