#Precedence Rules for framework equality checking

1. Is it a class (reference type)

  * Does it implement IEquatable<T> for itself - use it
  * Does it override Equals - use it
  * Reference equality check

2. Is it a struct (value type)

  * Does it override Equals - use it
  * Reflective field by field equality check
