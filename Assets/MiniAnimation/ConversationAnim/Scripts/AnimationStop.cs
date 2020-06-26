using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStop : MonoBehaviour
{
    public Animator tsukkomi;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AnimationStoping(AnimationEvent ev)
    {
        tsukkomi.SetLayerWeight(ev.intParameter, ev.floatParameter);
    }
}
