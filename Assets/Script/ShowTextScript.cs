﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowTextScrip : MonoBehaviour
{
    public TMP_InputField inputFieldName;
    public TMP_InputField inputFieldYear;
    public TMP_Text displayField;

    string[] words = { "Sveiki", "Laipni lūgti", "Sveicināti", "Čau" };
    int randomNumb;
    int age;

    public void setText()

    {
        int birthYear;
        if (int.TryParse(inputFieldYear.text, out birthYear))
        {
            age = 2024 - birthYear;
            randomNumb = Random.Range(0, words.Length);
            displayField.text = words[randomNumb] + ", " + inputFieldName.text + ". \nJums ir: " + age + " gadi!";
        }
    }

}