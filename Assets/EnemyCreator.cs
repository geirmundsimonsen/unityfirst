using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCreator : MonoBehaviour {
    int counter = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        counter++;

        if (Random.value < 0.005f) {
            GameObject enemy = new GameObject("enemy");
            Transform tf = enemy.GetComponent<Transform>();
            tf.localScale = new Vector2(1.25f, 1.25f);
            tf.position = new Vector2(10, (Random.value - 0.5f) * 8);
            SpriteRenderer sr = enemy.AddComponent(typeof(SpriteRenderer)) as SpriteRenderer;
            sr.sprite = Resources.Load<Sprite>("EnemySquare");
            sr.color = new Color(0.2f, 0.7f, 0.1f);
            Rigidbody2D rb = enemy.AddComponent(typeof(Rigidbody2D)) as Rigidbody2D;
            rb.velocity = Vector2.left * 10;
            rb.gravityScale = (Random.value - 0.5f) * 0.2f;
            BoxCollider2D bc = enemy.AddComponent(typeof(BoxCollider2D)) as BoxCollider2D;
            enemy.tag = "enemy";
        }
	}
}
