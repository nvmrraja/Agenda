﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Agenda.Common.Convertors
{
    public sealed class LabelFontWeightConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo language)
        {
            return ((string)value + "").Contains("Facebook") ? FontAttributes.Bold : FontAttributes.None;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo language)
        {
            return null;
        }
    }

    public sealed class AgoLabelConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo language)
        {
            DateTime articleDateTime = (DateTime)value;
            int minDifference = (int)(DateTime.Now.ToUniversalTime() - articleDateTime).TotalMinutes;

            return (minDifference > 60) ? "more than an hour ago" : minDifference + " minutes ago";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo language)
        {
            return null;
        }
    }
}
