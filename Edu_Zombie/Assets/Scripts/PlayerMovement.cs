using UnityEngine;

// 플레이어 캐릭터를 사용자 입력에 따라 움직이는 스크립트
public class PlayerMovement : MonoBehaviour {
    public float moveSpeed = 5f; // 앞뒤 움직임의 속도
    public float rotateSpeed = 180f; // 좌우 회전 속도

    private PlayerInput playerInput; // 플레이어 입력을 알려주는 컴포넌트
    private Rigidbody playerRigidbody; // 플레이어 캐릭터의 리지드바디
    private Animator playerAnimator; // 플레이어 캐릭터의 애니메이터

    private void Start() {
        // 사용할 컴포넌트들의 참조를 가져오기
        playerInput = GetComponent<PlayerInput>();
        playerRigidbody = GetComponent<Rigidbody>();
        playerAnimator = GetComponent<Animator>();
    }

    // FixedUpdate는 물리 갱신 주기에 맞춰 실행됨
    private void FixedUpdate() {
        Move();
        Rotate();
        // 물리 갱신 주기마다 움직임, 회전, 애니메이션 처리 실행
    }

    // 입력값에 따라 캐릭터를 앞뒤로 움직임
    private void Move() {
        float moveDistance = playerInput.keyInput_z * moveSpeed * Time.deltaTime;
        print(moveDistance);
        playerRigidbody.MovePosition(transform.position + transform.forward * moveDistance);
        // playerRigidbody.MovePosition(transform.position + transform.forward * moveDistance);
        playerAnimator.SetFloat("Move", moveDistance * 10);
        //Vector3 dir = new Vector3(playerInput.KEYINPUT_X, 0, playerInput.KEYINPUT_Z);
        //dir = Camera.main.transform.TransformDirection(dir);
        //dir.Normalize();
        //playerRigidbody.MovePosition(transform.position + dir * moveSpeed * Time.deltaTime);
    }

    // 입력값에 따라 캐릭터를 좌우로 회전
    private void Rotate() {
        float turnY = playerInput.keyInput_x * rotateSpeed * Time.deltaTime;
        playerRigidbody.rotation *= Quaternion.Euler(0, turnY, 0);
    }
}