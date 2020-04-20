using UnityEngine;

public class RemoveCup : MonoBehaviour {

	public SpawnBall reset;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
      
        if(other.gameObject.tag == "Ball")
        {
            Destroy(gameObject);
        }
    }


}
