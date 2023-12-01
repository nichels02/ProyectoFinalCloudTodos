using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyController : Stats
{
    [SerializeField] protected PlayerController playerRefences;
    [SerializeField] protected float maxForce;

    protected override void Awake()
    {
        base.Awake();
        playerRefences = FindObjectOfType<PlayerController>();
    }
    private void FixedUpdate()
    {
        Movement();
       
    }
    
    protected virtual void Movement(){}


}
