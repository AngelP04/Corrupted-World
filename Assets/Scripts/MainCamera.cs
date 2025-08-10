using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        position.x = player.transform.position.x + 1;
        transform.position = position;
    }
}
