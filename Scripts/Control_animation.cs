using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Control_animation : MonoBehaviour
{
    public Animator animator;
    public Movement MV;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        MV = GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        float parametrosAxis = Mathf.Abs(MV.CloneAxis);

        animator.SetFloat("MoveInputAxis", parametrosAxis);
    }
}
