using System.Collections.Generic;
using UnityEngine;

public class WarehouseBasicsDemo : MonoBehaviour
{
    private int queuedBoxes = 9;
    private int reservedSlots = 2;
    private int tripLimit = 8;

    private void Start()
    {
        Debug.Log("[변수]");
        float conveyorRate = 1.25f;
        string stationLabel = "동쪽 분류대";
        bool isOpen = true;
        Debug.Log("대기 상자: " + queuedBoxes + ", 처리 속도: " + conveyorRate);
        Debug.Log("작업장: " + stationLabel + ", 운영 중: " + isOpen);

        Debug.Log("[배열과 리스트]");
        string[] routes = { "중앙 창고", "동쪽 분류대", "서쪽 출고장" };
        int[] routeLoads = new int[3];
        routeLoads[0] = 3;
        routeLoads[1] = 7;
        routeLoads[2] = 12;
        Debug.Log("첫 경로: " + routes[0] + ", 상자: " + routeLoads[0]);
        List<string> pendingSteps = new List<string>();
        pendingSteps.Add("라벨 확인");
        pendingSteps.Add("송장 인쇄");
        pendingSteps.Add("출고 등록");
        pendingSteps.RemoveAt(0);
        Debug.Log("삭제 후 첫 작업: " + pendingSteps[0] + ", 남은 작업: " + pendingSteps.Count);

        Debug.Log("[연산자]");
        int weeklyOrders = 48;
        weeklyOrders = weeklyOrders + 13;
        weeklyOrders = weeklyOrders - 5;
        int completeCrates = weeklyOrders / 12;
        int looseBoxes = weeklyOrders % 12;
        int spaceToNextCrate = 12 - looseBoxes;
        float packingCost = completeCrates * 2.5f;
        Debug.Log("주간 주문: " + weeklyOrders + ", 완성 포장: " + completeCrates);
        Debug.Log("낱개 상자: " + looseBoxes + ", 다음 포장까지: " + spaceToNextCrate);
        Debug.Log("포장 비용: " + packingCost);
        string servicePrefix = "빠른 배송";
        Debug.Log(servicePrefix + " · " + stationLabel);
        bool canDispatchNow = queuedBoxes <= tripLimit && isOpen;
        bool needsReview = queuedBoxes > tripLimit || reservedSlots == 0;
        Debug.Log("AND 출고 가능: " + canDispatchNow + ", OR 검토 필요: " + needsReview);
        Debug.Log("작업 상태: " + (needsReview ? "검토 필요" : "정상"));

        Debug.Log("[조건문]");
        // 첫 작업을 읽기 전에 목록에 항목이 있는지 확인한다.
        if (pendingSteps.Count > 0 && pendingSteps[0] == "라벨 확인")
        {
            Debug.Log("주소 라벨을 검수합니다.");
            pendingSteps.RemoveAt(0);
        }
        else if (pendingSteps.Count > 0 && pendingSteps[0] == "송장 인쇄")
        {
            Debug.Log("운송장을 출력합니다.");
            pendingSteps.RemoveAt(0);
        }
        else
        {
            Debug.Log("자동 처리 대상이 없습니다.");
        }
        switch (routes[1])
        {
            case "중앙 창고":
            case "동쪽 분류대":
                Debug.Log("표준 출고 경로");
                break;
            case "서쪽 출고장":
                Debug.Log("묶음 출고 경로");
                break;
            default:
                Debug.Log("경로를 확인해 주세요.");
                break;
        }

        Debug.Log("[반복문]");
        int labelsRemaining = 6;
        int scansCompleted = 0;
        while (labelsRemaining > 0)
        {
            labelsRemaining--;
            scansCompleted++;
            if (scansCompleted == 4)
                break;
        }
        Debug.Log("라벨 검사: " + scansCompleted + "회, 남은 라벨: " + labelsRemaining);
        for (int pass = 1; pass <= 3; pass++)
            scansCompleted++;
        Debug.Log("추가 검사 3회 후 누적 검사: " + scansCompleted);
        for (int position = 0; position < routes.Length; position++)
            Debug.Log(routes[position] + ": " + GetDispatchPlan(routeLoads[position]));
        foreach (string route in routes)
            Debug.Log("등록 경로: " + route);

        Debug.Log("[함수]");
        reservedSlots = EstimateSlots(reservedSlots, 3);
        Debug.Log("예상 예약 반영: " + reservedSlots);
        ReserveOneSlot();
        Debug.Log("추가 예약 후: " + reservedSlots);

        Debug.Log("[클래스와 상속]");
        PriorityShipment order = new PriorityShipment();
        order.Destination = stationLabel;
        order.BoxCount = 3;
        Debug.Log(order.GetSummary());
        order.AddBox();
        Debug.Log("부모 AddBox 실행 후 상자: " + order.BoxCount);
        Debug.Log(order.GetServiceNotice());
    }

    // 전달받은 두 값을 계산해 예상 예약 수를 반환한다.
    private int EstimateSlots(int currentReservations, int incomingReservations)
    {
        return currentReservations + incomingReservations;
    }

    // 이 컴포넌트의 필드를 직접 변경한다.
    private void ReserveOneSlot()
    {
        reservedSlots++;
    }

    private string GetDispatchPlan(int packageCount)
    {
        if (packageCount <= tripLimit)
            return "한 번에 출고";
        return "나누어 출고";
    }
}
