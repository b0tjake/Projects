using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameFlowFacade facade;

    public void OnRestartClicked()
    {
        facade.RestartGame();
    }
}