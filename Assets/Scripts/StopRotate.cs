using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class StopRotate : MonoBehaviour, IPointerExitHandler {

    private Animator animator;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        animator.SetBool("isEntering", false);

    }
}
