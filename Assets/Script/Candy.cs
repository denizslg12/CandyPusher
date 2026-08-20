using UnityEngine;

public class Candy : MonoBehaviour
{
    [Header("Candy Color")]
    [SerializeField] private CandyColor candyColor;
    [SerializeField] private bool isSpecial;
    public CandyColor Color => candyColor;
    public bool IsSpecial => isSpecial;

    public void SetColor(CandyColor newColor)
    {
        candyColor = newColor;
    }
}
