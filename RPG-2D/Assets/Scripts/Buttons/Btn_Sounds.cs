using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Btn_Sounds : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler
{
    [SerializeField] public AudioSource ButtonClickSound;
    [SerializeField] public AudioSource ButtonHoverSound;

    public void OnPointerClick(PointerEventData eventData)
    {
        ButtonClickSound.Play();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        ButtonHoverSound.Play();
    }
}
