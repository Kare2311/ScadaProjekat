﻿using Common;

namespace dCom.ViewModel
{
    internal class AnalaogInput : AnalogBase
	{
		public AnalaogInput(IConfigItem c, IProcessingManager processingManager, IStateUpdater stateUpdater, IConfiguration configuration, int i)
			: base(c, processingManager, stateUpdater, configuration, i)
		{
		}

        protected override void WriteCommand_Execute(object obj)
        {
            // Write command is not applicable for input points.
        }
    }
}