using System.Collections.Generic;
using UnityEngine;

public class CSharpBasicsDemo : MonoBehaviour
{
    private int level = 5;
    private int health = 30;

    private void Start()
    {
        Debug.Log("[변수]");
        float strength = 15.5f;
        string playerName = "검사";
        bool isFullLevel = false;
        Debug.Log("레벨: " + level + ", 힘: " + strength);
        Debug.Log("이름: " + playerName + ", 만렙: " + isFullLevel);

        Debug.Log("[배열과 리스트]");
        string[] monsters = { "슬라임", "사막뱀", "악마" };
        int[] monsterLevels = new int[3];
        monsterLevels[0] = 1;
        monsterLevels[1] = 6;
        monsterLevels[2] = 20;
        Debug.Log("첫 몬스터: " + monsters[0] + ", 레벨: " + monsterLevels[0]);
        List<string> items = new List<string>();
        items.Add("생명물약");
        items.Add("마나물약");
        items.RemoveAt(0);
        Debug.Log("삭제 후 첫 아이템: " + items[0] + ", 개수: " + items.Count);

        Debug.Log("[연산자]");
        int exp = 1500;
        exp = exp + 320;
        exp = exp - 10;
        level = exp / 300;
        strength = level * 3.1f;
        int nextExp = 300 - (exp % 300);
        Debug.Log("경험치: " + exp + ", 레벨: " + level);
        Debug.Log("힘: " + strength + ", 다음 레벨까지: " + nextExp);
        string title = "전설의";
        Debug.Log(title + " " + playerName);
        isFullLevel = level == 99;
        bool isTutorialOver = level > 10;
        int mana = 25;
        bool bothLow = health <= 50 && mana <= 20;
        bool isBadCondition = health <= 50 || mana <= 20;
        Debug.Log("AND: " + bothLow + ", OR: " + isBadCondition);
        Debug.Log("만렙: " + isFullLevel + ", 튜토리얼 종료: " + isTutorialOver);
        Debug.Log("상태: " + (isBadCondition ? "나쁨" : "좋음"));

        Debug.Log("[조건문]");
        // 개수를 먼저 확인해 비어 있는 리스트 접근을 막는다.
        if (isBadCondition && items.Count > 0 && items[0] == "생명물약")
        {
            health += 30;
            items.RemoveAt(0);
            Debug.Log("생명물약 사용, 체력: " + health);
        }
        else if (isBadCondition && items.Count > 0 && items[0] == "마나물약")
        {
            mana += 30;
            items.RemoveAt(0);
            Debug.Log("마나물약 사용, 마나: " + mana);
        }
        else
        {
            Debug.Log("사용할 물약이 없습니다.");
        }
        switch (monsters[1])
        {
            case "슬라임":
            case "사막뱀":
                Debug.Log("소형 몬스터");
                break;
            case "악마":
                Debug.Log("중형 몬스터");
                break;
            case "골렘":
                Debug.Log("대형 몬스터");
                break;
            default:
                Debug.Log("알 수 없는 크기");
                break;
        }

        Debug.Log("[반복문]");
        int poisonTicks = 0;
        while (health > 0)
        {
            health--;
            poisonTicks++;
            if (health == 10)
                break;
        }
        Debug.Log("독 피해 " + poisonTicks + "회, 체력: " + health);
        for (int count = 0; count < 10; count++)
            health++;
        Debug.Log("붕대 10회 사용, 체력: " + health);
        for (int index = 0; index < monsters.Length; index++)
            Debug.Log(monsters[index] + ": " + Battle(monsterLevels[index]));
        foreach (string monster in monsters)
            Debug.Log("탐색: " + monster);

        Debug.Log("[함수]");
        health = Heal(health);
        Debug.Log("반환값 적용 후 체력: " + health);
        Heal();
        Debug.Log("멤버 변수 회복 후 체력: " + health);

        Debug.Log("[클래스와 상속]");
        Player player = new Player();
        player.Name = playerName;
        player.Level = level;
        Debug.Log(player.Talk());
        player.LevelUp();
        Debug.Log("상속받은 LevelUp 실행 후 레벨: " + player.Level);
        Debug.Log(player.Move());
    }

    // 값으로 받은 체력을 계산하고 결과를 반환한다.
    private int Heal(int currentHealth)
    {
        return currentHealth + 10;
    }

    // 이 컴포넌트의 멤버 변수를 직접 변경한다.
    private void Heal()
    {
        health += 10;
    }

    private string Battle(int monsterLevel)
    {
        if (level >= monsterLevel)
            return "승리";
        return "패배";
    }
}
