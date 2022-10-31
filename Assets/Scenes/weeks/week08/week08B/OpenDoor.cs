using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
	public GameObject Pivot;

	//// isTrigger üũ �� ���� �� ���� ��
	//private void OnCollisionEnter(Collision collision)
	//{
	//	print(collision.gameObject.name);
	//}

	// isTrigger üũ ���� �� ���� ��
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
