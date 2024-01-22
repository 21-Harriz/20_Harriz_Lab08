using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CalculatorScript : MonoBehaviour
{
    public Toggle JPY;
    public float value;
    public InputField txtAmount;
    public InputField Convertedvalue;
    public Toggle USD;
    public float SGDAmount;
    public Text debuggingtext;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void conversion()
    {
        try
        {
           SGDAmount = float.Parse(txtAmount.text);
        }
        catch(Exception e)
        {
            debuggingtext.text = "Key in a valid amount value";
        }
        

        if (USD.GetComponent<Toggle>().isOn == true)
        {
            value = SGDAmount * 0.75f;
            Convertedvalue.text = value.ToString() + " USD";
        }
        if (JPY.GetComponent<Toggle>().isOn == true)
        {
            value = SGDAmount * 110.42f;
            Convertedvalue.text = value.ToString() + " JPY";
        }

        if ((USD.GetComponent<Toggle>().isOn == true)&&(JPY.GetComponent<Toggle>().isOn == true))
        {
            debuggingtext.text = "Choose only one option";
            debuggingtext.GetComponent<Text>().color = Color.red;
            Convertedvalue.text = "";
        }
        else
        {
            Convertedvalue.textComponent.color = Color.black;
        }
        /*if(txtAmount.text == "")
        {
            Convertedvalue.text = "Key in a valid amount value";
        }*/

    }

    public void clear()
    {
        Convertedvalue.text = "";
        debuggingtext.text = "";
        txtAmount.text = "";
        //JPY.enabled = false;
        JPY.GetComponent<Toggle>().isOn = false;
        USD.GetComponent<Toggle>().isOn = false;
    }
}
