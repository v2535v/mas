﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeoDo.RSS.Core.DrawEngine
{
    public interface ILoadingPrecentSubscriber
    {
        void Percent(string identfy, int percent);
    }
}
