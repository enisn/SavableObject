﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Forms.Savable
{
    interface ISavable
    {
        void Save();
        void Load();
        void Clear();
    }
}
