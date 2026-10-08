public class Actor
{
    public string Name = "이름 없음";
    public int Level = 1;
    private string greeting = "안녕하세요";

    public string Talk()
    {
        return Name + ": " + greeting;
    }

    public void LevelUp()
    {
        Level++;
    }
}
