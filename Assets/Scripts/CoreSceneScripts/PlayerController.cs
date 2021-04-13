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
    GameObject player;

    Rigidbody2D playerRB;


    void Awake()
    {
        player = Instantiate(playerPrefab, this.transform);
        playerRB = player.GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            MousePos = Input.mousePosition;
            var world = Camera.main.ScreenToWorldPoint(MousePos);
            player.transform.position = new Vector3(world.x, world.y, 0);
        }
        
    }

    public void MovingPlayer()
    {
        MousePos = Input.mousePosition;

        var world = Camera.main.ScreenToWorldPoint(MousePos);
            if (Input.GetMouseButtonUp(0))
            {
                Shoot(3);
            }

    }

    void Shoot(int speed)
    {
        Debug.Log("up");
        playerRB.velocity = new Vector2(0f, speed);
    }
}
