using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoseidonConcreteBuilder : GodBuilder
{
    private God Poseidon;

    public void setName()
    {
        Poseidon.Name = "Poseidon";
    }
    public void setCurrentBid()
    {
        Poseidon.CurrentBid = 0;
    }
    public void addRecruitMethod()
    {

    }
    public void addBuildMethod()
    {

    }
    public void addSpecialActionMethod()
    {

    }

    public God ReturnBuiltGod()
    {
        return Poseidon;
    }
}
