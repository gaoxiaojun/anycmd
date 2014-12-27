﻿
namespace Anycmd.Engine.Ac.Messages
{
    using Engine.Ac.Abstractions;
    using Events;

    public class GroupRemovingEvent: DomainEvent
    {
        public GroupRemovingEvent(GroupBase source)
            : base(source)
        {
        }
    }
}