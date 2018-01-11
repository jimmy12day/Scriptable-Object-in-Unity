using UnityEngine;
[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
    public new string name;
    public Sprite sprite;
    public string description;
    public int mana;
    public int attack;
    public int life;

    public string CardToPrint()
    {
        string result = "name:" + name + "| description:" + description + "|mana:" + mana + "|attack:" + attack + "|life" + life;
        return result;
    }
}
