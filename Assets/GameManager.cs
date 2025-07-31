using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int score;
    int gold;
    int apples;

   [SerializeField] TextMeshProUGUI goldText;
   [SerializeField] TextMeshProUGUI applesText;
    public void MyFunction()
     {
        Debug.Log("Stuff happens");
     }

    public void AddScore() 
    {
        score += 1;
        Debug.Log("score:"+score);
        if (score >= 10) 
        {
            Debug.Log("we won the game");
        }
    }
    public void Addgold()
    {
        gold += 1;
        Debug.Log("Gold:"+ gold);
        goldText.text ="Gold : " + gold.ToString();
       
    }
    public void buyApple()
    {
        if (gold >= 5) 
        {
            Debug.Log("Bought Apple");
            apples += 1;
            gold -= 5;
            applesText.text = "Apples : "+ apples.ToString();
            goldText.text = "Gold : " + gold.ToString();
        }
        else
        {
            Debug.Log("sorry too poor TT");
        }
    }
}
