﻿using Api.OpenClosedPrinciple.Violation.Entities;

namespace Api.OpenClosedPrinciple.Violation.Repository;

public class PhysicalPersonRepository
{
    public bool PhysicalPersonAlreadyExists(PhysicalPersonEntity physicalPerson)
    {
        return false;
    }

    public int CreateNewPhysicalPerson(PhysicalPersonEntity physicalPerson)
    {
        var rowAffecteds = 1;
        return rowAffecteds;
    }
}