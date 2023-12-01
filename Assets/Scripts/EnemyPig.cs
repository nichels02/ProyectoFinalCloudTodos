using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AI.SteeringBehaviours;

public class EnemyPig : EnemyController
{
    [SerializeField] float radio;
    protected override void Movement()
    {
        rb2d.velocity = SteeringBehaviours.Arrive(new Vector2(transform.position.x, transform.position.y),
            new Vector2(playerRefences.transform.position.x, playerRefences.transform.position.y), velocity, maxForce,radio, new Vector2(rb2d.velocity.x, rb2d.velocity.y));
    }
}
