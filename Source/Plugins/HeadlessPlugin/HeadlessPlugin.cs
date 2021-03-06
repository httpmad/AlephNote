﻿using AlephNote.PluginInterface;
using AlephNote.PluginInterface.Impl;
using AlephNote.PluginInterface.Util;
using System;
using System.Net;
using System.Reflection;

namespace AlephNote.Plugins.Headless
{
	public class HeadlessPlugin : BasicRemotePlugin
	{
		public static readonly Version Version = GetInformationalVersion(typeof(HeadlessPlugin).GetTypeInfo().Assembly);
		public const string Name = "HeadlessPlugin";

		public HeadlessPlugin() : base("No Remote", Version, Guid.Parse("37de6de1-26b0-41f5-b252-5e625d9ecfa3"))
		{
			//
		}

		public override void Init(IAlephLogger logger)
		{
			//
		}

		public override bool HasNativeDirectorySupport()
		{
			return true;
		}

		public override IRemoteStorageConfiguration CreateEmptyRemoteStorageConfiguration()
		{
			return new HeadlessConfig();
		}

		public override IRemoteStorageConnection CreateRemoteStorageConnection(IWebProxy proxy, IRemoteStorageConfiguration config, HierachyEmulationConfig hConfig)
		{
			return new HeadlessConnection();
		}

		public override INote CreateEmptyNote(IRemoteStorageConnection conn, IRemoteStorageConfiguration cfg)
		{
			return new HeadlessNote(Guid.NewGuid());
		}

		public override IRemoteStorageSyncPersistance CreateEmptyRemoteSyncData()
		{
			return new HeadlessData();
		}
	}
}
