using UnityEngine;

public class TankItem : MonoBehaviour {

	private Rigidbody m_Rigidbody; 
	private Item m_CurrentItem;
	private TankHealth m_TankHealth;

	// Use this for initialization
	private void Awake()
	{
		m_Rigidbody = GetComponent<Rigidbody>();
		m_TankHealth = GetComponent <TankHealth> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider other) {
		if (other.gameObject.CompareTag ("Item")){
			other.gameObject.SetActive (false);
			m_TankHealth.Heal (200);
		}
	}
}
