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
        
    }

    public void MovingPlayer()
    {
        if (playerEnable)
        {
            return;
        }
        else
        {
            MousePos = Input.mousePosition;
            var player = Instantiate(playerPrefab);
            var world = Camera.main.ScreenToWorldPoint(MousePos);
            player.transform.position = new Vector3(world.x, world.y, 0);
            playerEnable = true;
        }
    }
}
