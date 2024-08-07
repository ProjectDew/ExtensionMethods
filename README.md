# ExtensionMethods

A couple of classes created for personal use containing some extension methods.

- ***Extensions***

  - ***Round (3 overloads)***: returns a vector with all its values rounded.
  - ***IsNullOrEmpty***: returns true if a string is null or empty.
  - ***IsNullOrEmpty (generic)***: returns true if a generic collection is null or empty.
  - ***Copy (generic, 2 overloads)***: returns an array containing the copied values of a generic collection.
  - ***Move (generic)***: moves an element from one position to another within an array or generic list.

 - ***MatrixExtensions***: class containing extensions for matrix-like structures. Please note that, while these methods extend jagged arrays and lists, it’s asumed that all the "columns" contain the same amount of elements.

   - ***GetTranspose (generic, 4 overloads)***: returns the transpose.
   - ***ColumnCount (generic, 4 overloads)***: returns the number of columns.
   - ***GetColumn (generic, 4 overloads)***: returns the column at the specified index.
   - ***SetColumn (generic, 4 overloads)***: copies the values of a given generic IList into the specified column.
   - ***AddColumn (generic, 3 overloads)***: creates a new column at the end and copies the values of a given generic IList into it.
   - ***InsertColumn (generic, 3 overloads)***: creates a new column at the specified index and copies the values of a given generic IList into it.
   - ***RemoveColumn (generic, 3 overloads)***: removes the column at the specified index.
