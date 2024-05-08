using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    internal enum updateMethod
    {
        fixedUpdate,
        update,
        lateUpdate
    }
    [SerializeField] private updateMethod updateDemo;

    

    
}
