using System;
using UnityEngine;

// 플레이어 캐릭터를 조작하기 위한 사용자 입력을 감지
// 감지된 입력값을 다른 컴포넌트들이 사용할 수 있도록 제공
public class PlayerInput : MonoBehaviour {

    public float keyInput_x { get; private set; }
    public float keyInput_z { get; private set; }
    public bool keyInput_fire1 { get; private set; }
    public bool keyInput_jump { get; private set; }
    public bool keyInput_reload { get; private set; }
    public float mouseInput_x { get; private set; }
    public float mouseInput_y { get; private set; }



    // 매프레임 사용자 입력을 감지
    private void Update() {

        // 게임오버 상태에서는 사용자 입력을 감지하지 않는다
        if (GameManager.instance != null && !GameManager.instance.isGameover)
        {


        }

        keyInput_x = Input.GetAxis("Horizontal");
        keyInput_z = Input.GetAxis("Vertical");
        keyInput_jump = Input.GetButtonDown("Jump");
        keyInput_fire1 = Input.GetButtonDown("Fire1");
        keyInput_reload = Input.GetButtonDown("Reload");

        mouseInput_x = Input.GetAxis("Mouse X");
        mouseInput_y = Input.GetAxis("Mouse Y");

    }
}