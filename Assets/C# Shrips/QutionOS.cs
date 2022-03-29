using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "quiz question", fileName = "New question")]
public class QuestionSO : ScriptableObject
{
    [TextArea(2, 6)]
    [SerializeField] string question = "Enter new question text here";
    [SerializeField] string[] answer;
    [SerializeField] int correctAnswerIndex;
    string[] Answer = new string[4];
    public string GetQuestion()
    {
        return question;


    }


    public string GetAnswer(int index)
    {
        return answer[index];
    }

    public int GetCorrectAnswer()
    {


        return correctAnswerIndex;
    }

}       
      
            
       
     

  

     


        





       



























    
   
     
    

