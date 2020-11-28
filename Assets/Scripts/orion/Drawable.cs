using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawable : MonoBehaviour
{
    Texture2D stamp;
    Texture2D background;
    Texture2D output;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Draw(Vector2 position)
    {
        output = new Texture2D(background.width, background.height);

        Vector2Int xy = new Vector2Int(output.width, output.height);
        while (xy.x > 0)
        {
            xy.x--;
            xy.y = output.height;
            while (xy.y > 0)
            {
                xy.y--;
                if (xy.x + position.x < background.width && xy.y + position.y < background.height)
                {
                    Color ca = stamp.GetPixel(xy.x, xy.y);
                    Color cb = background.GetPixel(xy.x + (int)position.x, xy.y + (int)position.y);
                    float a = ca.a;
                    float r = (ca.r * a) + (cb.r * (1 - a));
                    float g = (ca.g * a) + (cb.g * (1 - a));
                    float b = (ca.b * a) + (cb.b * (1 - a));

                    output.SetPixel(xy.x + (int)position.x, xy.y + (int)position.y, new Color(r, g, b, 1));
                }
            }
        }

        output.Apply();
    }
}
