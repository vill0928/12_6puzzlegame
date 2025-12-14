using Fungus;
using UnityEngine;

public class 動畫轉接 : MonoBehaviour
{
    

public class DoorAnimEvent : MonoBehaviour
{
    public Flowchart flowchart;

    public void DoorOpenFinished()
    {
        flowchart.ExecuteBlock("Door");
    }
}

}
