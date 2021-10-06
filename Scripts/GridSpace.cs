using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridSpace : MonoBehaviour
{
    private GameController gameController;
  public Button button;
  public Text buttonText;
 
   public void SetGameControllerReference(GameController controller)
  {
      gameController=controller;
  }
  public void SetSpace()
  {
      buttonText.text=gameController.GetPlayerSide();
      button.interactable=false;
      gameController.EndTurn();

  }
 
}
