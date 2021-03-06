﻿
namespace Anycmd.Model
{
    using Exceptions;
    using System;

    /// <summary>
    /// 实体对象抽象基类
    /// </summary>
    public abstract class EntityObject : IEntity
    {
        private Guid _id = Guid.Empty;

        /// <summary>
        /// 实体标识
        /// </summary>
        public virtual Guid Id
        {
            get { return _id; }
            set
            {
                if (_id == value) return;
                if (_id != Guid.Empty)
                {
                    throw new AnycmdException("Anycmd采用‘及早生成标识’策略，标识生成后不能修改");
                }
                _id = value;
            }
        }

        /// <summary>
        /// 访问控制内容类型。
        /// 取值形如：text/javascript、text/xacml、text/javascript,fileLocation、text/xacml,fileLocation。
        /// </summary>
        public string AcContentType { get; set; }

        /// <summary>
        /// 访问控制内容。一些作用域为当前实体的javascript或xacml脚本。
        /// </summary>
        public string AcContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual byte[] Etag { get; set; }
    }
}
