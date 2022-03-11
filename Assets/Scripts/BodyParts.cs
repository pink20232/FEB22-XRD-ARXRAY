using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BodyParts : MonoBehaviour
{

    public Image iconbrain;
    public Image iconheart;

    // Start is called before the first frame update
    void Start()
    {
        iconbrain.color = new Color(1, 1, 1, 0.3f);
        iconheart.color = new Color(1, 1, 1, 0.3f);
    }

    public void OnBrainFound()
    {
        iconbrain.color = new Color(1, 1, 1, 1);
    }

    public void OnHeartFound()
    {
        iconheart.color = new Color(1, 1, 1, 1);
    }
}
