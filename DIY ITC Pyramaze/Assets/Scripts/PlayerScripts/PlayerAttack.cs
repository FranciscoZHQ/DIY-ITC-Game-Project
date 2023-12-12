using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject bullet;

    public GameObject firePoint;

    Animator animator;

    public bool fireRight;
    public bool fireLeft;
    public bool fireBackward;
    public bool fireForward;

    public float bulletForce = 1500.0f;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("HasGun", true);
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        if (horizontalInput > 0 && verticalInput == 0)
        {
            fireRight= true;
            fireLeft = false;
            fireBackward= false;
            fireForward= false;
        }
        else if (horizontalInput< 0 && verticalInput == 0)
        {
            fireRight= false;
            fireLeft= true;
            fireBackward = false;
            fireForward = false;
        }
        else if (horizontalInput == 0 && verticalInput > 0)
        {
            fireRight = false;
            fireLeft= false;
            fireBackward = true;
            fireForward = false;
        }
        else if (horizontalInput == 0 && verticalInput < 0)
        {
            fireRight = false;
            fireLeft= false;
            fireBackward = false;
            fireForward = true;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("AttackLeft");
            animator.SetTrigger("AttackRight");
            animator.SetTrigger("AttackBackward");
            animator.SetTrigger("AttackForward");
            FireBullet();
        }
    }

    private void FireBullet()
    {
        GameObject newBullet = Instantiate(bullet, firePoint.transform.position, firePoint.transform.rotation) as GameObject;

        Rigidbody2D tempRigidbody = newBullet.GetComponent<Rigidbody2D>();

        if (fireRight)
        {
            tempRigidbody.AddForce(transform.right * bulletForce);
        }
        if (fireLeft)
        {
            tempRigidbody.AddForce(-transform.right * bulletForce);
        }
        if (fireBackward)
        {
            tempRigidbody.AddForce(transform.up * bulletForce);
        }
        if (fireForward)
        {
            tempRigidbody.AddForce(-transform.up * bulletForce);
        }

        Destroy(newBullet, 2.0f);
    }
}
