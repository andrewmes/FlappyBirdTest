using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hi haha");

        GameObject gameObject = new GameObject("Pipe", typeof(SpriteRenderer));
        gameObject.GetComponent<SpriteRenderer>().sprite = GameAssets.GetInstance().pipeHeadSprite;
    }

}
