using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerForAnimation : MonoBehaviour
{
    [SerializeField] float _waitingTime;
    public Animator _animator;
    public GameObject _gameObject;
   

   
    void Start()
    {
        StartCoroutine(AnimatorDelayer());
       
    }

    IEnumerator AnimatorDelayer()
    {
        yield return new WaitForSeconds(_waitingTime);
        _animator.enabled = true;
    }
}

