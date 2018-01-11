using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Image))]
public class CardDisplay : MonoBehaviour
{
    public Card card;
    public Text description;
    public Text mana;
    public Text attack;
    public Text life;
    Image img;

    // Use this for initialization
    void Start()
    {
        img = GetComponent<Image>();

        //Debug.Log(card.CardToPrint());
        description.text = card.description;
        mana.text = card.mana.ToString();
        attack.text = card.attack.ToString();
        life.text = card.life.ToString();
        img.sprite = card.sprite;


    }
}
