using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update


    public float turnSpeed = 4.0f;
	public Transform player;

	private Vector3 offset;

	void Start () {
		offset = new Vector3(player.position.x, player.position.y + 20.0f, player.position.z - 27.0f);
	}

	void LateUpdate()
	{
		offset = Quaternion.AngleAxis (Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * offset;
		transform.position = player.position + offset; 
		transform.LookAt(player.position);
	}
}