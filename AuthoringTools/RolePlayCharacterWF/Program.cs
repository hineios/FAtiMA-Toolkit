﻿using System;
using System.Windows.Forms;
using AssetManagerPackage;
using GAIPS.AssetEditorTools;

namespace RolePlayCharacterWF
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			AssetManager.Instance.Bridge = new ApplicationBridge();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			var f = new MainForm();
			f.CreateNewAsset();
			Application.Run(f);
		}
	}
}