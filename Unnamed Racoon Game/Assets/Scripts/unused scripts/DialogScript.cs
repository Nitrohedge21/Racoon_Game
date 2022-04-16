using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class DialogScript
{
    [SerializeField] List<string> lines;

    public List<string> Lines
    {
        get { return lines; }
    }
}


//The reason why we did it as a class is because this one can be used to make an NPC give player an item by just talking to them