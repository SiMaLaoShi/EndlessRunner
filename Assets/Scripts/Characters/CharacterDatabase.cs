﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// This allows us to store a database of all characters currently in the bundles, indexed by name.
/// </summary>
public class CharacterDatabase
{
    
    protected static Character character ;
    public static Character Character
    {
        get => character;
        set => character = value;
    }
}