using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RotateButton : MonoBehaviour, IPointerEnterHandler
{

    private Animator animator;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

	// Use this for initialization
	public void OnPointerEnter(PointerEventData data)
    {
            animator.SetBool("isEntering", true);
        
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        animator.SetBool("isEntering", false);
  
    }
}
