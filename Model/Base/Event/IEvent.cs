﻿using System;

namespace NiceET
{
	public interface IEvent
	{
		Type GetEventType();
	}

	[Event]
	public abstract class AEvent<A> : IEvent where A : struct
	{
		public Type GetEventType()
		{
			return typeof(A);
		}

		public abstract ETTask Run(A a);
	}
}