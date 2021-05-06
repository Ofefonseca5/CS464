using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;


public class SendChoicesToGoogle : MonoBehaviour
{

    public static string q1_str = "Default"; //default value
    public static string q2_str = "Default"; //default value
    public static string q3_str = "Default"; //default value
    public static string q4_str = "Default"; //default value
    public static string q5_str = "Default"; //default value
    public static string q6_string = "Default"; //default value - Experiment 1 Decision
    public static string q7_string = "Default"; //default value - Experiment 1 Question
    public static string q8_string = "Default"; //default value - Experiment 1 Question
    public static string q9_string = "Default"; // default value - Experiment 2 Decision
    public static string q10_string = "Default"; //default value - Experiment 2 Question
    public static string q11_string = "Default"; //default value - Experiment 2 Question
    public static string q12_string = "Default"; // default value - Experiment 3 Decision
    public static string q13_string = "Default"; //default value - Experiment 3 Question
    public static string q14_string = "Default"; //default value - Experiment 3 Question
    public static string q15_string = "Default"; //default value - Experiment 3 Question
    


    [SerializeField]
    private string BASE_URL = "https://docs.google.com/forms/u/0/d/e/1FAIpQLSeR2prtuBM4oTNfr2RFpcdWxwAUjB6ERHODxgxpQjCX3Idu9w/formResponse"; //get this from inspect, search for "formResponse"

    public void Send() //this is triggered when the submit button is clicked
    {
        Debug.Log("Outputs " + q1_str + " " + q2_str + " " + q3_str + " " + q4_str + " " + q5_str + " " + q6_string + " " + q7_string + " " + q8_string + " " + q9_string + " " + q10_string + " " + q11_string + " " + q12_string + " " + q13_string + " " + q14_string + " " + q15_string);
        StartCoroutine(Post(q1_str, q2_str, q3_str, q4_str, q5_str, q6_string, q7_string, q8_string, q9_string, q10_string, q11_string, q12_string, q13_string, q14_string, q15_string));
    }

    IEnumerator Post(string q1, string q2, string q3, string q4, string q5, string q6, string q7, string q8, string q9, string q10, string q11, string q12, string q13, string q14, string q15) //coroutine to the send() func
    {
        Debug.Log("POST " + q1_str + " " + q2_str + " " + q3_str + " " + q4_str + " " + q5_str + " " + q6_string + " " + q7_string + " " + q8_string + " " + q9_string + " " + q10_string + " " + q11_string + " " + q12_string + " " + q13_string + " " + q14_string + " " + q15_string);
        WWWForm form = new WWWForm();
        form.AddField("entry.1723546781", q1); //get from inspect
        form.AddField("entry.584288480", q2); //get from inspect
        form.AddField("entry.2029402032", q3); //get from inspect
        form.AddField("entry.438523522", q4); //get from inspect
        form.AddField("entry.1803032315", q5); //get from inspect
        form.AddField("entry.2064207394", q6); //get from inspect
        form.AddField("entry.682619057", q7); //get from inspect
        form.AddField("entry.231045396", q8); //get from inspect
        form.AddField("entry.762671112", q9); //get from inspect
        form.AddField("entry.262224901", q10); //get from inspect
        form.AddField("entry.135894803", q11); //get from inspect
        form.AddField("entry.527955514", q12); //get from inspect
        form.AddField("entry.279572422", q13); //get from inspect
        form.AddField("entry.1262662391", q14); //get from inspect
        form.AddField("entry.667661670", q15); //get from inspect
        UnityWebRequest www = UnityWebRequest.Post(BASE_URL, form);
        yield return www.SendWebRequest();
    }

    public void q1(int val) //triggered when there is a value change on the drop down menu
    {
        Debug.Log(val + " ");

        // converting choice values to their respective string values
        if (val == 1)
        {
            q1_str = "Male";
            Debug.Log(q1_str + " ");
        }
        else if (val == 2)
        {
            q1_str = "Female";
            Debug.Log(q1_str + " ");
        }
        else if (val == 3)
        {
            q1_str = "Other";
            Debug.Log(q1_str + " ");
        }
        Debug.Log("Q1 " + q1_str + " " + q2_str + " " + q3_str + " " + q4_str + " " + q5_str + " " + q6_string + " " + q7_string + " " + q8_string + " " + q9_string + " " + q10_string + " " + q11_string + " " + q12_string + " " + q13_string + " " + q14_string + " " + q15_string);

    }

    // converting choice values to their respective string values
    public void q2(int val) // triggered when there is a value change
    {
        Debug.Log(val + " ");
        if (val == 1)
        {
            q2_str = "0 - 17";
            Debug.Log(q2_str + " ");
        }
        else if (val == 2)
        {
            q2_str = "18 - 24";
            Debug.Log(q2_str + " ");
        }
        else if (val == 3)
        {
            q2_str = "24 - 34";
            Debug.Log(q2_str + " ");
        }
        else if (val == 4)
        {
            q2_str = "35 - 44";
            Debug.Log(q2_str + " ");
        }
        else if (val == 5)
        {
            q2_str = "45 - 54";
            Debug.Log(q2_str + " ");
        }
        else if (val == 6)
        {
            q2_str = "55 - 64";
            Debug.Log(q2_str + " ");
        }
        else if (val == 7)
        {
            q2_str = "65 - 74";
            Debug.Log(q2_str + " ");
        }
        else if (val == 8)
        {
            q2_str = "75 or more";
            Debug.Log(q2_str + " ");
        }
        Debug.Log("Q2 " + q1_str + " " + q2_str + " " + q3_str + " " + q4_str + " " + q5_str + " " + q6_string + " " + q7_string + " " + q8_string + " " + q9_string + " " + q10_string + " " + q11_string + " " + q12_string + " " + q13_string + " " + q14_string + " " + q15_string);

    }

    public void q3(int val)
    {
        Debug.Log(val + " ");
        if (val == 1)
        {
            q3_str = "White";
            Debug.Log(q3_str + " ");
        }
        else if (val == 2)
        {
            q3_str = "American Indian";
            Debug.Log(q3_str + " ");
        }
        else if (val == 3)
        {
            q3_str = "Asian";
            Debug.Log(q3_str + " ");
        }
        else if (val == 4)
        {
            q3_str = "Middle Eastern or North African";
            Debug.Log(q3_str + " ");
        }
        else if (val == 5)
        {
            q3_str = "Native Hawaiian or Other Pacific Islander";
            Debug.Log(q3_str + " ");
        }
        else if (val == 6)
        {
            q3_str = "Black or African American";
            Debug.Log(q3_str + " ");
        }
        else if (val == 7)
        {
            q3_str = "Hispanic Latino or Spanish Origin";
            Debug.Log(q3_str + " ");
        }
        else if (val == 8)
        {
            q3_str = "Hispanic Latino or Spanish Origin";
            Debug.Log(q3_str + " ");
        }
        Debug.Log("Q3 " + q1_str + " " + q2_str + " " + q3_str + " " + q4_str + " " + q5_str + " " + q6_string + " " + q7_string + " " + q8_string + " " + q9_string + " " + q10_string + " " + q11_string + " " + q12_string + " " + q13_string + " " + q14_string + " " + q15_string);

    }

    public void q4(int val)
    {
        Debug.Log(val + " ");
        if (val == 1)
        {
            q4_str = "Less than HS diploma";
            Debug.Log(q4_str + " ");
        }
        else if (val == 2)
        {
            q4_str = "High School";
            Debug.Log(q4_str + " ");
        }
        else if (val == 3)
        {
            q4_str = "Some College";
            Debug.Log(q4_str + " ");
        }
        else if (val == 4)
        {
            q4_str = "Bachelors Degree";
            Debug.Log(q4_str + " ");
        }
        else if (val == 5)
        {
            q4_str = "Graduate Degree";
            Debug.Log(q4_str + " ");
        }
        else if (val == 6)
        {
            q4_str = "Higher Education";
            Debug.Log(q4_str + " ");
        }
        else if (val == 7)
        {
            q4_str = "Other";
            Debug.Log(q4_str + " ");
        }
        Debug.Log("Q4 " + q1_str + " " + q2_str + " " + q3_str + " " + q4_str + " " + q5_str + " " + q6_string + " " + q7_string + " " + q8_string + " " + q9_string + " " + q10_string + " " + q11_string + " " + q12_string + " " + q13_string + " " + q14_string + " " + q15_string);

    }

    public void q5(int val)
    {
        Debug.Log(val + " ");
        if (val == 1)
        {
            q5_str = "Web Browser";
            Debug.Log(q5_str + " ");
        }
        else if (val == 2)
        {
            q5_str = "3D";
            Debug.Log(q5_str + " ");
        }
        Debug.Log("Q5 " + q1_str + " " + q2_str + " " + q3_str + " " + q4_str + " " + q5_str + " " + q6_string + " " + q7_string + " " + q8_string + " " + q9_string + " " + q10_string + " " + q11_string + " " + q12_string + " " + q13_string + " " + q14_string + " " + q15_string);

    }

    public void q6(int val) // triggered when there is a value change
    {
        Debug.Log(val + " ");
        if (val == 1)
        {
            q6_string = "Save the Stroller";
            Debug.Log(q6_string + " ");
        }
        else if (val == 2)
        {
            q6_string = "Save the Man";
            Debug.Log(q6_string + " ");
        }
        Debug.Log("Q6 " + q1_str + " " + q2_str + " " + q3_str + " " + q4_str + " " + q5_str + " " + q6_string + " " + q7_string + " " + q8_string + " " + q9_string + " " + q10_string + " " + q11_string + " " + q12_string + " " + q13_string + " " + q14_string + " " + q15_string);

    }

    // converting choice values to their respective string values
    public void q7(int val) // triggered when there is a value change
    {
        Debug.Log(val + " ");
        if (val == 1)
        {
            q7_string = "Yes";
            Debug.Log(q7_string + " ");
        }
        else if (val == 2)
        {
            q7_string = "No";
            Debug.Log(q7_string + " ");
        }
        Debug.Log("Q7 " + q1_str + " " + q2_str + " " + q3_str + " " + q4_str + " " + q5_str + " " + q6_string + " " + q7_string + " " + q8_string + " " + q9_string + " " + q10_string + " " + q11_string + " " + q12_string + " " + q13_string + " " + q14_string + " " + q15_string);

    }

    public void q8(int val) // triggered when there is a value change
    {
        Debug.Log(val + " ");
        if (val == 1)
        {
            q8_string = "Time";
            Debug.Log(q8_string + " ");
        }
        else if (val == 2)
        {
            q8_string = "Age";
            Debug.Log(q8_string + " ");
        }
        Debug.Log("Q8 " + q1_str + " " + q2_str + " " + q3_str + " " + q4_str + " " + q5_str + " " + q6_string + " " + q7_string + " " + q8_string + " " + q9_string + " " + q10_string + " " + q11_string + " " + q12_string + " " + q13_string + " " + q14_string + " " + q15_string);

    }

    public void q9(int val) // triggered when there is a value change
    {
        Debug.Log(val + " ");
        if (val == 1)
        {
            q9_string = "Option 1";
            Debug.Log(q9_string + " ");
        }
        else if (val == 2)
        {
            q9_string = "Option 2";
            Debug.Log(q9_string + " ");
        }
        Debug.Log("Q9 " + q1_str + " " + q2_str + " " + q3_str + " " + q4_str + " " + q5_str + " " + q6_string + " " + q7_string + " " + q8_string + " " + q9_string + " " + q10_string + " " + q11_string + " " + q12_string + " " + q13_string + " " + q14_string + " " + q15_string);

    }

    public void q10(int val) //triggered when there is a value change on the drop down menu
    {
        Debug.Log(val + " ");

        // converting choice values to their respective string values
        if (val == 1)
        {
            q10_string = "Saving More Lives";
            Debug.Log(q10_string + " ");
        }
        else if (val == 2)
        {
            q10_string = "Saving One Life";
            Debug.Log(q10_string + " ");
        }
        else if (val == 3)
        {
            q10_string = "Saving a Mother";
            Debug.Log(q10_string + " ");
        }
        else if (val == 4)
        {
            q10_string = "Saving a Baby";
            Debug.Log(q10_string + " ");
        }
        else if (val == 5)
        {
            q10_string = "Saving a US Veteran";
            Debug.Log(q10_string + " ");
        }
        else if (val == 6)
        {
            q10_string = "Saving Young Lives";
            Debug.Log(q10_string + " ");
        }
        else if (val == 7)
        {
            q10_string = "Saving Old Lives";
            Debug.Log(q10_string + " ");
        }
        Debug.Log("Q10 " + q1_str + " " + q2_str + " " + q3_str + " " + q4_str + " " + q5_str + " " + q6_string + " " + q7_string + " " + q8_string + " " + q9_string + " " + q10_string + " " + q11_string + " " + q12_string + " " + q13_string + " " + q14_string + " " + q15_string);

    }

    // converting choice values to their respective string values
    public void q11(int val) // triggered when there is a value change
    {
        Debug.Log(val + " ");
        if (val == 1)
        {
            q11_string = "Yes";
            Debug.Log(q11_string + " ");
        }
        else if (val == 2)
        {
            q11_string = "No";
            Debug.Log(q11_string + " ");
        }
        Debug.Log("Q11 " + q1_str + " " + q2_str + " " + q3_str + " " + q4_str + " " + q5_str + " " + q6_string + " " + q7_string + " " + q8_string + " " + q9_string + " " + q10_string + " " + q11_string + " " + q12_string + " " + q13_string + " " + q14_string + " " + q15_string);

    }

    public void q12(int val) // triggered when there is a value change
    {
        Debug.Log(val + " ");
        if (val == 1)
        {
            q12_string = "Option 1";
            Debug.Log(q12_string + " ");
        }
        else if (val == 2)
        {
            q12_string = "Option 2";
            Debug.Log(q12_string + " ");
        }
        Debug.Log("Q12 " + q1_str + " " + q2_str + " " + q3_str + " " + q4_str + " " + q5_str + " " + q6_string + " " + q7_string + " " + q8_string + " " + q9_string + " " + q10_string + " " + q11_string + " " + q12_string + " " + q13_string + " " + q14_string + " " + q15_string);

    }

    public void q13(int val) // triggered when there is a value change
    {
        Debug.Log(val + " ");
        if (val == 1)
        {
            q13_string = "Painful but long life";
            Debug.Log(q13_string + " ");
        }
        else if (val == 2)
        {
            q13_string = "Short but painless";
            Debug.Log(q13_string + " ");
        }
        Debug.Log("Q13 " + q1_str + " " + q2_str + " " + q3_str + " " + q4_str + " " + q5_str + " " + q6_string + " " + q7_string + " " + q8_string + " " + q9_string + " " + q10_string + " " + q11_string + " " + q12_string + " " + q13_string + " " + q14_string + " " + q15_string);

    }

    // converting choice values to their respective string values
    public void q14(int val) // triggered when there is a value change
    {
        Debug.Log(val + " ");
        if (val == 1)
        {
            q14_string = "Yes";
            Debug.Log(q14_string + " ");
        }
        else if (val == 2)
        {
            q14_string = "No";
            Debug.Log(q14_string + " ");
        }
        Debug.Log("Q14 " + q1_str + " " + q2_str + " " + q3_str + " " + q4_str + " " + q5_str + " " + q6_string + " " + q7_string + " " + q8_string + " " + q9_string + " " + q10_string + " " + q11_string + " " + q12_string + " " + q13_string + " " + q14_string + " " + q15_string);

    }

    // converting choice values to their respective string values
    public void q15(int val) // triggered when there is a value change
    {
        Debug.Log(val + " ");
        if (val == 1)
        {
            q15_string = "Yes";
            Debug.Log(q15_string + " ");
        }
        else if (val == 2)
        {
            q15_string = "No";
            Debug.Log(q15_string + " ");
        }
        Debug.Log("Q15 " + q1_str + " " + q2_str + " " + q3_str + " " + q4_str + " " + q5_str + " " + q6_string + " " + q7_string + " " + q8_string + " " + q9_string + " " + q10_string + " " + q11_string + " " + q12_string + " " + q13_string + " " + q14_string + " " + q15_string);

    }


}