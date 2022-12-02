using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.IO;
using System.Linq;

public class GameController : MonoBehaviour
{
    public AudioSource audioSource;
    public TextMeshProUGUI scoreText;
    public float score;
    string first, second, third;

    void Start()
    {
        score = 0f;
        audioSource.Play();
        StartCoroutine(Wait());

    }

    void Update()
    {
        score += Time.deltaTime;
        // Debug.Log(score);
        scoreText.text = score.ToString("0");
    }

    public void AdjustScore(float adjustment)
    {
        score += adjustment;
        Debug.Log("////////////////////////////////////Score: " + score);
    }
    
    public void Restart()
    {
        score = 0;
        Debug.Log("Game Restarted");
        scoreText.text = score.ToString("0");
    }

    
     void Read()
         {
             string path = "Assets/Leaderboard/leaderboard.txt";
             StreamReader reader = new StreamReader(path);
             first = reader.ReadLine();
             second = reader.ReadLine();
             third = reader.ReadLine();
             reader.Close();
         }

     public void WriteString()
     {
             Read();
             string path = "Assets/Leaderboard/leaderboard.txt";
             StreamWriter writer = new StreamWriter(path, false);
             string current = score.ToString("0");

             if(first == null)
             {
                 first = current;
             }else if(second == null)
             {
                 second = current;
             }else if(third == null)
             {
                 third = current;
             }else{
                 if(float.Parse(current)<float.Parse(first))
                 {
                     third = second;
                     second = first;
                     first = current;
                 }else if(float.Parse(current)<float.Parse(second))
                 {
                     third = second;
                     second = current;
                 }else if(float.Parse(current)<float.Parse(third))
                 {
                     third = current;
                 }
             }

             Debug.Log(first);
             Debug.Log(second);
             Debug.Log(third);
             writer.WriteLine(first);
             writer.WriteLine(second);
             writer.WriteLine(third);
             writer.Close();

         }
         IEnumerator Wait()
         {
             yield return new WaitForSeconds(180);
             WriteString();
                     Debug.Log("Game Started");
             SceneManager.LoadScene("MainMenu");
         }
}
