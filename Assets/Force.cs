using UnityEngine;

public class Force : MonoBehaviour
{
	public float thrust;
	public Rigidbody rb;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
		rb.AddForce(new Vector3(5,20,5) * thrust);
	}

	void FixedUpdate()
	{
	}
}