
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playercollision : MonoBehaviour
{
   
    public GameObject gameOverScreen;

    private void Start()
    {
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag =="Enemys")
        {
            gameOver();
        }
}
     
     public void gameOver()
     {
         gameOverScreen.SetActive(true);
     }
}
