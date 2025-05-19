using JetBrains.Annotations;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigidbody; // 이동에 사용할 리지드 바디 컴포넌트
    public float speed = 8f; // 이동속력
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     playerRigidbody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");
        //
       
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        Vector3 newVelocity = new Vector3 (xSpeed,0f,zSpeed);

        playerRigidbody.linearVelocity= newVelocity;

    }
    public void Die()
    {
        gameObject.SetActive(false);
    }
}
