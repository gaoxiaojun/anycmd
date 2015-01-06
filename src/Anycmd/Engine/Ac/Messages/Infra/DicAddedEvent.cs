﻿
namespace Anycmd.Engine.Ac.Messages.Infra
{
    using Engine.Ac.Abstractions.Infra;
    using InOuts;

    /// <summary>
    /// 
    /// </summary>
    public class DicAddedEvent : EntityAddedEvent<IDicCreateIo>
    {
        public DicAddedEvent(DicBase source, IDicCreateIo input)
            : base(source, input)
        {
        }
    }
}