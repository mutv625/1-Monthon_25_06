using System;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public enum FighterControl
{
    MoveLeft,
    MoveRight,
    Jump,
    Attack,
    Block
}

public class InputProvider : MonoBehaviour
{
    [SerializeField] private List<KeyCode> P1InputKeys;
    [SerializeField] private List<KeyCode> P2InputKeys;

    // ! 入力による操作イベント

    float p1MoveInputValue;
    float p2MoveInputValue;

    private static Subject<(int,float)> _onMoveKey = new();
    public static IObservable<(int,float)> OnMoveKey => _onMoveKey;

    private static Subject<(int,Unit)> _onJumpKeyDown = new();
    public static IObservable<(int,Unit)> OnJumpKeyDown => _onJumpKeyDown;

    private static Subject<(int,Unit)> _onAttackKeyDown = new();
    public static IObservable<(int,Unit)> OnAttackKeyDown => _onAttackKeyDown;

    private static Subject<(int,Unit)> _onBlockKeyDown = new();
    public static IObservable<(int,Unit)> OnBlockKeyDown => _onBlockKeyDown;

    public void AcceptInput()
    {
            // * Player 1 controls
            p1MoveInputValue = 0f;
            if (Input.GetKey(P1InputKeys[(int)FighterControl.MoveLeft]))
            {
                p1MoveInputValue += -1f;
            }
            if (Input.GetKey(P1InputKeys[(int)FighterControl.MoveRight]))
            {
                p1MoveInputValue += 1f;
            }

            _onMoveKey.OnNext((1, p1MoveInputValue));


            if (Input.GetKeyDown(P1InputKeys[(int)FighterControl.Jump]))
            {
                _onJumpKeyDown.OnNext((1, Unit.Default));
            }

            if (Input.GetKeyDown(P1InputKeys[(int)FighterControl.Attack]))
            {
                _onAttackKeyDown.OnNext((1, Unit.Default));
            }

            if (Input.GetKeyDown(P1InputKeys[(int)FighterControl.Block]))
            {
                _onBlockKeyDown.OnNext((1, Unit.Default));
            }


            // * Player 2 controls
            p2MoveInputValue = 0f;
            if (Input.GetKey(P2InputKeys[(int)FighterControl.MoveLeft]))
            {
                p2MoveInputValue -= 1f;
            }
            if (Input.GetKey(P2InputKeys[(int)FighterControl.MoveRight]))
            {
                p2MoveInputValue += 1f;
            }

            _onMoveKey.OnNext((2, p2MoveInputValue));


            if (Input.GetKeyDown(P2InputKeys[(int)FighterControl.Jump]))
            {
                _onJumpKeyDown.OnNext((2, Unit.Default));
            }

            if (Input.GetKeyDown(P2InputKeys[(int)FighterControl.Attack]))
            {
                _onAttackKeyDown.OnNext((2, Unit.Default));
            }

            if (Input.GetKeyDown(P2InputKeys[(int)FighterControl.Block]))
            {
                _onBlockKeyDown.OnNext((2, Unit.Default));
            }
    }
}

