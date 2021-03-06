/*****************************  NOTICE  ********************************************
* This file was autogenerated.  Do not edit.                                       *
* Instead, modify the schema in DataSchema related to this class and regenerate it *
***********************************************************************************/
using System;
using System.ComponentModel;
using WorldSmith.Panels;
using WorldSmith.Dialogs;

namespace WorldSmith.DataClasses
{
	[DotaAction]
	[EditorGrammar("Heal %Target for %HealAmount hitpoints")]
	public partial class Heal : TargetedAction
	{
		[Category("Misc")]
		[Description("int")]
		[DefaultValue("")]
		public string HealAmount
		{
			get;
			set;
		}

	}
}
