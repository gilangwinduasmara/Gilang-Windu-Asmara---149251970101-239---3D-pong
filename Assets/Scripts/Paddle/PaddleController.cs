using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public Vector3 leftDirection;
    public Vector3 rightDirection;

    public KeyCode leftKey;

    public KeyCode rightKey;

    public float speed;

    public PlayerController player;

    public Color color = Color.white;
    // Start is called before the first frame update
    void Start()
    {
        if (color != null)
        {
            SetColor(color);
        }
    }

    // Update is called once per frame
    void Update()
    {
        bool isAlive = !player.scoreController.IsReachMaxScore();
        if (isAlive)
        {
            Vector3 movement = Vector3.zero;
            if (Input.GetKey(leftKey))
            {
                movement += leftDirection * speed;
            }
            if (Input.GetKey(rightKey))
            {
                movement += rightDirection * speed;
            }

            transform.position += movement * Time.deltaTime;
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, 20f, transform.position.y), 10f * Time.deltaTime);
            // rotate forever
            transform.Rotate(Vector3.up, Time.deltaTime * 100f);
        }
    }

    private void OnDrawGizmos()
    {
        if (color != null)
        {
            SetColor(color);
        }
    }

    public void SetColor(Color color)
    {
        
        GetComponent<Renderer>().sharedMaterial.color = color;
    }
}
