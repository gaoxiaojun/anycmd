﻿using System;

namespace Anycmd.Engine.Edi.InOuts
{

    public interface INodeElementActionCreateIo : IEntityCreateInput
    {
        Guid NodeId { get; }

        /// <summary>
        /// 
        /// </summary>
        Guid ElementId { get; }

        /// <summary>
        /// 
        /// </summary>
        Guid ActionId { get; }
        /// <summary>
        /// 是否需要审核
        /// </summary>
        bool IsAudit { get; }
        /// <summary>
        /// 
        /// </summary>
        bool IsAllowed { get; }
    }
}
