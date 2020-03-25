using Ryujinx.HLE.HOS.Services.Arp;
using System;
using System.Text;
using System.Collections.Generic;

namespace Ryujinx.HLE.HOS.Services.Bcat.ServiceCreator
{
    class IDeliveryCacheDirectoryService : IpcService
    {
        public IDeliveryCacheDirectoryService(ServiceCtx context, ApplicationLaunchProperty applicationLaunchProperty)
        {

        }
        [Command(0)]
        public ResultCode Open(ServiceCtx context)
        {
            return ResultCode.Success;
        }

        [Command(1)]
        public ResultCode Read(ServiceCtx context)
        {
            return ResultCode.Success;
        }

        [Command(2)]
        public ResultCode Count(ServiceCtx context)
        {
            return ResultCode.Success;
        }
    }
}