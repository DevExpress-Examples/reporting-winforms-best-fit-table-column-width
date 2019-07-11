Imports System
Imports System.Diagnostics.CodeAnalysis

Namespace dxSample
	''' <summary>
	''' Compares the first 7 digits of two float values.
	''' </summary>
	Public Module FloatComparer
		#Region "Constants"

		Private Const FloatZero As Single = 0.0F

		''' <summary>
		''' Defines the Epsilon for comparing a value with zero.
		''' </summary>
		Friend Const ZeroCompareEpsilon As Single = 0.0000001F

		''' <summary>
		''' The number of digits to compare two float values.
		''' </summary>
		Private Const CompareDigitsCount As Integer = 7

		Private Const DecimalSystemBase As Integer = 10

		''' <summary>
		''' The equality multiplier.
		''' </summary>
		Friend ReadOnly EqualityMultiplier As Single = CSng(Math.Pow(DecimalSystemBase, -CompareDigitsCount))

		#End Region

		#Region "Methods"

		''' <summary>
		''' Compares the specified float values.
		''' </summary>
		''' <param name="x">The first float value.</param>
		''' <param name="y">The second float value.</param>
		''' <param name="digits">The digits.</param>
		''' <returns>
		''' 0 if the values are equal for the given number of digits, -1 if x is smaller than y, +1 if x is larger than y.
		''' </returns>
		<System.Runtime.CompilerServices.Extension> _
		Public Function Compare(ByVal x As Single, ByVal y As Single, ByVal digits? As Integer) As Integer
			If digits.HasValue Then
				Return Compare(x, y, CSng(Math.Pow(DecimalSystemBase, -digits.Value)))
			Else
				Return Compare(x, y)
			End If
		End Function

		''' <summary>
		''' Compares two float values with
		''' an dynamic epsilon
		''' If one of the float values is 0.0 it compares directly against Epsilon.
		''' </summary>
		''' <param name="x">The first float value.</param>
		''' <param name="y">The second float values.</param>
		''' <returns>
		''' Returns 0 if the first 14 digits are equal, -1 if x is smaller than y, +1 if x is larger than y.
		''' </returns>
		<SuppressMessage("ReSharper", "CompareOfFloatsByEqualityOperator", Justification := "It is correct here.GüHa")>
		<SuppressMessage("Reliability", "S1244:Floating point numbers should not be tested for equality", Justification := "Special case here.GüHa")>
		<SuppressMessage("Maintainability", "S1541:Methods should not be too complex", Justification := "Better readability.GüHa")>
		<System.Runtime.CompilerServices.Extension> _
		Public Function Compare(ByVal x As Single, ByVal y As Single, Optional ByVal equalityMultiplier? As Single = Nothing) As Integer
			If Single.IsPositiveInfinity(x) Then
				Return If(Single.IsPositiveInfinity(y), 0, 1)
			End If

			If Single.IsNegativeInfinity(x) Then
				Return If(Single.IsNegativeInfinity(y), 0, -1)
			End If

			If x = 0.0 AndAlso Math.Abs(y) < ZeroCompareEpsilon Then
				Return 0
			End If

			If y = 0.0 AndAlso Math.Abs(x) < ZeroCompareEpsilon Then
				Return 0
			End If

			If Math.Abs(x - y) <= Math.Abs(x * (If(equalityMultiplier, FloatComparer.EqualityMultiplier))) Then
				Return 0
			End If

			Return If(x < y, -1, 1)
		End Function

		''' <summary>
		''' Compares two float values with a dynamic epsilon and digits for rounding.
		''' </summary>
		''' <param name="x">The first float value.</param>
		''' <param name="y">The second float values.</param>
		''' <param name="digits">The digits.</param>
		''' <returns>
		''' <c>true</c> if the first values are equal with the given precision; otherwise, <c>false</c>.
		''' </returns>
		<System.Runtime.CompilerServices.Extension> _
		Public Function IsEqual(ByVal x As Single, ByVal y As Single, ByVal digits? As Integer) As Boolean
			Return Compare(x, y, digits) = 0
		End Function

		''' <summary>
		''' Determines whether the specified float value is equal to the second value.
		''' </summary>
		''' <param name="x">The first float value.</param>
		''' <param name="y">The second float values.</param>
		''' <returns>
		''' <c>true</c> if the first values are equal; otherwise, <c>false</c>.
		''' </returns>
		<System.Runtime.CompilerServices.Extension> _
		Public Function IsEqual(ByVal x As Single, ByVal y As Single) As Boolean
			Return Compare(x, y) = 0
		End Function

		''' <summary>
		''' Determines whether the specified float value is equal to the second value.
		''' </summary>
		''' <param name="x">The first float value.</param>
		''' <param name="y">The second float? values.</param>
		''' <returns>
		''' <c>true</c> if the first values are equal; otherwise, <c>false</c>.
		''' </returns>
		<System.Runtime.CompilerServices.Extension> _
		Public Function IsEqual(ByVal x As Single, ByVal y? As Single) As Boolean
			If Not y.HasValue Then
				Return False
			End If

			Return Compare(x, y.Value) = 0
		End Function

		''' <summary>
		''' Determines whether the specified float value is larger than the second.
		''' </summary>
		''' <param name="x">The first float value.</param>
		''' <param name="y">The second float values.</param>
		''' <returns>
		''' <c>true</c> if the first value is larger than the second value; otherwise, <c>false</c>.
		''' </returns>
		<System.Runtime.CompilerServices.Extension> _
		Public Function IsLarger(ByVal x As Single, ByVal y As Single) As Boolean
			Return Compare(x, y) > 0
		End Function

		''' <summary>
		''' Determines whether the specified float value is larger than the second.
		''' </summary>
		''' <param name="x">The first float value.</param>
		''' <param name="y">The second float? values.</param>
		''' <returns>
		''' <c>true</c> if the first value is larger than the second value; otherwise, <c>false</c>.
		''' </returns>
		<System.Runtime.CompilerServices.Extension> _
		Public Function IsLarger(ByVal x As Single, ByVal y? As Single) As Boolean
			If Not y.HasValue Then
				Return False
			End If

			Return Compare(x, y.Value) > 0
		End Function

		''' <summary>
		''' Determines whether the first float value is larger than the second.
		''' </summary>
		''' <param name="x">The first float value.</param>
		''' <param name="y">The second float values.</param>
		''' <returns>
		''' <c>true</c> if the first value is larger than or equal to the second value; otherwise, <c>false</c>.
		''' </returns>
		<System.Runtime.CompilerServices.Extension> _
		Public Function IsLargerOrEqual(ByVal x As Single, ByVal y As Single) As Boolean
			Return Compare(x, y) >= 0
		End Function

		''' <summary>
		''' Determines whether the first float value is larger than the second.
		''' </summary>
		''' <param name="x">The first float value.</param>
		''' <param name="y">The second float? values.</param>
		''' <returns>
		''' <c>true</c> if the first value is larger than or equal to the second value; otherwise, <c>false</c>.
		''' </returns>
		<System.Runtime.CompilerServices.Extension> _
		Public Function IsLargerOrEqual(ByVal x As Single, ByVal y? As Single) As Boolean
			If Not y.HasValue Then
				Return False
			End If

			Return Compare(x, y.Value) >= 0
		End Function

		''' <summary>
		''' Determines whether the specified float value is smaller than the second value.
		''' </summary>
		''' <param name="x">The first float value.</param>
		''' <param name="y">The second float values.</param>
		''' <returns>
		''' <c>true</c> if the first value is smaller than the second value; otherwise, <c>false</c>.
		''' </returns>
		<System.Runtime.CompilerServices.Extension> _
		Public Function IsSmaller(ByVal x As Single, ByVal y As Single) As Boolean
			Return Compare(x, y) < 0
		End Function

		''' <summary>
		''' Determines whether the specified float value is smaller than the second value.
		''' </summary>
		''' <param name="x">The first float value.</param>
		''' <param name="y">The second float? values.</param>
		''' <returns>
		''' <c>true</c> if the first value is smaller than the second value; otherwise, <c>false</c>.
		''' </returns>
		<System.Runtime.CompilerServices.Extension> _
		Public Function IsSmaller(ByVal x As Single, ByVal y? As Single) As Boolean
			If Not y.HasValue Then
				Return False
			End If

			Return Compare(x, y.Value) < 0
		End Function

		''' <summary>
		''' Determines whether the first float value is smaller than the second value.
		''' </summary>
		''' <param name="x">The first float value.</param>
		''' <param name="y">The second float values.</param>
		''' <returns>
		''' <c>true</c> if the first value is smaller than or equal to the second value; otherwise, <c>false</c>.
		''' </returns>
		<System.Runtime.CompilerServices.Extension> _
		Public Function IsSmallerOrEqual(ByVal x As Single, ByVal y As Single) As Boolean
			Return Compare(x, y) <= 0
		End Function

		''' <summary>
		''' Determines whether the first float value is smaller than the second value.
		''' </summary>
		''' <param name="x">The first float value.</param>
		''' <param name="y">The second float? values.</param>
		''' <returns>
		''' <c>true</c> if the first value is smaller than or equal to the second value; otherwise, <c>false</c>.
		''' </returns>
		<System.Runtime.CompilerServices.Extension> _
		Public Function IsSmallerOrEqual(ByVal x As Single, ByVal y? As Single) As Boolean
			If Not y.HasValue Then
				Return False
			End If

			Return Compare(x, y.Value) <= 0
		End Function

		''' <summary>
		''' Determines whether the specified float value is positive.
		''' </summary>
		''' <param name="x">The float value.</param>
		''' <returns>
		'''   <c>true</c> if the specified x is positive; otherwise, <c>false</c>.
		''' </returns>
		<System.Runtime.CompilerServices.Extension> _
		Public Function IsPositive(ByVal x As Single) As Boolean
			Return Compare(x, FloatZero) > 0
		End Function

		''' <summary>
		''' Determines whether the given value is negative.
		''' </summary>
		''' <param name="x">The float value.</param>
		''' <returns>
		''' <c>true</c> if the given value is negative.
		''' </returns>
		<System.Runtime.CompilerServices.Extension> _
		Public Function IsNegative(ByVal x As Single) As Boolean
			Return Compare(x, FloatZero) < 0
		End Function

		''' <summary>
		''' Determines whether the given value is negative or zero.
		''' </summary>
		''' <param name="x">The float value.</param>
		''' <returns>
		''' <c>true</c> if the given value is negative or zero.
		''' </returns>
		<System.Runtime.CompilerServices.Extension> _
		Public Function IsNegativeOrZero(ByVal x As Single) As Boolean
			Return Compare(x, FloatZero) <= 0
		End Function

		''' <summary>
		''' Determines whether the specified float value is zero.
		''' </summary>
		''' <param name="x">The float value.</param>
		''' <returns>
		''' <c>true</c> if the specified x is zero; otherwise, <c>false</c>.
		''' </returns>
		<System.Runtime.CompilerServices.Extension> _
		Public Function IsZero(ByVal x As Single) As Boolean
			Return IsEqual(x, FloatZero)
		End Function

		''' <summary>
		''' Determines whether the specified x is nan.
		''' </summary>
		''' <param name="x">The float value.</param>
		''' <returns>
		'''   <c>true</c> if the specified x is nan; otherwise, <c>false</c>.
		''' </returns>
		<System.Runtime.CompilerServices.Extension> _
		Public Function IsNan(ByVal x As Single) As Boolean
			Return Single.IsNaN(x)
		End Function

		''' <summary>
		''' Determines whether the specified x is infinity.
		''' </summary>
		''' <param name="x">The float value.</param>
		''' <returns>
		'''   <c>true</c> if the specified x is infinity; otherwise, <c>false</c>.
		''' </returns>
		<System.Runtime.CompilerServices.Extension> _
		Public Function IsInfinity(ByVal x As Single) As Boolean
			Return Single.IsInfinity(x)
		End Function

		#End Region
	End Module
End Namespace
