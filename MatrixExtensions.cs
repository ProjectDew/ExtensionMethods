namespace ExtensionMethods
{
	using System;
	using System.Collections.Generic;

	public static class MatrixExtensions
	{
		private static readonly IndexOutOfRangeException indexOutOfRange = new ("Index is out of range.");
		private static readonly ArgumentException nullOrEmptyList = new ("The provided list is null or empty.", "item (IList)");

		public static T[][] GetTranspose<T> (this IList<T>[] matrix)
		{
			int columns = matrix.ColumnCount ();

			T[][] transpose = new T[columns][];

			for (int i = 0; i < transpose.Length; i++)
				transpose[i] = matrix.GetColumn (i);

			return transpose;
		}

		public static T[][] GetTranspose<T> (this List<T[]> matrix)
		{
			int columns = matrix.ColumnCount ();

			T[][] transpose = new T[columns][];

			for (int i = 0; i < transpose.Length; i++)
				transpose[i] = matrix.GetColumn (i);

			return transpose;
		}

		public static T[][] GetTranspose<T> (this List<List<T>> matrix)
		{
			int columns = matrix.ColumnCount ();

			T[][] transpose = new T[columns][];

			for (int i = 0; i < transpose.Length; i++)
				transpose[i] = matrix.GetColumn (i);

			return transpose;
		}

		public static T[][] GetTranspose<T> (this List<IList<T>> matrix)
		{
			int columns = matrix.ColumnCount ();

			T[][] transpose = new T[columns][];

			for (int i = 0; i < transpose.Length; i++)
				transpose[i] = matrix.GetColumn (i);

			return transpose;
		}

		public static int ColumnCount<T> (this IList<T>[] matrix)
		{
			if (matrix.IsNullOrEmpty () || matrix[0] == null)
				return 0;

			return matrix[0].Count;
		}

		public static int ColumnCount<T> (this List<T[]> matrix)
		{
			if (matrix.IsNullOrEmpty () || matrix[0] == null)
				return 0;

			return matrix[0].Length;
		}

		public static int ColumnCount<T> (this List<List<T>> matrix)
		{
			if (matrix.IsNullOrEmpty () || matrix[0] == null)
				return 0;

			return matrix[0].Count;
		}

		public static int ColumnCount<T> (this List<IList<T>> matrix)
		{
			if (matrix.IsNullOrEmpty () || matrix[0] == null)
				return 0;

			return matrix[0].Count;
		}

		public static T[] GetColumn<T> (this IList<T>[] matrix, int index)
		{
			if (index < 0 || index >= matrix.ColumnCount ())
				throw indexOutOfRange;

			T[] columnCells = new T[matrix.Length];

			for (int i = 0; i < matrix.Length; i++)
				columnCells[i] = matrix[i][index];

			return columnCells;
		}

		public static T[] GetColumn<T> (this List<T[]> matrix, int index)
		{
			if (index < 0 || index >= matrix.ColumnCount ())
				throw indexOutOfRange;

			T[] columnCells = new T[matrix.Count];

			for (int i = 0; i < matrix.Count; i++)
				columnCells[i] = matrix[i][index];

			return columnCells;
		}

		public static T[] GetColumn<T> (this List<List<T>> matrix, int index)
		{
			if (index < 0 || index >= matrix.ColumnCount ())
				throw indexOutOfRange;

			T[] columnCells = new T[matrix.Count];

			for (int i = 0; i < matrix.Count; i++)
				columnCells[i] = matrix[i][index];

			return columnCells;
		}

		public static T[] GetColumn<T> (this List<IList<T>> matrix, int index)
		{
			if (index < 0 || index >= matrix.ColumnCount ())
				throw indexOutOfRange;

			T[] columnCells = new T[matrix.Count];

			for (int i = 0; i < matrix.Count; i++)
				columnCells[i] = matrix[i][index];

			return columnCells;
		}

		public static void SetColumn<T> (this IList<T>[] matrix, int index, IList<T> item)
		{
			if (index < 0 || index >= matrix.ColumnCount ())
				throw indexOutOfRange;

			for (int i = 0; i < matrix.Length; i++)
			{
				if (i < item.Count)
					matrix[i][index] = item[i];
				else
					matrix[i][index] = default;
			}
		}

		public static void SetColumn<T> (this List<T[]> matrix, int index, IList<T> item)
		{
			if (index < 0 || index >= matrix.ColumnCount ())
				throw indexOutOfRange;

			for (int i = 0; i < matrix.Count; i++)
			{
				if (i < item.Count)
					matrix[i][index] = item[i];
				else
					matrix[i][index] = default;
			}
		}

		public static void SetColumn<T> (this List<List<T>> matrix, int index, IList<T> item)
		{
			if (index < 0 || index >= matrix.ColumnCount ())
				throw indexOutOfRange;

			for (int i = 0; i < matrix.Count; i++)
			{
				if (i < item.Count)
					matrix[i][index] = item[i];
				else
					matrix[i][index] = default;
			}
		}

		public static void SetColumn<T> (this List<IList<T>> matrix, int index, IList<T> item)
		{
			if (index < 0 || index >= matrix.ColumnCount ())
				throw indexOutOfRange;

			for (int i = 0; i < matrix.Count; i++)
			{
				if (i < item.Count)
					matrix[i][index] = item[i];
				else
					matrix[i][index] = default;
			}
		}

		public static void AddColumn<T> (this IList<T>[] matrix, IList<T> item)
		{
			if (item.IsNullOrEmpty ())
				throw nullOrEmptyList;

			for (int i = 0; i < matrix.Length; i++)
			{
				if (i < item.Count)
					matrix[i].Add (item[i]);
				else
					matrix[i].Add (default);
			}
		}

		public static void AddColumn<T> (this List<List<T>> matrix, IList<T> item)
		{
			if (item.IsNullOrEmpty ())
				throw nullOrEmptyList;

			for (int i = 0; i < matrix.Count; i++)
			{
				if (i < item.Count)
					matrix[i].Add (item[i]);
				else
					matrix[i].Add (default);
			}
		}

		public static void AddColumn<T> (this List<IList<T>> matrix, IList<T> item)
		{
			if (item.IsNullOrEmpty ())
				throw nullOrEmptyList;

			for (int i = 0; i < matrix.Count; i++)
			{
				if (i < item.Count)
					matrix[i].Add (item[i]);
				else
					matrix[i].Add (default);
			}
		}

		public static void InsertColumn<T> (this List<T>[] matrix, int index, IList<T> item)
		{
			if (item.IsNullOrEmpty ())
				throw nullOrEmptyList;
		
			if (index < 0 || index >= matrix.ColumnCount ())
				throw indexOutOfRange;

			for (int i = 0; i < matrix.Length; i++)
			{
				if (i < item.Count)
					matrix[i].Insert (index, item[i]);
				else
					matrix[i].Insert (index, default);
			}
		}

		public static void InsertColumn<T> (this List<List<T>> matrix, int index, IList<T> item)
		{
			if (item.IsNullOrEmpty ())
				throw nullOrEmptyList;
		
			if (index < 0 || index >= matrix.ColumnCount ())
				throw indexOutOfRange;

			for (int i = 0; i < matrix.Count; i++)
			{
				if (i < item.Count)
					matrix[i].Insert (index, item[i]);
				else
					matrix[i].Insert (index, default);
			}
		}

		public static void InsertColumn<T> (this List<IList<T>> matrix, int index, IList<T> item)
		{
			if (item.IsNullOrEmpty ())
				throw nullOrEmptyList;
		
			if (index < 0 || index >= matrix.ColumnCount ())
				throw indexOutOfRange;

			for (int i = 0; i < matrix.Count; i++)
			{
				if (i < item.Count)
					matrix[i].Insert (index, item[i]);
				else
					matrix[i].Insert (index, default);
			}
		}

		public static void RemoveColumn<T> (this List<T>[] matrix, int index)
		{
			if (index < 0 || index >= matrix.ColumnCount ())
				throw indexOutOfRange;
		
			for (int i = 0; i < matrix.Length; i++)
				matrix[i].RemoveAt (index);
		}

		public static void RemoveColumn<T> (this List<List<T>> matrix, int index)
		{
			if (index < 0 || index >= matrix.ColumnCount ())
				throw indexOutOfRange;
		
			for (int i = 0; i < matrix.Count; i++)
				matrix[i].RemoveAt (index);
		}

		public static void RemoveColumn<T> (this List<IList<T>> matrix, int index)
		{
			if (index < 0 || index >= matrix.ColumnCount ())
				throw indexOutOfRange;
		
			for (int i = 0; i < matrix.Count; i++)
				matrix[i].RemoveAt (index);
		}
	}
}
