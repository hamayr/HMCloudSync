﻿using Volo.Abp.Settings;

namespace HMCloudSync.Settings;

public class HMCloudSyncSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(HMCloudSyncSettings.MySetting1));
    }
}
