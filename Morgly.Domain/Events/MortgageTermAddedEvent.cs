﻿using Morgly.Domain.Entities;

namespace Morgly.Domain.Events;

public class MortgageTermAddedEvent : DomainEvent
{
    public Guid MortgageId { get; }
    public DateTime TermStartDate { get; }
    public int LengthInMonths { get; }

    public MortgageTermAddedEvent(Guid mortgageId, DateTime termStartDate, int lengthInMonths)
    {
        MortgageId = mortgageId;
        TermStartDate = termStartDate;
        LengthInMonths = lengthInMonths;
    }
}