using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //This makes camera focus on the desired object. It's the player in my case.
    [SerializeField] private Transform player1;
    [SerializeField] private Transform player2;
    private Transform playerFollow;
    PlayerMovement player1Movement;

    private void Start()
    {
        player1Movement = player1.GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        if (player1Movement.player1)
        {
            playerFollow = player1;
        }
        else { playerFollow = player2; }

        transform.position = new Vector3(playerFollow.position.x, playerFollow.position.y, transform.position.z);
    }
}
