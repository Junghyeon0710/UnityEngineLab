# 유니티 설치방법

Unity Hub로 Unity Editor를 설치하는 과정을 정리한다. Hub는 여러 Editor 버전을 관리하는 런처이고, Editor는 게임을 개발하는 프로그램이다.

**Hub 설치 → 계정 생성·로그인 → Editor 버전 선택 → 플랫폼·언어 선택 → 설치 완료 확인** 순서로 진행한다.

사진은 Unity 공식 문서의 예시 화면이다. 사진 속 버전과 운영체제는 예시이며, Hub 버전에 따라 메뉴 이름이나 위치가 달라질 수 있다.

<a id="contents"></a>

## 목차

1. [Unity Hub 설치](#hub-install)
2. [계정 생성과 로그인](#account)
3. [Editor 버전 선택과 등록](#editor-version)
4. [플랫폼과 한국어 선택](#components)
5. [설치 완료 확인](#install-complete)

---

<a id="hub-install"></a>

## 1. Unity Hub 설치

[Unity 공식 홈페이지](https://unity.com/download)에서 Hub 설치 파일을 내려받는다. 사용할 플랜의 조건을 확인하고, 설치 파일을 실행해 설치 위치를 선택한 뒤 설치를 마친다.

여러 Editor 버전을 사용할 때 Hub에서 설치 목록을 관리할 수 있다. Hub 설치를 마쳤다면 실행해서 계정을 준비한다.

---

<a id="account"></a>

## 2. 계정 생성과 로그인

Hub에서 `Sign in`을 누른다. 계정이 없다면 `Create account` 또는 계정 생성 링크를 선택한다.

이메일, 비밀번호, 사용자 이름 등 필요한 정보를 입력하고 동의 절차를 진행해 계정을 만든다. 생성한 계정으로 로그인한 뒤 Hub로 돌아온다.

이미 계정이 있다면 바로 로그인하면 된다. 계정 생성 화면의 항목과 버튼 이름은 버전에 따라 다를 수 있다.

---

<a id="editor-version"></a>

## 3. Editor 버전 선택과 등록

![Unity Hub의 Editor 설치 목록과 Install Editor 버튼](Images/unity-hub-installs.png)

`Installs`에서 설치할 Editor를 선택한다. 현재 Hub에서는 오른쪽 위의 `Install Editor`로 버전 목록을 연다. 이전 Hub의 `Official Releases → Download`에 대응하는 경로다.

### 버전과 관련된 용어

| 용어 | 의미 |
| --- | --- |
| LTS | Long-Term Support. 장기 지원 기간 동안 버그 수정과 호환성 개선을 제공하는 버전이다. |
| Locate / Locate a Version | 이미 설치된 Editor의 위치를 찾아 Hub에 등록하는 기능이다. |
| Preferred | 이전 Hub에서 새 프로젝트의 기본 선택으로 사용할 Editor 버전을 나타내던 표시다. |

LTS는 장기 지원을 뜻한다. 실제 지원 기간은 버전마다 [공식 릴리스 지원 안내](https://unity.com/releases/unity-6/support)에서 확인한다.

이미 Editor를 설치했다면 다시 다운로드할 필요 없이 `Locate`로 등록할 수 있다. `Preferred`는 최신 버전이라는 뜻이 아니라 기본 선택에 관한 표시이며, 현재 Hub에서는 표시 방식이 다를 수 있다.

현재 메뉴 위치는 [Editor 설치 공식 문서](https://docs.unity.com/en-us/hub/add-editor)를 참고한다.

---

<a id="components"></a>

## 4. 플랫폼과 한국어 선택

Editor 버전을 고른 뒤에는 함께 설치할 항목을 선택한다. 게임을 어느 플랫폼에 배포할지에 따라 필요한 Build Support를 고른다.

| 만들 게임의 대상 | 확인할 설치 항목 |
| --- | --- |
| Android | Android Build Support |
| iPhone·iPad | iOS Build Support |
| 그 밖의 플랫폼 | 해당 플랫폼의 Build Support |
| 한국어 Editor 사용 | Language packs의 한국어 항목 |

한국어가 필요하다면 언어 팩 목록의 `한국어`를 선택한다. 선택한 플랫폼과 항목이 많을수록 필요한 용량과 설치 시간이 늘어나므로 필요한 항목을 확인한 뒤 설치를 시작한다.

### 나중에 항목을 추가하려면

![현재 Unity Hub에서 Add modules를 여는 위치](Images/unity-hub-add-modules.png)

현재 Hub에서는 `Installs → 해당 Editor의 Manage → Add modules`에서 플랫폼 지원과 언어 팩을 추가할 수 있다. 이 기능은 Hub로 설치한 Editor에서 사용할 수 있다.

현재 메뉴는 [모듈 추가 안내](https://docs.unity.com/en-us/hub/add-modules), 한국어 언어 팩은 [언어 설정 안내](https://docs.unity.com/en-us/hub/add-editor-language)를 참고한다. 한국어 팩 설치와 Editor의 표시 언어 변경은 별도 절차다.

---

<a id="install-complete"></a>

## 5. 설치 완료 확인

![Unity Hub에서 다운로드와 설치 진행 상태 확인](Images/unity-hub-downloads.png)

다운로드와 설치가 끝날 때까지 기다린 뒤, `Installs`의 설치 목록에서 선택한 Editor 버전을 확인한다.

현재 Hub에서는 오른쪽 위의 `Downloads` 아이콘으로 진행 상태를 볼 수 있다. 설치가 완료되어 Editor가 목록에 표시되면 해당 버전으로 개발을 시작할 준비가 된 것이다.

---

## 사진 출처와 현재 메뉴 참고

사진은 Unity 공식 문서에서 가져왔으며 저작권은 Unity Technologies에 있다. 아래 문서는 현재 Hub의 메뉴와 설정을 확인할 때 참고한다.

- [Editor 설치](https://docs.unity.com/en-us/hub/add-editor) — Installs, Downloads 사진과 Locate 경로
- [모듈 추가](https://docs.unity.com/en-us/hub/add-modules) — Manage 메뉴 사진과 Add modules 경로
- [Hub·Editor 언어 설정](https://docs.unity.com/en-us/hub/add-editor-language)
- [LTS와 릴리스 지원](https://unity.com/releases/unity-6/support)

---

[목차로 돌아가기](#contents) · [메인 README로 돌아가기](../../README.md#unity)
