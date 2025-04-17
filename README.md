## StateDrivenCharacter

사용한 캐릭터 에셋 : 
<a href="https://rvros.itch.io/animated-pixel-hero">https://rvros.itch.io/animated-pixel-hero</a>

### 2025/04/18
<b>방향키</b> : W,D
<b>점프키</b> : Space <br>
<b>Input System</b>을 사용하여 움직임을 구현<br><b>달리기 애니메이션</b> : SetFloat를 사용하여 2D 방향 입력 벡터의 절대값이 0.01보다 크면 애니메이션이 작동을 하고 0.01보다 작으면 Idle상태로 돌아간다<br>
<b>점프 애니메이션</b> : SetBool를 사용하여 Space키를 누르면 bool jump가 true가 되어 애니메이션이 작동, 점프를 한 후에 지면에 닿아 충돌이 발생되면 false로 변하여 Idel상태로 돌아간다
<p>

  <img src="https://s8.ezgif.com/tmp/ezgif-89a586db1ef97b.gif">  
</p>
