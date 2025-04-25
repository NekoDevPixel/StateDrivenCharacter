# 🎮 StateDrivenCharacter

## 🧍 사용한 캐릭터 에셋

- [Animated Pixel Hero by rvros](https://rvros.itch.io/animated-pixel-hero)

---

## 🛠️ 2025/04/18 개발 기능

### 🎮 기본 조작

- **이동 키**: `W`, `D`  
- **점프 키**: `Space`  
- **앉기 키**: `C` (토글 형식)  
- **슬라이딩 키**: `Shift` (KeyDown → 활성화, KeyUp → 해제)  
- **공격**: 마우스 왼쪽 클릭 (총 3단계 연속 공격)  

---

### 🎞️ 애니메이션 동작 설명

#### 🏃‍♂️ 달리기 & 점프

- `Input System`을 사용하여 움직임 구현  
- **달리기 애니메이션**:  
  `SetFloat` → 입력 벡터의 절대값이 `0.01`보다 크면 실행  
  작으면 Idle 상태로 복귀  
- **점프 애니메이션**:  
  `SetBool` → `Space` 키 누르면 `jump = true`  
  지면에 충돌 시 `jump = false`  

![run_jump](https://github.com/NekoDevPixel/StateDrivenCharacter/blob/main/Assets/explay/run_jump.gif?raw=true)

---

#### 🧎‍♂️ 앉기 & 슬라이딩

- **앉기 애니메이션**:  
  `SetBool`을 사용, `C` 키로 ON/OFF 전환  
- **슬라이딩 애니메이션**:  
  `Shift` KeyDown 시 `SetBool = true`, KeyUp 시 `false`  

![slide_sit](https://github.com/NekoDevPixel/StateDrivenCharacter/blob/main/Assets/explay/slide_sit.gif?raw=true)

---

#### 🔫 기본 공격

- 마우스 왼쪽 클릭으로 3단계 공격 애니메이션 실행  
- 클릭당 `공격1 → 공격2 → 공격3`  
- 연속 입력이 없으면 Idle 상태로 복귀  

![basic_attack](https://github.com/NekoDevPixel/StateDrivenCharacter/blob/main/Assets/explay/new_attack.gif?raw=true)

---

#### 🧗 암벽등반

- 플레이어가 **암벽 트리거에 접촉**하고  
  `W`, `S` 키로 위치 변화가 있을 때  
  **등반 애니메이션** 실행  
- KeyUp 시 → 정지한 등반 모션 실행  

![climb](https://github.com/NekoDevPixel/StateDrivenCharacter/blob/main/Assets/explay/climb.gif?raw=true)
