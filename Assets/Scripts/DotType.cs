﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PointType
{
    None,
    Black,
    Blue,
    Red,
    Yellow,
    Green,
    Orange,
    While,
}

[CreateAssetMenu(fileName ="NewDot", menuName ="GK/CreateDot")]
public class DotType : ScriptableObject
{
    public Color color;
    public PointType pointType;

    //  TODO: find at way to link point type and color
    //public DotType()
    //{
    //    color = Color.
    //}
}
