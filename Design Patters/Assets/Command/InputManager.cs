using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{
    [Header("Buttons")]
    [SerializeField] private Button upButton;
    [SerializeField] private Button LeftButton;
    [SerializeField] private Button RightButton;
    [SerializeField] private Button DownButton;
    [SerializeField] private Button RedoButton;
    [SerializeField] private Button UndoButton;

    [Header ("References")]
    [SerializeField] private PlayerMovement player;
    [SerializeField] private CommandInvoker commandInvoker;

    private void Awake()
    {
        commandInvoker = new CommandInvoker();

        upButton.onClick.AddListener(OnUpButtonClick);
        LeftButton.onClick.AddListener(OnLeftButtonClick);
        RightButton.onClick.AddListener(OnRightButtonClick);
        DownButton.onClick.AddListener(OnDownButtonClick);
        RedoButton.onClick.AddListener(RedoButtonClick);
        UndoButton.onClick.AddListener(UndoButtonClick);

    }
    public void RunPlayerCommand(PlayerMovement player, Vector3 movement)
    {
        if (player==null) { return; }

        ICommand command = new MoveCommand(player, movement);
        commandInvoker.ExecuteCommand(command);
    }
    public void OnLeftButtonClick()
    {
        RunPlayerCommand(player, Vector3.left);
    }
    public void OnRightButtonClick()
    {
        RunPlayerCommand(player, Vector3.right);
    }
    public void OnUpButtonClick()
    {
        RunPlayerCommand(player, Vector3.forward);
    }
    public void OnDownButtonClick()
    {
        RunPlayerCommand(player, Vector3.back);
    }
    public void UndoButtonClick()
    {
        commandInvoker.UndoCommand();
    }
    public void RedoButtonClick()
    {
        commandInvoker.RedoCommand();
    }
}
