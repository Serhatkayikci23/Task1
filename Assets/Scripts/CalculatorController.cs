using UnityEngine;
using TMPro;


public class CalculatorController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

   
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

        

}
