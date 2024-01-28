using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ClickToSetGoal : MonoBehaviour
{
    [SerializeField] MoveAgent _humanPlayer;
    [SerializeField] MoveAgent _monsterPlayer;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            SetDestinationForPlayer(_humanPlayer);
        }

        if (Input.GetMouseButtonDown(1))
        {
            SetDestinationForPlayer(_monsterPlayer);
        }
    }

    private void SetDestinationForPlayer(MoveAgent player)
    {
        Ray goalPosition = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(goalPosition, out RaycastHit hit))
        {
            player?.SetNewDestination(hit.point);
        }
    }
}
