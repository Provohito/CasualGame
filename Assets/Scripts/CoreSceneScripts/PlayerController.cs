using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{ 
    [SerializeField]
    GameObject playerPrefab;

    private Vector2 MousePos;
    bool playerEnable;
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {

            if (playerEnable)
            {
                return;
            }
            else
            {
                MousePos = Input.mousePosition;
                Debug.Log(MousePos);
                var player = Instantiate(playerPrefab);
                var world = Camera.main.ScreenToWorldPoint(MousePos);
                player.transform.position = new Vector3(world.x, world.y, 0);
                playerEnable = true;
            }
            
        }
    }
}
