using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class staticInfo
{
    private static int P1Character, P2Character, P3Character, P4Character;
    private static bool P1Active, P2Active, P3Active, P4Active;

    public static int GetP1Character()
    {
        return P1Character;
    }

    public static void SetP1Character(int value)
    {
        P1Character = value;
    }

    public static int GetP2Character()
    {
        return P2Character;
    }

    public static void SetP2Character(int value)
    {
        P2Character = value;
    }

    public static int GetP3Character()
    {
        return P3Character;
    }

    public static void SetP3Character(int value)
    {
        P3Character = value;
    }

    public static int GetP4Character()
    {
        return P4Character;
    }

    public static void SetP4Character(int value)
    {
        P4Character = value;
    }

    public static bool GetP1Active()
    {
        return P1Active;
    }

    public static void SetP1Active(bool value)
    {
        P1Active = value;
    }

    public static bool GetP2Active()
    {
        return P2Active;
    }

    public static void SetP2Active(bool value)
    {
        P2Active = value;
    }
    public static bool GetP3Active()
    {
        return P3Active;
    }

    public static void SetP3Active(bool value)
    {
        P3Active = value;
    }
    public static bool GetP4Active()
    {
        return P4Active;
    }

    public static void SetP4Active(bool value)
    {
        P4Active = value;
    }


}
