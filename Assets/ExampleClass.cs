using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour {
    public int pixWidth;
    public int pixHeight;
    public float xOrg;
    public float yOrg;
    public float scale = 1.0F;
    private Texture2D noiseTex;
    private Color[] pix;
    public bool iswater;
    private Renderer rend;
    void Start() {
        
        xOrg += Random.Range(0, 2); yOrg += Random.Range(0, 2);
        noiseTex = new Texture2D(pixWidth, pixHeight);
        pix = new Color[noiseTex.width * noiseTex.height];
        gameObject.GetComponent<SpriteRenderer>().sprite = Sprite.Create(noiseTex, new Rect(0, 0, noiseTex.width, noiseTex.height), Vector3.one / 2, 1);
        CalcNoise();
    }
    void CalcNoise() {
        float y = 0.0F;
        while (y < noiseTex.height) {
            float x = 0.0F;
            while (x < noiseTex.width) {
                float xCoord = xOrg + x / noiseTex.width * scale;
                float yCoord = yOrg + y / noiseTex.height * scale;
                float sample = Mathf.PerlinNoise(xCoord, yCoord);
                if (iswater)
                {


                    pix[Mathf.FloorToInt(y * noiseTex.width + x)] = new Color(0, 0, sample);
                }
                else
                    pix[Mathf.FloorToInt(y * noiseTex.width + x)] = new Color(sample, sample, sample);
                x++;
            }
            y++;
        }
        noiseTex.SetPixels(pix);
        noiseTex.Apply();
    }
    public static float heightScale = 1.0F;
    public static float xScale = 1.0F;
    public static void oo(Transform transform)
    {
        float height = heightScale * Mathf.PerlinNoise(Time.time * xScale, 0.0F);
        Vector3 pos = transform.position;
        pos.y += height;
        transform.position = pos;
        height += pos.y;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision != null)
        {
            ExampleClass.oo(collision.transform);
        }
    }

}