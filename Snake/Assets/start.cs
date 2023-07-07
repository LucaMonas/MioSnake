using UnityEngine.SceneManagement;
using UnityEngine;

public class start : MonoBehaviour
{
  public void ChangeScene()
  {
    SceneManager.LoadScene("Snake");
  }
}
