﻿namespace global

type NonEmptyList<'T> = 'T * 'T list

[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module NonEmptyList =
  val head: NonEmptyList<'T> -> 'T
  val make: 'T -> 'T list -> NonEmptyList<'T>
  val ofSeq: 'T seq -> NonEmptyList<'T>
  val cons: 'T -> NonEmptyList<'T> -> NonEmptyList<'T>
  val singleton: 'T -> NonEmptyList<'T>
  val append: NonEmptyList<'T> -> NonEmptyList<'T> -> NonEmptyList<'T>
  val appendSeq: NonEmptyList<'T> -> 'T seq -> NonEmptyList<'T>
  val reduce: ('T -> 'T -> 'T) -> NonEmptyList<'T> -> 'T
  val map: ('T -> 'U) -> NonEmptyList<'T> -> NonEmptyList<'U>
  val iter: ('T -> unit) -> NonEmptyList<'T> -> unit
  val toSeq: NonEmptyList<'T> -> 'T seq
  val toList: NonEmptyList<'T> -> 'T list
  val forall: ('T -> bool) -> NonEmptyList<'T> -> bool
