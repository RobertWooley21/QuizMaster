using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Quiz : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI Qistiontext;
    [SerializeField] qusitonSO qustions;
    [SerializeField] GameObject[] answerBottons;
    // Start is called before the first frame update
    void Start()
    {
        qustions.text = qustions.GetQustion();



        TextMeshProUGUI bottentext = answerBottons[0].GetComponentInChildren<TextMeshProUGUI>();
        bottentext.text = qustions.GetAnswer(0);


}

    private void GetQustion()
    {
        throw new NotImplementedException();
    }
}  

  
        
    

     