using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class ponyaScript : MonoBehaviour
{

    public GameObject ThePlayer;
    public GameObject ponya;
    public float TargetDistance;
    public float AllowedDistance = 5;
    public float FollowSpeed;
    public RaycastHit Shot;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(ThePlayer.transform);
        if(Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward), out Shot))
        {
            TargetDistance = Shot.distance;
            if(TargetDistance >= AllowedDistance)
            {
                FollowSpeed = 0.1f;
                transform.position = Vector2.MoveTowards(transform.position, ThePlayer.transform.position, FollowSpeed);
            }
            else 
            {
                FollowSpeed = 0;
            }
        }
    }
}
