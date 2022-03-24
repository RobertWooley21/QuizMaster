using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "quiz question", fileName = "New question")]
public class NewBehaviourScript : ScriptableObject
{
    [TextArea(2, 6)]
    [SerializeField] string qusertion = "Enter new question text here";
    [SerializeField] string[] Answer
    [SerializeField] int intorrectAnswerIndex;
    string[] anowers = new string[4];
    public string GetQuestion()
    {
        return question;
    }
    public string GetAnswer(int index);
    {
}
  

     


        




}
       



























    
   
     
    

