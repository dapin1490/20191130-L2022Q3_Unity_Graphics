using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
	public GameObject Pivot;

	//// isTrigger 체크 안 했을 때 쓰는 것
	//private void OnCollisionEnter(Collision collision)
	//{
	//	print(collision.gameObject.name);
	//}

	// isTrigger 체크 했을 때 쓰는 것
	private void OnTriggerEnter(Collider other)
	{
		print("Enter : " + other.gameObject.name);
		Pivot.GetComponent<Animator>().SetInteger("OD_State", 1);
	}

	private void OnTriggerExit(Collider other)
	{
		print("Exit : " + other.gameObject.name);
		Pivot.GetComponent<Animator>().SetInteger("OD_State", 2);
	}

	// Start is called before the first frame update
	void Start()
	{
		print("OD script start");
	}

	// Update is called once per frame
	void Update()
	{
		
	}
}
