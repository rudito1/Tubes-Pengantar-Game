using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public Transform spawnpoint;

    private void OnTriggerEnter2D(Collider2D other)
    {
        spawnpoint.position = this.transform.position;
    }
}
