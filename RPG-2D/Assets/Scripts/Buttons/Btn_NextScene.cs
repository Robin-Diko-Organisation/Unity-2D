using System.Collections;
using System.Collections.Generic;
using UnityEngine.Animations;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Btn_NextScene : MonoBehaviour, IPointerClickHandler
{
    public RuntimeAnimatorController AnimatorController;
    public string AnimationName;
    public string SceneAfterClick;
    private Animator Animator;

    void Start()
    {
        Animator = gameObject.AddComponent(typeof(Animator)) as Animator;
        Animator.runtimeAnimatorController = AnimatorController;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Animator.Play(AnimationName);
        float animtime = Animator.GetCurrentAnimatorStateInfo(0).length;
        Invoke("NextScene", animtime+0.5f);
    }

    public void NextScene()
    {
        SceneManager.LoadScene(SceneAfterClick);
    }
}
