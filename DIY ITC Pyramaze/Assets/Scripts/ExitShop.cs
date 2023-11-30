using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitShop : MonoBehaviour
{

    public GameObject gameObject;
    public void LeaveShop()
    {
        //gameObject.transform.Translate(new Vector3(-48, 0, 0));

        gameObject.transform.position = new Vector3(23, 21, 0);

        gameObject.GetComponent<TopDownPlayer>().playerMove = true;
    }
}
