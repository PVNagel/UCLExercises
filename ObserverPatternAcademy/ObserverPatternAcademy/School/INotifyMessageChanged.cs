﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternAcademy.School
{
    public interface INotifyMessageChanged
    {
        public event EventHandler MessageChanged;

    }
}