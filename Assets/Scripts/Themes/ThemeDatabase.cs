using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// Handles loading data from the Asset Bundle to handle different themes for the game
public class ThemeDatabase
{
    protected static ThemeData themeData ;
    public static ThemeData ThemeData
    {
        get => themeData;
        set => themeData = value;
    }
}
