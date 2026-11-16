using UnityEngine;

public class ammoCollection : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
         //mouse key to shoot ammo
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0.0f));
            RaycastHit result;
            Physics.Raycast(ray, out result);

            GameObject g = result.collider.gameObject;
            Animation a = g.transform.parent.GetComponent<Animation>();
            a.Play("LowerBridge");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        //ammoCollection ammo = GetComponent<ammoCollection>();
        other.gameObject.SetActive(false);
    }
}
