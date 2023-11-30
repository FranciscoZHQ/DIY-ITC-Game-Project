using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkeletonMerch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject gameObject;

    public GameObject gameObject2;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(true);

            //gameObject2.SetActive(false);

            //collision.gameObject.transform.Translate(new Vector3(50, 0, 0));

            collision.gameObject.transform.position = new Vector3(10000, 10000, 0);

            collision.gameObject.GetComponent<TopDownPlayer>().playerMove = false;
        }
    }
}
