﻿using System;
using System.Collections.Generic;
using PropertyChanged;

namespace XFSMS.Models
{
    [AddINotifyPropertyChangedInterface]
    public class PlatformEventInfo
    {
        public List<PlatformEventInfo> EventPosts{ get; set; }

        public Constants.Platforms PlatformType{ get; set; }

        public PlatformEventInfo()
        {
            
        }
    }
}
