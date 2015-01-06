﻿using System;

namespace Anycmd.Engine.Edi.InOuts
{

    public interface IProcessCreateIo : IEntityCreateInput
    {
        string Type { get; }

        string Name { get; }

        int NetPort { get; }

        int IsEnabled { get; }

        Guid OntologyId { get; }

        string OrganizationCode { get; }

        string Description { get; }
    }
}
