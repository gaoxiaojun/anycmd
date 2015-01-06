﻿
namespace Anycmd.Engine.Ac.Messages.Infra
{
    using InOuts;

    public class UpdateAppSystemCommand : UpdateEntityCommand<IAppSystemUpdateIo>, IAnycmdCommand
    {
        public UpdateAppSystemCommand(IAppSystemUpdateIo input)
            : base(input)
        {

        }
    }
}
