using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    int[] requireExp = { 250, 500, 1000, 2000 };

    public int currExp; //���� ����ġ
    public int currLevel; //������ ����
    string itemClass;
    


    // Start is called before the first frame update
    void Start()
    {
        currExp = 0;
        currLevel = 1; //�ʱⷹ�� ����
        itemClass = "�Ϲ�";
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //����ġ ȹ��
    public void getEXP(int _exp)
    {
        currExp += _exp;
        if(currExp >= getRequireExp(currLevel))
        {
            LevelUP();
        }
    }

    void LevelUP()
    {
        //���� ��
        print("���� ��!!!!!!!!!!!!!!!!!!!!");
        //
        currLevel++;
        currExp = 0;
    }

    int getRequireExp(int _level)
    {
        return requireExp[_level - 1];
    }
}
