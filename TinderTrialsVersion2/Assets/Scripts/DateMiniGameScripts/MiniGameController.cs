using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGameController : MonoBehaviour
{
    public GameObject NodePrefab;

    private RectTransform _rectTransform;

    // Start is called before the first frame update
    void Start()
    {
        _rectTransform = this.GetComponent<RectTransform>();
        CreateNodes();
    }
    void CreateNodes()
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                GameObject node = Instantiate(NodePrefab);
                node.transform.SetParent(this.transform);
                Vector2 pos = new Vector2(i * 200, j * -200);
                node.GetComponent<RectTransform>().anchoredPosition = pos;
                node.transform.localScale = Vector3.one;
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
