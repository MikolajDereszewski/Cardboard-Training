using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldPointer : MonoBehaviour {

    private Camera _cameraMain;
    private Vector3 _cameraPosition;
    private Renderer _renderer;

	void Start ()
    {
        _cameraMain = Camera.main;
        _cameraPosition = _cameraMain.transform.position;
        _renderer = GetComponent<Renderer>();
    }
	
	void Update ()
    {
        RaycastHit hitInfo;
		if(Physics.Raycast(_cameraPosition, _cameraMain.transform.forward, out hitInfo))
        {
            transform.rotation = Quaternion.LookRotation(hitInfo.normal);
            transform.position = hitInfo.point + hitInfo.normal * 0.01f;
            _renderer.enabled = true;
        }
        else
        {
            _renderer.enabled = false;
        }
	}
}
