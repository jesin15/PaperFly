using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class flycontroller : MonoBehaviour
{
    Rigidbody2D flybody;
    float velocity;
    public Sprite dead;
    public bool isalive;

    [SerializeField] float jumpforce=7f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            flybody = GetComponent<Rigidbody2D>();
            flybody.velocity = new Vector2(0, jumpforce);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = dead;
        SceneManager.LoadScene(2);
       
        
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        score.scorevalue++;
    }
}
