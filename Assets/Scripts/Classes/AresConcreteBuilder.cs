using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AresConcreteBuilder : GodBuilder
{
    private God Ares;

    public void setName()
    {
        Ares.Name = "Ares";
    }
    public void setCurrentBid()
    {
        Ares.CurrentBid = 0;
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
        return Ares;
    }
}
