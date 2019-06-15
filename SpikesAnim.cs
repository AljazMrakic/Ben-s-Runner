using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikesAnim : MonoBehaviour
{
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetTrigger("blinkTrigger");
    }

}
