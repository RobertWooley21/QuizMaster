using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "quiz qustion", fileName = "New qustion")]
public class NewBehaviourScript : ScriptableObject
{
    [TextArea(2, 6)]
    [SerializeField] string qusertion = "Enter new question text here";

    public string GetQuestion ();


}

