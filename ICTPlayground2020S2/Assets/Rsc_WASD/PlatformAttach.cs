using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformAttach : MonoBehaviour
{
	public GameObject Player; 
private void OnTrigerEnter(Collider other)
{
	if(other.gameObject == Player)
	{
		Player.transform.parent = transform;
	}
}
private void OnTrigerExit(Collider other)
{
	if(other.gameObject == Player)
	{
		Player.transform.parent = null;
	}
}

}
