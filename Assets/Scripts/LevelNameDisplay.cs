using UnityEngine;
using UnityEngine.UI;

public class LevelNameDisplay : MonoBehaviour
{
    public Text nameText;

    public void Start()
    {
        Destroy(nameText, 1);
    }
}
