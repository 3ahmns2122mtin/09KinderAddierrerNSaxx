using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class MainScript : MonoBehaviour
{

    [SerializeField] private InputField inputFieldval1, inputFieldval2;
    [SerializeField] private Text txtResult;

    // Start is called before the first frame update
    void Start()
    {



        
    }
 

    public int CheckAddition(int summandA, int summandB)
    {
        int result = 0;

        result = summandA + summandB;
        //Debug.Log(summandA + summandB);
        //Debug.Log(result);
        return result;

    }

    public void GetValues()
    {
        string val1, val2;
        val1 = inputFieldval1.text;
        val2 = inputFieldval2.text;


        Debug.Log("Methode GetValues wird ausgeführt : " + CheckAddition(int.Parse(val1), int.Parse(val2)));
    }

    public void ResetButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Update is called once per frame
    void Update()
    {
 
    }


}
