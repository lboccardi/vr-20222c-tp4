using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallThrow : MonoBehaviour
{
    [SerializeField] private float _magnitude = 9F;

    void Start()
    {
        Vector3 vector = new Vector3(1, 2, 0).normalized;
        this.transform.GetComponent<Rigidbody>().AddForce(vector * _magnitude, ForceMode.Impulse);
        this.transform.GetComponent<Rigidbody>().AddTorque(vector * _magnitude * 0.01f, ForceMode.Impulse);
    }

}
