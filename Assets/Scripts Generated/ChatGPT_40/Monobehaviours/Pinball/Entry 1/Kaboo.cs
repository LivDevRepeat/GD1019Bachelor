using Scripts_Generated.ChatGPT_40.Monobehaviours.Pinball;

public class Kaboo : BaseEntity
{
    public bool isPeripheral = true; // Use this to differentiate the logic for different Kaboos

    void Start()
    {
        if(isPeripheral)
        {
            points = 240;
        }
        else
        {
            points = 480;
        }
    }

    public override void OnHit()
    {
        base.OnHit();
        if(isPeripheral && health < 1)
        {
            points = 180;
        }
    }
}