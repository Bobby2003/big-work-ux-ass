using UnityEngine;
using UnityEngine.SceneManagement; // ���볡������

public class SceneController : MonoBehaviour
{
    // �л���ָ������
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName); // ���ݳ������Ƽ��س���
    }
}
