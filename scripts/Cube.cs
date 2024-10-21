using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cube : MonoBehaviour
{
    private int score = 0;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI bonusText;
    public delegate void CollisionMessage();
    public delegate void EggCollisionMessage(string name);
    //public static event CollisionMessage OnCollisionType1;
    //public static event CollisionMessage OnCollisionType2;
    //public static event CollisionMessage OnCollisionReference;
    public static event EggCollisionMessage OnCollisionEgg;

    void OnCollisionEnter(Collision collision)
    {
        /*if (collision.gameObject.tag == "type1")
        {
            ChangeRandomColor();
            OnCollisionType1?.Invoke();
        }
        else if (collision.gameObject.tag == "type2")
        {
            ChangeRandomColor();
            OnCollisionType2?.Invoke();
        }*/
        /*if (collision.gameObject.name = "Reference")
        {
            OnCollisionReference?.Invoke();
        }*/
        if (collision.gameObject.tag == "type1" && collision.gameObject.name.Contains("Egg") && !collision.gameObject.GetComponent<Egg>().IsDestroyed())
        {
            OnCollisionEgg?.Invoke(collision.gameObject.name);
            UpdateScore(5);
        }
        else if (collision.gameObject.tag == "type2" && collision.gameObject.name.Contains("Egg") && !collision.gameObject.GetComponent<Egg>().IsDestroyed())
        {
            OnCollisionEgg?.Invoke(collision.gameObject.name);
            UpdateScore(10);
        }
    }

    private void ChangeRandomColor()
    {
        Color color = new Color(Random.value, Random.value, Random.value);
        GetComponent<Renderer>().material.color = color;
    }

    private void UpdateScore(int value)
    {
        score += value;
        scoreText.text = "Puntuación: " + score;
        if (score >= 100)
        {
            bonusText.text = "¡Más velocidad!";
            bonusText.color = Color.red;
            bonusText.fontSize = 40;
            CubeMovement cubeMove = GetComponent<CubeMovement>();
            cubeMove.speed += 5;
        }
    }
}
