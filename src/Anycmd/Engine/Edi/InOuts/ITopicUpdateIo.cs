﻿
namespace Anycmd.Engine.Edi.InOuts
{

    public interface ITopicUpdateIo : IEntityUpdateInput
    {
        string Code { get; }
        string Description { get; }
        string Name { get; }
    }
}
