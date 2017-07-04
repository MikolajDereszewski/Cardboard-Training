using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBall : MonoBehaviour {

    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void ShootTheBall()
    {
        _rigidbody.AddForce(Camera.main.transform.forward * 2000f);
    }
}
