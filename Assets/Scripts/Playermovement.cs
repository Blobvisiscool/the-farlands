using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public float movespeed1;
    public float movespeed2;

    private float realspeed;

    public Sprite left;
    public Sprite right;


    // Start is called before the first frame update
    void Start()
    {
        realspeed = movespeed1;
    }

    // Update is called once per frame
    void Update()
    {
      

            Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical") , 0).normalized;
         

            transform.Translate(movement * realspeed * Time.deltaTime);
        
    }
 
}
