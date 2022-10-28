//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//using System;

//public class Piece : MonoBehaviour
//{
//    public enum Icons { none, heart, star, plant }
//    public Icons icon = Icons.none;

//    Start is called before the first frame update
//    void Start()
//    {
//        ChangeIconRandom();
//    }
//    void ChangeIconRandom()
//    {
//        int r = UnityEngine.Random.Range(1, 4);
//        var suits = Enum.GetValues(typeof(Icons));
//        Icons randIcon = (Icons)icon.GetValue(r);
//        ChangeIcons(randIcon);
//    }
//    Update is called once per frame
//    void ChangeIcons(Icons icon)
//    {
//        Image image = this.GetComponent<Image>();

//        Sprite heart = Resources.Load<Sprite>("Sprites/heart");
//        Sprite star = Resources.Load<Sprite>("Sprites/star");
//        Sprite egg = Resources.Load<Sprite>("Sprites/egg");



//        switch (icon)
//        {
//            case Icons.none:
//                break;
//            case Icons.heart:
//                Piece.GetComponent<Image>().sprite = heart;
//                break;
//            case Icons.star:
//                Piece.GetComponent<Image>().sprite = star;
//                break;
//            case Icons.plant:
//                Piece.GetComponent<Image>().sprite = egg;
//                break;
//            default:
//                break;
//        }
//    }
//}
