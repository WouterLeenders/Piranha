﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Piranha.Entities
{
	/// <summary>
	/// The param entity.
	/// </summary>
	public class Param : StandardEntity<Param>
	{
		#region Properties
		/// <summary>
		/// Gets/sets the name of the parameter.
		/// </summary>
		public string Name { get ; set ; }

		/// <summary>
		/// Gets/sets the value of the parameter.
		/// </summary>
		public string Value { get ; set ; }

		/// <summary>
		/// Gets/sets the parameter description.
		/// </summary>
		public string Description { get ; set ; }

		/// <summary>
		/// Gets/sets weather the parameter can be removed or not.
		/// </summary>
		public bool IsLocked { get ; set ; }
		#endregion
	}
}
