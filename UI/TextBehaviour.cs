﻿using System.Globalization;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextBehaviour : MonoBehaviour
{
    private Text textObj;
    public UnityEvent awakeEvent;
    
    void Start()
    {
        textObj = GetComponent<Text>();
        awakeEvent.Invoke();
    }

    public void UpdateText(StringList stringListDataObj)
    {
        textObj.text = stringListDataObj.ReturnCurrentLine();
    }
    
    public void UpdateText(IntData intDataObj)
    {
        textObj.text = intDataObj.value.ToString();
    }

    public void UpdateText(string obj)
    {
        textObj.text = obj;
    }

    public void UpdateText(FloatData obj)
    {
        textObj.text = obj.Value.ToString(CultureInfo.CurrentCulture);
    }
}