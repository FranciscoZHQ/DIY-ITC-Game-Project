using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor.Recorder;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class SkeletonMerch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ranATK = Random.Range(1, 4);
    }

    public GameObject gameObject;
    public GameObject gameObject2;

    public UnityEngine.UI.Image gun;
    public UnityEngine.UI.Image whip;
    public UnityEngine.UI.Image sword;

    public bool setWeapon = true;
    
    public int ranATK;

    

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

            if (setWeapon)
            {
                setWeapon = false;
                if (ranATK == 1)
                {
                    gun.enabled = true;
                    whip.enabled = false;
                    sword.enabled = false;
                }
                if (ranATK == 2)
                {
                    gun.enabled = false;
                    whip.enabled = true;
                    sword.enabled = false;
                }
                if (ranATK == 3)
                {
                    gun.enabled = false;
                    whip.enabled = false;
                    sword.enabled = true;
                }
            }
        }
    }
}
