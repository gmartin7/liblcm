﻿// Copyright (c) 2015 SIL International
// This software is licensed under the LGPL, version 2.1 or later
// (http://www.gnu.org/licenses/lgpl-2.1.html)

using System.Collections.Generic;
using NUnit.Framework;
using SIL.LCModel.Infrastructure;

namespace SIL.LCModel.DomainImpl
{
	/// <summary>
	/// Tests the basic generated code for atomic properties. There should be a lot more, and maybe are somewhere,
	/// but I can't find them.
	/// </summary>
	[TestFixture]
	public class AtomicPropertyTests : MemoryOnlyBackendProviderRestoredForEachTestTestBase
	{
		/// <summary>
		/// Moving an object from elsewhere to an owning atomic property should mark the object as modified.
		/// </summary>
		[Test]
		public void MovingToAtomicOwnedObject_MarksMovedObjectModified()
		{
			var text = Cache.ServiceLocator.GetInstance<IStTextFactory>().Create();
			var origRecord = Cache.ServiceLocator.GetInstance<IRnGenericRecFactory>().Create();
			Cache.LangProject.ResearchNotebookOA.RecordsOC.Add(origRecord);
			origRecord.ConclusionsOA = text;
			var newRecord = Cache.ServiceLocator.GetInstance<IRnGenericRecFactory>().Create();
			Cache.LangProject.ResearchNotebookOA.RecordsOC.Add(newRecord);
			m_actionHandler.EndUndoTask();

			UndoableUnitOfWorkHelper.Do("undoIt", "redoIt", m_actionHandler, () => newRecord.ConclusionsOA = text);
			var uowService = Cache.ServiceLocator.GetInstance<IUnitOfWorkService>();
			HashSet<ICmObjectId> newbies = new HashSet<ICmObjectId>();
			HashSet<ICmObjectOrSurrogate> dirtballs = new HashSet<ICmObjectOrSurrogate>();
			HashSet<ICmObjectId> goners = new HashSet<ICmObjectId>();
			uowService.GatherChanges(newbies,dirtballs, goners);

			Assert.That(dirtballs.Contains((ICmObjectOrSurrogate)text));
		}
	}
}
