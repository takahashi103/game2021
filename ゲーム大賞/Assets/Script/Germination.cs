using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Germination : MonoBehaviour
{
    public GameObject plant;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {

            GameObject plants = Instantiate(plant);
            plants.transform.position = new Vector3(this.transform.position.x, this.transform.position.y+0.9f , this.transform.position.z);
            plants.transform.eulerAngles = new Vector3(0, 0, 0);
            Destroy(this.gameObject);
        }
   
    }
}
