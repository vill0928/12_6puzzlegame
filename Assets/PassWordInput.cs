using TMPro;
using UnityEngine;

public class NewMonoBehaviourScript1 : MonoBehaviour
{
    public TMP_Text displayText;   // 顯示輸入的數字
    [HideInInspector]
    public string inputCode = "";
    public int maxLength = 4;   // ★ 可調整密碼長度

    public void AddDigit(string digit)
    {

        if (inputCode.Length >= maxLength)
            return;

        inputCode += digit;
        displayText.text = inputCode;
    }

    public void Clear()
    {
        inputCode = "";
        displayText.text = "";
    }

    public string GetCode()
    {
        return inputCode;
    }
}

        

    



