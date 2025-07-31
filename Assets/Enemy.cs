using UnityEngine;
using TMPro;
public class Enemy : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI EnemyHPText;
    [SerializeField] int hp;
    
    public void TakeDamage()
    {
        hp -= 1;
        if (hp <= 0)
        {
            Debug.Log("Enemy Dead");
        }
        EnemyHPText.text ="Enemy HP : " + hp.ToString();
    }
    public void Heal()
    {
        hp += 1;
        EnemyHPText.text = "Enemy HP : " + hp.ToString();
    }
}
