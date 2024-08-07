namespace ExtensionMethods
{
	using System;
	using System.Collections.Generic;
	using UnityEngine;

	public static class Extensions
	{
		public static Vector2 Round (this Vector2 value, int digits)
		{
			MathF.Round (value.x, digits);
			MathF.Round (value.y, digits);

			return value;
		}

		public static Vector3 Round (this Vector3 value, int digits)
		{
			MathF.Round (value.x, digits);
			MathF.Round (value.y, digits);
			MathF.Round (value.z, digits);

			return value;
		}

		public static Vector4 Round (this Vector4 value, int digits)
		{
			MathF.Round (value.x, digits);
			MathF.Round (value.y, digits);
			MathF.Round (value.z, digits);
			MathF.Round (value.w, digits);

			return value;
		}

		public static bool IsNullOrEmpty (this string value)
		{
			if (value != null)
				return value.Length == 0;

			return true;
		}

		public static bool IsNullOrEmpty<T> (this ICollection<T> value)
		{
			if (value != null)
				return value.Count == 0;

			return true;
		}

		public static T[] Copy<T> (this ICollection<T> value)
		{
			T[] targetArray = new T[value.Count];
			value.CopyTo (targetArray, 0);

			return targetArray;
		}

		public static T[] Copy<T> (this ICollection<T> value, int length)
		{
			T[] targetArray = new T[length];
			value.CopyTo (targetArray, 0);

			return targetArray;
		}

		public static void Move<T> (this IList<T> list, int indexFrom, int indexTo)
		{
			if (indexFrom == indexTo)
				return;

			T objectToMove = list[indexFrom];

			if (indexFrom < indexTo)
			{
				for (int i = indexFrom; i < indexTo; i++)
				{
					int next = i + 1;
					list[i] = list[next];
				}
			}
			else
			{
				for (int i = indexFrom; i > indexTo; i--)
				{
					int next = i - 1;
					list[i] = list[next];
				}
			}

			list[indexTo] = objectToMove;
		}
	}
}
