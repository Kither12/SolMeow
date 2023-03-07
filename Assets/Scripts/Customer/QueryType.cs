using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Flags]
public enum QueryType
{   
    wash = 1,
    cut = 2,
    stylize = 4,
    steam = 8,
    stretch = 16, 
    curly = 32,
    erase = 64,
    dye = 128
}
