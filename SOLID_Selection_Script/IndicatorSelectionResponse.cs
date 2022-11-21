using UnityEngine;

public class IndicatorSelectionResponse : MonoBehaviour, ISelectionResponse
{
    [SerializeField] private GameObject indicatorPrefab;
    [SerializeField] private Vector3 offset;

    private GameObject _indicator;

    public void OnSelect(Transform selection)
    {
        _indicator = Instantiate(indicatorPrefab, selection);
        var Position = _indicator.transform.position;
        Position.y = 0;
        Position += offset;
        _indicator.transform.position = Position;
    }

    public void OnDeselect(Transform selection)
    {
        if (_indicator != null)
        {
            Destroy(_indicator);
        }
    }
}