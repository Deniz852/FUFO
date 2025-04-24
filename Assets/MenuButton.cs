using UnityEngine;

public class MenuButton : MonoBehaviour
{
    public GameObject Levels;
    public GameObject OldMenu;
    public void Menu()
    {
        OldMenu.SetActive(false);
        Levels.SetActive(true);
    }
}
