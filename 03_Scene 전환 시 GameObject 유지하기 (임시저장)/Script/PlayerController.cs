using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public Camera mainCamera;
    private bool isJumping;

    // Update is called once per frame
    void Update()
    {
        // ← 이동
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += 5 * Vector3.left * Time.deltaTime;
            mainCamera.transform.position = new Vector3(transform.position.x, transform.position.y, mainCamera.transform.position.z);
        }
        // → 이동
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += 5 * Vector3.right * Time.deltaTime;
            mainCamera.transform.position = new Vector3(transform.position.x, transform.position.y, mainCamera.transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            GetComponent<Rigidbody2D>().AddForce(5 * Vector3.up, ForceMode2D.Impulse);
            mainCamera.transform.position = new Vector3(transform.position.x, transform.position.y, mainCamera.transform.position.z);
            isJumping = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Platform")
        {
            isJumping = false;
        }
    }
}
