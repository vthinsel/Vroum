using UnityEngine;

public class scrolling : MonoBehaviour
{
    [Range(0.0f, 3f)]
    [SerializeField]
    float speed = 1f;
    Renderer rend;
    float offset;
    void Start()
    {
        rend = GetComponent<Renderer>();
        //offset = 0;
        //speed = 1f;
    }

    void Update()
    {
        //Vector2 vecoffset;
        offset += (Time.deltaTime * speed);
        //Debug.Log(offset + " " + Time.deltaTime + " "+ speed);
        //rend.material.SetTextureOffset("_MainTex", new Vector2(0, offset));
        rend.material.mainTextureOffset = new Vector2(0, -offset);
    }
}
