using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ray : MonoBehaviour
{
    public float boom_Amt;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit = new RaycastHit();
        Debug.DrawRay(laser.origin, laser.direction, Color.green);
        if (Physics.Raycast(laser, out hit, 1000f) && Input.GetMouseButton(0))
        {
            if (hit.rigidbody) { hit.rigidbody.AddForce(Random.insideUnitSphere * boom_Amt); }
            Debug.Log("you hit something ..." + hit.transform.gameObject.name);

        }

    }
}
