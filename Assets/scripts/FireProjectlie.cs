
using UnityEngine;

public class FireProjectlie : MonoBehaviour
//blev en mixup i namnen men det här borde heta ProjectileMovement igentligen
{

    private Vector3 mousePos;
    private Camera mainCam;
    private Rigidbody2D rb;
    public float force;




    void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>(); //finds camera

        rb = GetComponent<Rigidbody2D>(); // finds rigidbody of projectile

        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition); // finds and records mouse position

        Vector3 direction = mousePos - transform.position; // finds the direction you are pointing so that you can fire in the right direction

        Vector3 rotation = transform.position - mousePos; // finds rotation for the projectile based on direction you look

        rb.linearVelocity = new Vector2(direction.x, direction.y).normalized * force; // speed of projectile

        float rot = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg; // turns the vector into a float so that the next row works

        transform.rotation = Quaternion.Euler(0, 0, rot + 90); // rotates projectile


    }


}
