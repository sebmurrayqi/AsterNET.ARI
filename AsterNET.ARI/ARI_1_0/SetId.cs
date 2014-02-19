﻿using System;
using System.Collections.Generic;

namespace AsterNET.ARI.Models
{
	/// <summary>
	/// Effective user/group id
	/// </summary>
	public class SetId 
	{
		/// <summary>
		/// Effective user id.
		/// </summary>
		public string User { get; set; }

		/// <summary>
		/// Effective group id.
		/// </summary>
		public string Group { get; set; }

	}
}