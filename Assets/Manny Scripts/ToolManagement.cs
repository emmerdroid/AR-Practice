using UnityEngine;

public class ToolManagement : MonoBehaviour
{
    public enum Tool
    { Place, Draw, Clear }

    public Tool currentTool;
    [SerializeField] private ObjectSelection obj;

    public void PlaceSelect()
    {
        currentTool = Tool.Place;
    }

    public void DrawTool()
    {
        currentTool = Tool.Draw;
        obj.currentObj = ObjectSelection.Objects.None;
    }

    public void ClearTool()
    {
        obj.currentObj = ObjectSelection.Objects.None;
        currentTool = Tool.Clear;
        GameObject[] ARObjects = GameObject.FindGameObjectsWithTag("AR Object");
        foreach (GameObject obj in ARObjects)
        {
            GameObject.Destroy(obj);
        }
    }
}