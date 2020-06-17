using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //allows the camera to move toward player position. Use vector 3, as we want the Z to stay behind the character so it displays in game view
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);
    }
}
