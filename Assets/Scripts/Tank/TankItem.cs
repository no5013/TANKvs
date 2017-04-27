using UnityEngine;

public class TankItem : MonoBehaviour {

	private Rigidbody m_Rigidbody; 

	// Use this for initialization
	private void Awake()
	{
		m_Rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider other) {
		if (other.gameObject.CompareTag ("Item")){
			other.gameObject.SetActive (false);
		}
	}
}
