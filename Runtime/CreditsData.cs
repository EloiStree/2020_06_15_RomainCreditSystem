﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Student", menuName = "Custom/Student", order = 0)]
public class CreditsData : ScriptableObject
{

    public string m_studentName;
    public string m_studentFirstName;
    [SerializeField]
    public enum m_studentJob
    {
        Artist,
        Developer,
        Coach
    };

    public m_studentJob studentJob;

    public string m_Surname;

    [SerializeField]
    public Sprite m_profilePicture;
}
