using UnityEngine;

public class ChangeScenes : MonoBehaviour
{
    public void ChangeScenceToMirror()
    {
        Main.Instance.GoMirror();
    }

    public void ChangeScenceToGame()
    {
        Main.Instance.GoET_lighting();
    }

    public void ChangeScenceToCalibration()
    {
        Main.Instance.GoCalibration();
    }

    public void ChangeScenceToCoordinates()
    {
        Main.Instance.GoCoordinates();
    }
}
