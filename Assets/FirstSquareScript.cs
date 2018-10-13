using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstSquareScript : MonoBehaviour {
    UnityEngine.UI.Text scoreText;
    Rigidbody2D rb;
    BoxCollider2D bc;
    public int score = 0;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
        scoreText = GameObject.Find("UI/score").GetComponent<UnityEngine.UI.Text>();
        GameObject.Find("UI/gameOverPanel").SetActive(false);
    }

    void Update () {
        rb.velocity = new Vector2(0, transform.position.y);
        
        if (Input.GetKey(KeyCode.RightArrow)) {
            rb.velocity += Vector2.right * 5;
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            rb.velocity += Vector2.left * 5;
        }
        if (Input.GetKey(KeyCode.UpArrow)) {
            rb.velocity += Vector2.up * 5;
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            rb.velocity += Vector2.down * 5;
        }
        if (transform.position.y < -5 || transform.position.y > 5) {
            gameObject.SetActive(false);
            GameObject.Find("UI/gameOverPanel").SetActive(true);
        }
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "enemy") {
            //Destroy(gameObject, .0f); // destroy immediately
            gameObject.SetActive(false);
            GameObject.Find("UI/gameOverPanel").SetActive(true);
        } else if (collision.gameObject.tag == "food") {
            Transform foodTf = collision.gameObject.GetComponent<Transform>();
            Debug.Log(foodTf.position);
            score += (int) (Mathf.Pow(Mathf.Abs(foodTf.position.y), 3) * Mathf.Pow(foodTf.position.x + 8, 2));            
            scoreText.text = score.ToString(); 
            Destroy(collision.gameObject, 0f);
        }
    }
}
