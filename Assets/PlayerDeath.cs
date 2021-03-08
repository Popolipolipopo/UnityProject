using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public GameObject safePlatform;

/*    private float timer = 0;

    private bool clockHasStarted = false;


    private void Update()
    {
        if (clockHasStarted)
            timer += Time.deltaTime;

        timer += Time.deltaTime;

    }
*/
    private void OnTriggerEnter(Collider other)
    {
/*        if (timer < 1)
        {

        } else
        {
*/
        other.transform.position = new Vector3(0, 1, 0);
        Instantiate(safePlatform, new Vector3(transform.position.x, transform.position.y + transform.localScale.y, transform.position.z), Quaternion.identity);
/*        }
*/    }

}
