using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evolution : MonoBehaviour
{
    public int ATK = 5; // ���ݷ�

    //float ATKSP = 0.34f; //���ݼӵ�

    int[] requireExp = { 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100 }; //������ ���� ����ġ

    public int currExp; //���� ����ġ
    public int currLevel; //������ ����
    public string WpRating;

    int[] RatingLv = { 11, 21, 31 };


    void Start()
    {
        currExp = 0;
        currLevel = 1;
        WpRating = "���";
        
        
    }

    public void getEXP(int _exp)
    {
        currExp += _exp;
        if (currExp >= getRequireExp(currLevel))
        {
            LevelUP();
        }

    }

    void LevelUP()
    {
        print("���� ��!!");
        currLevel++;
        ATK += 2;
        currExp = 0;
    }

    void RatingUP()
    {

        if(currLevel <= 11)
        {
            print("��� ��!!");
        }

    }

    int getRequireExp(int _level)
    {
        return requireExp[_level - 1];
    }
}
