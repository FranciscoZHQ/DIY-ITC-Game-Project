using UnityEngine;
using UnityEngine.UI;

public class SpiderealthBarFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(0f, 1f, 0f);
    //public SpiderHealthBar enemyHealthBar;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = target.position + offset;
        transform.position = targetPosition;
    }
}
