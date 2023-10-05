using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] private Transform target;
    private Vector3 offset;
    void Start()
    {
        offset = transform.position - target.position;
    }
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position,
        new Vector3(target.position.x, 1, target.position.z) + offset, Time.deltaTime * 4);
    }
}
