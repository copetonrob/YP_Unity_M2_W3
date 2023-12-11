using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Webinar3Task2 : MonoBehaviour
{
    public float Speed = 3f;
	
    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(horizontal, 0f, vertical) * Time.deltaTime * Speed;

        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            transform.localScale = new Vector3(1f, 0.5f, 1f);
        }
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 clonePosition = transform.position + Random.insideUnitSphere * 3;
            clonePosition.y = 0;
            Instantiate(this.gameObject, clonePosition, Quaternion.identity);
        }
    }
}
