using System.Diagnostics;
using UnityEngine;

public class followPlayer2 : MonoBehaviour {

    public Transform player;
    public Vector3 Offset;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = player.position + Offset;
    }
}
