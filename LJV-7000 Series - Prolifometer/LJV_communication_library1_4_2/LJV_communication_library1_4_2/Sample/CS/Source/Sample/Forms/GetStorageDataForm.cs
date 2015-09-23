﻿//----------------------------------------------------------------------------- 
// <copyright file="GetStorageDataForm.cs" company="KEYENCE">
//	 Copyright (c) 2013 KEYENCE CORPORATION.  All rights reserved.
// </copyright>
//----------------------------------------------------------------------------- 
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace LJV7_DllSampleAll.Forms
{
	public partial class GetStorageDataForm : Form
	{
		#region Field
		/// <summary>
		/// Storage status request structure
		/// </summary>
		private LJV7IF_GET_STORAGE_REQ _req;
		#endregion

		#region Property
		/// <summary>
		/// Storage status request structure
		/// </summary>
		public LJV7IF_GET_STORAGE_REQ Req
		{
			get { return _req; }
		}
		#endregion

		#region Event
		/// <summary>
		/// Close start event
		/// </summary>
		/// <param name="e"></param>
		protected override void OnClosing(CancelEventArgs e)
		{
			if (DialogResult == DialogResult.OK)
			{
				try
				{
					_req.dwSurface = Convert.ToUInt32(_txtboxSurface.Text);
					_req.dwStartNo = Convert.ToUInt32(_txtboxStartNo.Text);
					_req.dwDataCnt = Convert.ToUInt32(_txtboxDataCnt.Text);
				}
				catch (Exception ex)
				{
					MessageBox.Show(this, ex.Message);
					e.Cancel = true;
					return;
				}
			}

			base.OnClosing(e);
		}
		#endregion

		#region Method
		/// <summary>
		/// Constructor
		/// </summary>
		public GetStorageDataForm()
		{
			InitializeComponent();

			// Field initialization
			_req = new LJV7IF_GET_STORAGE_REQ();
		}
		#endregion
	}
}
