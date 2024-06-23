using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quest/Task/Task", fileName = "Task_")]
public class Task : ScriptableObject
{
    [Header("Text")]
    [SerializeField] 
    private string questIdName;
    [SerializeField] 
    private string questDescription;

    [Header("Action")]
    [SerializeField] 
    private TaskAction action;
    
    [Header("Setting")] 
    [SerializeField] 
    private int needSuccessToComplete;

    public int CurrentSuccess { get; private set; }
    public string QuestIdName = questIdName;
    public string QuestDescription => questDescription;
    public int NeedSuccessToComplete => needSuccessToComplete;

    public void ReceiveReport(int successCount)
    {
        CurrentSuccess = action.Run(this, CurrentSuccess, successCount);
    }
}
