using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveAgent : MonoBehaviour
{
    [SerializeField] NavMeshAgent _navAgent;
    [SerializeField] Transform _goal;
    [SerializeField] GameObject PopScreen;

    // Start is called before the first frame update
    void Start()
    {
        SetNewDestination(_goal.position);
    }

    void Update()
    {
        if(transform.position.x == _goal.position.x)
        {
            PopScreen.transform.position = new Vector2(Screen.width / 2, Screen.height / 2);
        }
    }


    public void SetNewDestination(Vector3 goalPosition)
    {
        _navAgent.SetDestination(goalPosition);
    }
}
