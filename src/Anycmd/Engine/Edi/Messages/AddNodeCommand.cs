﻿
namespace Anycmd.Engine.Edi.Messages
{
    using InOuts;

    public class AddNodeCommand : AddEntityCommand<INodeCreateIo>, IAnycmdCommand
    {
        public AddNodeCommand(INodeCreateIo input)
            : base(input)
        {

        }
    }
}
