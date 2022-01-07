using System.Collections;
using UnityEngine;

public class EndTurnButton : MonoBehaviour
{

    public void OnClick()
    {
        TurnManager.Instance.EndTurn();
    }

}
