using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodCreator : MonoBehaviour {
    int counter = 0;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        counter++;

        if (Random.value < 0.01f) {
            GameObject food = new GameObject("food");
            Transform tf = food.GetComponent<Transform>();
            tf.localScale = new Vector2(0.25f, 0.25f);
            tf.position = new Vector2(10, (Random.value - 0.5f) * 8);
            SpriteRenderer sr = food.AddComponent(typeof(SpriteRenderer)) as SpriteRenderer;
            sr.sprite = Resources.Load<Sprite>("FoodSquare");
            sr.color = new Color(0.8f, 0.7f, 0.3f);
            Rigidbody2D rb = food.AddComponent(typeof(Rigidbody2D)) as Rigidbody2D;
            rb.velocity = Vector2.left * 6.6f;
            rb.gravityScale = (Random.value - 0.5f) * 0.2f;
            BoxCollider2D bc = food.AddComponent(typeof(BoxCollider2D)) as BoxCollider2D;
            food.tag = "food";
        }
    }
}
