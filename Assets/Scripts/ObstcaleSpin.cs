using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPINNNNN : MonoBehaviour
{
    [SerializeField] Transform _obstacle;
    [SerializeField] float _spinSpeed = 0.5f;
    Vector3 _spinVector;

    private void OnValidate()
    {
        _obstacle = GetComponent<Transform>();
    }

    private void Start()
    {
        _spinVector = _obstacle.rotation.eulerAngles;
        _spinVector.y += _spinSpeed;
    }
    // Update is called once per frame
    void Update()
    {
        _obstacle.Rotate(_spinVector);
    }
}
