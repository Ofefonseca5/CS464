using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_Experiment : MonoBehaviour
{
    public void loadExperiment(string exprimentLevel)
    {
        SceneManager.LoadScene(exprimentLevel);
    }

}
