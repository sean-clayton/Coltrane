using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CTCharacterId
{
    private string id;

    public CTCharacterId(string newId)
    {
        id = newId;
    }

    public override string ToString()
    {
        return id;
    }
}
