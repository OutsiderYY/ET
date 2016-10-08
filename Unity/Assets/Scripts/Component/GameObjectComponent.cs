﻿using UnityEngine;

namespace Base
{
	[ObjectEvent]
	public class GameObjectComponentEvent : ObjectEvent<GameObjectComponent>, IAwake<GameObject>
	{
		public void Awake(GameObject gameObject)
		{
			this.GetValue().Awake(gameObject);
		}
	}

	public class GameObjectComponent : Component
    {
		public GameObject GameObject { get; private set; }

		public void Awake(GameObject gameObject)
		{
			this.GameObject = gameObject;
		}
    }
}