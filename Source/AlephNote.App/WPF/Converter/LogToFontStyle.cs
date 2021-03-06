﻿using AlephNote.Log;
using AlephNote.WPF.MVVM;
using System;
using System.Windows;

namespace AlephNote.WPF.Converter
{
	class LogToFontStyle : OneWayConverter<LogEventType, FontStyle>
	{
		protected override FontStyle Convert(LogEventType value, object parameter)
		{
			switch (value)
			{
				case LogEventType.Trace:       return FontStyles.Italic;
				case LogEventType.Debug:       return FontStyles.Italic;
				case LogEventType.Information: return FontStyles.Normal;
				case LogEventType.Warning:     return FontStyles.Normal;
				case LogEventType.Error:       return FontStyles.Normal;

				default:
					throw new ArgumentOutOfRangeException(nameof(value));
			}
		}
	}
}
