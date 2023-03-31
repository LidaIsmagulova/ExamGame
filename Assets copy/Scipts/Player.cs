using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Animator animator;
    private Rigidbody rigidbody;
    public float rotationSpeed=10f;
    public float speed=2f;
    public int coins;
    public Text TextCoins;
    private AudioSource audioCoins;

     
  
    void Start()
    {
      
        animator=GetComponent<Animator>();
        rigidbody=GetComponent<Rigidbody>();
        audioCoins=GetComponent<AudioSource>();
      
    }

  
    void Update()
    {
     
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
      


        

        Vector3 directionVector=new Vector3(-v,0,h);
        if(directionVector.magnitude> Mathf.Abs( 0.05f))
        transform.rotation=Quaternion.Lerp(transform.rotation,Quaternion.LookRotation(directionVector),Time.deltaTime * rotationSpeed);

        animator.SetFloat("speed",Vector3.ClampMagnitude(directionVector,1).magnitude);
        rigidbody.velocity = Vector3.ClampMagnitude(directionVector,1) * speed;
   
    }

   

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Coin")
        {
            coins++;
            other.gameObject.SetActive(false);
            TextCoins.text=coins.ToString();
            audioCoins.Play();
           
        }
    }
}
