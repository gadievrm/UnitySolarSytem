using UnityEngine;
using System.Collections;
using Unity.VisualScripting;

public class RotateAround : MonoBehaviour {

	public float rotateSpeed, spinSpeed; // the speed of rotation
	public Transform sun;

    private void Start()
    {
        rotateSpeed /= 10;
        spinSpeed /= 10;
    }

    // Update is called once per frame
    void Update () {
		transform.RotateAround(sun.transform.position,sun.up,spinSpeed * Time.deltaTime);
		transform.RotateAround(transform.position,transform.up,rotateSpeed * Time.deltaTime);
	}

}

