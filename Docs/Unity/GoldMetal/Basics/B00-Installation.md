# Unity Hub와 에디터 설치

> 형식 검토용 초안입니다. 현재 원본 영상의 설명란과 챕터, Unity 공식 문서를 확인했습니다. 영상 본문·자막은 확인하지 못했으므로, 강의 전체를 시청한 결과로 취급하지 않습니다.

<a id="contents"></a>

## 목차

1. [Hub와 에디터의 역할](#hub-editor)
2. [강의의 설치 흐름](#lecture-flow)
3. [현재 Hub에서 설치하기](#current-install)
4. [버전과 모듈 선택](#version-modules)
5. [막히기 쉬운 곳](#pitfalls)
6. [직접 확인할 항목](#verification)
7. [참고](#references)

---

<a id="hub-editor"></a>

## 1. Hub와 에디터의 역할

Unity를 설치할 때 먼저 구분할 것은 Unity Hub와 Unity Editor다.

Hub는 에디터 버전, 프로젝트, 계정과 라이선스를 관리하는 프로그램이다. Editor는 게임의 씬과 오브젝트를 구성하고 실행하는 개발 도구다. Hub를 설치한 뒤에는 작업에 사용할 Editor도 설치해야 한다.

```text
Unity Hub
 ├─ Editor 버전과 모듈 관리
 ├─ 프로젝트 관리
 └─ 계정과 라이선스 관리

Unity Editor
 └─ 씬 구성, 코드와 에셋 작업, 게임 실행
```

Hub의 역할은 [Unity Hub 공식 문서](https://docs.unity.com/en-us/hub)에서 확인할 수 있다.

---

<a id="lecture-flow"></a>

## 2. 강의의 설치 흐름

골드메탈의 B0 강의는 게임을 만들기 전 개발 도구를 준비하는 내용을 다룬다. 아래 순서와 시간은 영상 설명란에 있는 챕터를 기준으로 한다.

| 시작 시간 | 주제 | 다시 볼 링크 |
| --- | --- | --- |
| 00:00 | Unity Hub 설치 | [해당 구간](https://www.youtube.com/watch?v=7plGPXkmnxQ&t=0s) |
| 00:59 | 계정 생성 | [해당 구간](https://www.youtube.com/watch?v=7plGPXkmnxQ&t=59s) |
| 02:01 | 에디터 설치 | [해당 구간](https://www.youtube.com/watch?v=7plGPXkmnxQ&t=121s) |
| 03:06 | 부가요소 설치 | [해당 구간](https://www.youtube.com/watch?v=7plGPXkmnxQ&t=186s) |

영상에서 사용한 정확한 에디터 버전과 선택한 모듈은 본문 확인 후 보완한다. 설치 화면의 메뉴명은 Hub 버전에 따라 달라질 수 있다.

---

<a id="current-install"></a>

## 3. 현재 Hub에서 설치하기

아래 절차는 강의의 세부 내용을 대신 추정한 것이 아니라, 2026-10-07에 확인한 [현재 Hub 공식 설치 안내](https://docs.unity.com/en-us/hub/add-editor)를 정리한 것이다.

1. Hub에서 `Installs`를 연다.
2. `Install Editor`를 선택한다.
3. 사용할 버전을 고르고 `Install`을 누른다.
4. 필요한 모듈을 선택해 설치를 진행한다.
5. `Downloads`에서 진행 상태를 확인한다.

목록에 원하는 버전이 없다면 [Unity Download Archive](https://unity.com/releases/editor/archive)를 확인할 수 있다. 이미 별도로 설치한 Editor는 `Locate`로 Hub에 등록할 수 있다.

---

<a id="version-modules"></a>

## 4. 버전과 모듈 선택

기존 프로젝트를 열 때는 그 프로젝트가 사용하는 버전을 먼저 확인한다. 강의의 예제를 그대로 재현할 때와 현재 버전에서 같은 개념을 구현할 때도 구분해서 기록해야 한다. 최신 버전으로 열었다는 사실만으로 예제의 호환성이 확인되는 것은 아니다.

모듈은 플랫폼 빌드 지원, 언어 팩, 개발 도구 등을 추가하는 선택 구성 요소다. 필요한 것만 선택할 수 있고, Hub로 설치한 Editor에는 나중에 추가할 수도 있다.

현재 공식 문서의 추가 경로는 다음과 같다.

```text
Installs → 해당 Editor의 Manage → Add modules → 모듈 선택 → Install
```

이 동작과 적용 조건은 [모듈 추가 공식 문서](https://docs.unity.com/en-us/hub/add-modules)를 참고한다.

---

<a id="pitfalls"></a>

## 5. 막히기 쉬운 곳

**Hub를 설치했는데 Editor가 없다**

`Installs`에서 사용할 Editor의 설치가 끝났는지 확인한다.

**원하는 버전이 설치 목록에 없다**

Download Archive에서 버전을 찾아 Hub 설치 링크를 이용한다.

**`Add modules` 메뉴가 없다**

공식 문서에 따르면 Hub 외부에서 설치한 Editor에서는 이 기능을 사용할 수 없다. `Locate`로 등록하는 것과 Hub를 통해 설치하는 것은 구분해야 한다.

**강의와 메뉴 위치가 다르다**

강의의 화면에서 어떤 역할을 하는 기능인지 확인하고, 현재 Hub 문서에서 대응하는 기능을 찾는다. 바뀐 화면을 강의의 원래 설명인 것처럼 기록하지 않는다.

---

<a id="verification"></a>

## 6. 직접 확인할 항목

아래는 실습할 때 사용할 확인 항목이다. 이번 문서 초안에서는 실제 설치나 Editor 실행을 수행하지 않았다.

- [ ] Hub의 설치와 로그인 확인
- [ ] 사용할 Editor 버전 확인
- [ ] 해당 Editor와 필요한 모듈의 설치 완료 확인
- [ ] 그 버전으로 프로젝트를 만들고 Editor가 열리는지 확인

이 강의의 문서에는 코드 예제를 억지로 추가하지 않는다. 콘솔 출력과 C# 예제는 해당 강의에서 다룬 내용을 확인한 뒤 별도 문서에 정리한다.

---

<a id="references"></a>

## 7. 참고

- [골드메탈 — 유니티3D 알아보며 설치해보아요, B0](https://www.youtube.com/watch?v=7plGPXkmnxQ)
- [유니티 기초 강좌 재생목록](https://www.youtube.com/playlist?list=PLO-mt5Iu5TeYI4dbYwWP8JqZMC9iuUIW2)
- [Unity Hub](https://docs.unity.com/en-us/hub)
- [Unity Editor 설치](https://docs.unity.com/en-us/hub/add-editor)
- [Editor 모듈 추가](https://docs.unity.com/en-us/hub/add-modules)
- [Unity Download Archive](https://unity.com/releases/editor/archive)

---

[목차로 돌아가기](#contents) · [강좌 목록으로 돌아가기](../README.md) · [메인 README로 돌아가기](../../../../README.md)
