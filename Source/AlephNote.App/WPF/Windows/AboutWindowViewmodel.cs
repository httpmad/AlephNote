﻿using AlephNote.PluginInterface;
using AlephNote.Plugins;
using MSHC.WPF.MVVM;
using System.Collections.Generic;

namespace AlephNote.WPF.Windows
{
	class AboutWindowViewmodel : ObservableObject
	{
		public string Appversion { get { return App.AppVersionProperty; } }

		public IEnumerable<IRemotePlugin> AvailableProvider { get { return PluginManager.LoadedPlugins; } }
	}
}
