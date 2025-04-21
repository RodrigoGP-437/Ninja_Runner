using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraFollowPlayer : MonoBehaviour
{
    public Transform Player;
    public Vector3 desface;

    void Update()
    {
        transform.position = Player.position + desface;
    }
}
