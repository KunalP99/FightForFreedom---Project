using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public GameObject player;
    public float speedOffset;

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 startPos = transform.position; //cameras current position
        Vector3 endPos = player.transform.position; //player position

        endPos.z = -10; //keeps camera behind characters

        //linear interpolation (lerp) - allows the camera to go from one position (start pos) to another (end pos) in a certain amount of time
        transform.position = Vector3.Lerp(startPos, endPos, speedOffset * Time.deltaTime);

        //allows the camera to move toward player position. Use vector 3, as we want the Z to stay behind the character so it displays in game view
        //transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);
    }
}
