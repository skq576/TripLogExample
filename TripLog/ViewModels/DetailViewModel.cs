﻿using System;
using System.Collections.Generic;
using System.Text;
using TripLog.Models;

namespace TripLog.ViewModels
{
    class DetailViewModel: BaseViewModel
    {
        TripLogEntry _entry;
        public TripLogEntry Entry
        {
            get { return _entry; }
            set
            {
                _entry = value;
                OnPropertyChanged();
            }
        }
        public DetailViewModel(TripLogEntry entry)
        {
            Entry = entry;
        }
    }
}
