using UnityEngine;
using UnityEngine.EventSystems;

public class TapArea : MonoBehaviour, IPointerDownHandler
{
    private AudioSource click;
    public void OnPointerDown(PointerEventData eventData)

    {
        GameManager.Instance.CollectByTap(eventData.position, transform);
        click.Play();
    }

    // Start is called before the first frame update
    void Start()
    {
        click = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
