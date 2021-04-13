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
        
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0) & playerEnable == false)
        {
            MousePos = Input.mousePosition;
            var world = Camera.main.ScreenToWorldPoint(MousePos);
            player = Instantiate(playerPrefab, this.transform);
            playerRB = player.GetComponent<Rigidbody2D>();
            player.transform.position = new Vector3(world.x, world.y, 0);
            playerEnable = true;
        }
        
    }

    public void MovingPlayer()
    {
            if (Input.GetMouseButtonUp(0))
            {
                Shoot(3);
            }

    }

    void Shoot(int speed) // Скорость снаряда
    {
        Debug.Log("up");
        playerRB.velocity = new Vector2(0f, speed);
        StartCoroutine(WaitTimer());
    }

    IEnumerator WaitTimer()// Скорость выпуска снаряда
    {
        yield return new WaitForSeconds(2);
        playerEnable = false;
        StopAllCoroutines();
    }

}
