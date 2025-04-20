## StateDrivenCharacter

사용한 캐릭터 에셋 : 
<a href="https://rvros.itch.io/animated-pixel-hero">https://rvros.itch.io/animated-pixel-hero</a>

### 2025/04/18
<b>방향키</b> : W,D
<b>점프키</b> : Space <br>
<b>Input System</b>을 사용하여 움직임을 구현<br><b>달리기 애니메이션</b> : SetFloat를 사용하여 2D 방향 입력 벡터의 절대값이 0.01보다 크면 애니메이션이 작동을 하고 0.01보다 작으면 Idle상태로 돌아간다<br>
<b>점프 애니메이션</b> : SetBool를 사용하여 Space키를 누르면 bool jump가 true가 되어 애니메이션이 작동, 점프를 한 후에 지면에 닿아 충돌이 발생되면 false로 변하여 Idel상태로 돌아간다,<br>

<p>

  ![run_jump](https://github.com/NekoDevPixel/StateDrivenCharacter/blob/main/Assets/explay/run_jump.gif?raw=true)
</p>
<p>
  <b>앉기 애니메이션</b> : C키를 ON/OFF형식으로 SetBool형식으로 작동<br>
  <b>슬라이딩 애니메이션</b> : SetBool형식으로 Shift키가 KeyDown되면 작동 KeyUp되면 해제<br>
  
  ![slide_sit](https://github.com/NekoDevPixel/StateDrivenCharacter/blob/main/Assets/explay/slide_sit.gif?raw=true)
</p>
<p>
  <b>기본 공격 애니메이션</b> : 마우스 왼쪽클릭으로 총 공격애니메이션은 세개로 클릭당 공격1,공격2,공격3순으로 애니메이션이 작동, 마우스 클릭 후에 다음 공격으로 넘어가지않으면 다시 Idle상태로 돌아간다<br>
  
  ![basic_attack](https://github.com/NekoDevPixel/StateDrivenCharacter/blob/main/Assets/explay/basic_attack.gif?raw=true)
</p>
