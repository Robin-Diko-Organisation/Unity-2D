using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Btn_Clicked : MonoBehaviour, IPointerClickHandler
{
    public string TriggerName;
    private Animator Animator;

    void Start()
    {
        Animator = gameObject.GetComponent<Animator>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Animator.SetTrigger(TriggerName);
    }
}
