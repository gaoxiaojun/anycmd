﻿
namespace Anycmd.Engine.Ac.Abstractions
{
    /// <summary>
    /// 表示实现该接口的类为Ac元素
    /// </summary>
    public interface IAcElement
    {
        AcElementType AcElementType { get; }
    }
}
