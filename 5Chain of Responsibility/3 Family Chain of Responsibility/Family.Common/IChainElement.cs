﻿using System.Runtime.InteropServices.ComTypes;

namespace Family.Common
{
    public interface IChainElement
    {
        T As<T>(T defaultValue) where T : class;

    }
}
