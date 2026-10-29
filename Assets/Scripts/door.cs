using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //trigger to have the door open
    void OnTriggerEnter(Collider other)
    {
        GameObject parent = transform.parent.gameObject;
        Animation animation = parent.GetComponent<Animation>();
        animation.Play("OpenDoor");
    }

    void OnTriggerExit(Collider other)
    {
        GameObject parent = transform.parent.gameObject;
        Animation animation = parent.GetComponent<Animation>();
        animation.Play("Close");
    }
}
