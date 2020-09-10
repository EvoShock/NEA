using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AAAAAAAAAAAAAA : MonoBehaviour
{
    public float speed = 4f;
    public Rigidbody rb;
    public GameObject character;
    public int jumpsTaken = 0;
    public bool crouching = false;
    public bool InWater = false;
    public int LevelCounting = 1;

    void Update()
    {

        if (Input.GetKey("down"))
        {
            rb.velocity = new Vector3(-1 * speed, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey("up"))
        {
            rb.velocity = new Vector3(1 * speed, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey("left"))
        {
            rb.velocity = new Vector3(0, 0, 1 * speed) * Time.deltaTime;
        }
        if (Input.GetKey("right"))
        {
            rb.velocity = new Vector3(0, 0, -1 * speed) * Time.deltaTime;
        }

        if (jumpsTaken == 0 && Input.GetKeyDown("space") && crouching == false)
        {
            rb.velocity = new Vector3(0, 1 * speed, 0) * Time.deltaTime;
            jumpsTaken++;
        }
        if (InWater && Input.GetKeyDown("space"))
        {
            rb.velocity = new Vector3(0, 1 * speed, 0) * Time.deltaTime;
        }
        if (Input.GetKey("left shift"))
        {
            character.transform.localScale = new Vector3(0.5f, 0.25f, 0.5f) * Time.deltaTime;
            speed = 2f;
            crouching = true;
        }
        if (Input.GetKeyUp("left shift"))
        {
            character.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f) * Time.deltaTime;
            speed = 4f;
            crouching = false;
        }
        if (InWater)
            speed = 3f;
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "GroundTag" || col.gameObject.tag == "Underwater")
        {
            jumpsTaken = 0;
        }
        if (col.gameObject.tag == "WallTag")
        {
            rb.velocity = new Vector3(0, 0, 0);
        }
        if (col.gameObject.name == "Temp_Flag")
        {
            string LevelStartSelect = "Level ";
            string LevelCountingString;
            string NextLevel;
            LevelCounting += 1;
            LevelCountingString = LevelCounting.ToString();
            NextLevel = LevelStartSelect + LevelCountingString;
            Debug.Log(NextLevel);

            SceneManager.LoadScene(NextLevel, LoadSceneMode.Single);
        }
        if (col.gameObject.tag == "Enemy")
        {
            transform.position = new Vector3(1, 0.25f, -4);
        }
        if (col.gameObject.tag == "Underwater")
        {
            InWater = true;
        }
    }

    private void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "Underwater")
        {
            InWater = false;
        }
    }
}