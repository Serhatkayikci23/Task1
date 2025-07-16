using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;


public class CalculatorController : MonoBehaviour
{
     public TextMeshProUGUI resultText;
     private string currentIn = "";
    private double result = 0.0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         updateDisplay();
    }

    public void OnButtonClick(string buttonValue)
    {
        if (buttonValue == "=")
        {
            calculateResult();
        }
        else if (buttonValue == "C")
        {
            clearInp();
        }
        else
        {
            currentIn += buttonValue;
            updateDisplay();
        }
    }

    
    public void GetNumber(int number)
    {
        currentIn += number.ToString();
        updateDisplay();
    }

    
    public void GetOperation(string operation)
    {
        if(operation == "x")
         currentIn += "*";
        else if (operation == "÷")
         currentIn += "/";
        else if  (operation == "%")   
        currentIn += "%";
      else
        currentIn += operation;
        updateDisplay();
    }

    
    public void GetDelete(string delete)
    {
        clearInp();
    }

    
    public void GetDeleteLast(string last)
    {
        if (currentIn.Length > 0)
        {
            currentIn = currentIn.Substring(0, currentIn.Length - 1);
            updateDisplay();
        }
    }

    public void GetComma(string comma)
    {
        currentIn += ".";
        updateDisplay();
    }

    
    public void GetResult(string result)
    {
        calculateResult();
    }

   
    
    
    private void calculateResult()
    {
        try
        {
            
            result = System.Convert.ToDouble(new System.Data.DataTable().Compute(currentIn, ""));
            currentIn = result.ToString();
            updateDisplay();
        }
        catch (System.Exception)
        {
            currentIn = "Error!!";
            updateDisplay();
        }
    }

    
    private void updateDisplay()
    {
        resultText.text = currentIn;
    }

    // Temizle
    private void clearInp()
    {
        currentIn = "";
        result = 0.0;
        updateDisplay();
    }



   

/*



    public void GetOperation(string operation)
    {
        Debug.Log(operation + " clicked");




    }

            public void GetNumber(int number)
            {
                Debug.Log(number + " clicked");

        

             }

            public void GetDelete(string delete)
            {
                Debug.Log(delete + " clicked");

            }

            public void GetDeleteLast(string last)
            {
                Debug.Log(last + " clicked");

            }

            public void GetComma( string comma)
            {
                Debug.Log(comma + " clicked");

            }

            public void GetResult (string result)
            {
                Debug.Log(result + " clicked");

            }

        */

}
