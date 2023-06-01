```mermaid
classDiagram
`IAdditionOperators&ltint, int, int>` <|-- `IBinaryInteger&ltint>`
`IAdditiveIdentity&ltint, int>` <|-- `IBinaryInteger&ltint>`
`IBinaryNumber&ltint>` <|-- `IBinaryInteger&ltint>`
`IBitwiseOperators&ltint, int, int>` <|-- `IBinaryInteger&ltint>`
`IComparable` <|-- `IBinaryInteger&ltint>`
`IComparable&ltint>` <|-- `IBinaryInteger&ltint>`
`IComparisonOperators&ltint, int>` <|-- `IBinaryInteger&ltint>`
`IDecrementOperators&ltint>` <|-- `IBinaryInteger&ltint>`
`IDivisionOperators&ltint, int, int>` <|-- `IBinaryInteger&ltint>`
`IEqualityOperators&ltint, int>` <|-- `IBinaryInteger&ltint>`
`IEquatable&ltint>` <|-- `IBinaryInteger&ltint>`
`IFormattable` <|-- `IBinaryInteger&ltint>`
`IIncrementOperators&ltint>` <|-- `IBinaryInteger&ltint>`
`IModulusOperators&ltint, int, int>` <|-- `IBinaryInteger&ltint>`
`IMultiplicativeIdentity&ltint, int>` <|-- `IBinaryInteger&ltint>`
`IMultiplyOperators&ltint, int, int>` <|-- `IBinaryInteger&ltint>`
`INumber&ltint>` <|-- `IBinaryInteger&ltint>`
`IParseable&ltint>` <|-- `IBinaryInteger&ltint>`
`IShiftOperators&ltint, int>` <|-- `IBinaryInteger&ltint>`
`ISpanFormattable` <|-- `IBinaryInteger&ltint>`
`ISpanParseable&ltint>` <|-- `IBinaryInteger&ltint>`
`ISubtractionOperators&ltint, int, int>` <|-- `IBinaryInteger&ltint>`
`IUnaryNegationOperators&ltint, int>` <|-- `IBinaryInteger&ltint>`
`IUnaryPlusOperators&ltint, int>` <|-- `IBinaryInteger&ltint>`
`IAdditionOperators&ltint, int, int>` <|-- `IBinaryNumber&ltint>`
`IAdditiveIdentity&ltint, int>` <|-- `IBinaryNumber&ltint>`
`IBitwiseOperators&ltint, int, int>` <|-- `IBinaryNumber&ltint>`
`IComparable` <|-- `IBinaryNumber&ltint>`
`IComparable&ltint>` <|-- `IBinaryNumber&ltint>`
`IComparisonOperators&ltint, int>` <|-- `IBinaryNumber&ltint>`
`IDecrementOperators&ltint>` <|-- `IBinaryNumber&ltint>`
`IDivisionOperators&ltint, int, int>` <|-- `IBinaryNumber&ltint>`
`IEqualityOperators&ltint, int>` <|-- `IBinaryNumber&ltint>`
`IEquatable&ltint>` <|-- `IBinaryNumber&ltint>`
`IFormattable` <|-- `IBinaryNumber&ltint>`
`IIncrementOperators&ltint>` <|-- `IBinaryNumber&ltint>`
`IModulusOperators&ltint, int, int>` <|-- `IBinaryNumber&ltint>`
`IMultiplicativeIdentity&ltint, int>` <|-- `IBinaryNumber&ltint>`
`IMultiplyOperators&ltint, int, int>` <|-- `IBinaryNumber&ltint>`
`INumber&ltint>` <|-- `IBinaryNumber&ltint>`
`IParseable&ltint>` <|-- `IBinaryNumber&ltint>`
`ISpanFormattable` <|-- `IBinaryNumber&ltint>`
`ISpanParseable&ltint>` <|-- `IBinaryNumber&ltint>`
`ISubtractionOperators&ltint, int, int>` <|-- `IBinaryNumber&ltint>`
`IUnaryNegationOperators&ltint, int>` <|-- `IBinaryNumber&ltint>`
`IUnaryPlusOperators&ltint, int>` <|-- `IBinaryNumber&ltint>`
`IComparable` <|-- `IComparisonOperators&ltint, int>`
`IComparable&ltint>` <|-- `IComparisonOperators&ltint, int>`
`IEqualityOperators&ltint, int>` <|-- `IComparisonOperators&ltint, int>`
`IEquatable&ltint>` <|-- `IComparisonOperators&ltint, int>`
`IEquatable&ltint>` <|-- `IEqualityOperators&ltint, int>`
`IBinaryInteger&ltint>` <|-- `int`
`IConvertible` <|-- `int`
`IMinMaxValue&ltint>` <|-- `int`
`ISignedNumber&ltint>` <|-- `int`
`IAdditionOperators&ltint, int, int>` <|-- `INumber&ltint>`
`IAdditiveIdentity&ltint, int>` <|-- `INumber&ltint>`
`IComparable` <|-- `INumber&ltint>`
`IComparable&ltint>` <|-- `INumber&ltint>`
`IComparisonOperators&ltint, int>` <|-- `INumber&ltint>`
`IDecrementOperators&ltint>` <|-- `INumber&ltint>`
`IDivisionOperators&ltint, int, int>` <|-- `INumber&ltint>`
`IEqualityOperators&ltint, int>` <|-- `INumber&ltint>`
`IEquatable&ltint>` <|-- `INumber&ltint>`
`IFormattable` <|-- `INumber&ltint>`
`IIncrementOperators&ltint>` <|-- `INumber&ltint>`
`IModulusOperators&ltint, int, int>` <|-- `INumber&ltint>`
`IMultiplicativeIdentity&ltint, int>` <|-- `INumber&ltint>`
`IMultiplyOperators&ltint, int, int>` <|-- `INumber&ltint>`
`IParseable&ltint>` <|-- `INumber&ltint>`
`ISpanFormattable` <|-- `INumber&ltint>`
`ISpanParseable&ltint>` <|-- `INumber&ltint>`
`ISubtractionOperators&ltint, int, int>` <|-- `INumber&ltint>`
`IUnaryNegationOperators&ltint, int>` <|-- `INumber&ltint>`
`IUnaryPlusOperators&ltint, int>` <|-- `INumber&ltint>`
`IAdditionOperators&ltint, int, int>` <|-- `ISignedNumber&ltint>`
`IAdditiveIdentity&ltint, int>` <|-- `ISignedNumber&ltint>`
`IComparable` <|-- `ISignedNumber&ltint>`
`IComparable&ltint>` <|-- `ISignedNumber&ltint>`
`IComparisonOperators&ltint, int>` <|-- `ISignedNumber&ltint>`
`IDecrementOperators&ltint>` <|-- `ISignedNumber&ltint>`
`IDivisionOperators&ltint, int, int>` <|-- `ISignedNumber&ltint>`
`IEqualityOperators&ltint, int>` <|-- `ISignedNumber&ltint>`
`IEquatable&ltint>` <|-- `ISignedNumber&ltint>`
`IFormattable` <|-- `ISignedNumber&ltint>`
`IIncrementOperators&ltint>` <|-- `ISignedNumber&ltint>`
`IModulusOperators&ltint, int, int>` <|-- `ISignedNumber&ltint>`
`IMultiplicativeIdentity&ltint, int>` <|-- `ISignedNumber&ltint>`
`IMultiplyOperators&ltint, int, int>` <|-- `ISignedNumber&ltint>`
`INumber&ltint>` <|-- `ISignedNumber&ltint>`
`IParseable&ltint>` <|-- `ISignedNumber&ltint>`
`ISpanFormattable` <|-- `ISignedNumber&ltint>`
`ISpanParseable&ltint>` <|-- `ISignedNumber&ltint>`
`ISubtractionOperators&ltint, int, int>` <|-- `ISignedNumber&ltint>`
`IUnaryNegationOperators&ltint, int>` <|-- `ISignedNumber&ltint>`
`IUnaryPlusOperators&ltint, int>` <|-- `ISignedNumber&ltint>`
`IFormattable` <|-- `ISpanFormattable`
`IParseable&ltint>` <|-- `ISpanParseable&ltint>`
`int` "1"  <--  "1" `IComparable` : CompareTo
`int` "1"  <--  "1" `IComparable&ltint>` : CompareTo
`int` "1"  <--  "1" `IConvertible` : ToInt32
`int` "1"  <--  "1" `int` : CompareTo
`int` "1"  <--  "1" `int` : CompareTo
`int` "1"  <--  "1" `int` : GetHashCode
class `IAdditionOperators&ltint, int, int>`
<<interface>> `IAdditionOperators&ltint, int, int>`
class `IAdditiveIdentity&ltint, int>`
<<interface>> `IAdditiveIdentity&ltint, int>`
`IAdditiveIdentity&ltint, int>` : +int AdditiveIdentity$
class `IBinaryInteger&ltint>`
<<interface>> `IBinaryInteger&ltint>`
`IBinaryInteger&ltint>` : +LeadingZeroCount(int value) int$
`IBinaryInteger&ltint>` : +PopCount(int value) int$
`IBinaryInteger&ltint>` : +RotateLeft(int value, int rotateAmount) int$
`IBinaryInteger&ltint>` : +RotateRight(int value, int rotateAmount) int$
`IBinaryInteger&ltint>` : +TrailingZeroCount(int value) int$
class `IBinaryNumber&ltint>`
<<interface>> `IBinaryNumber&ltint>`
`IBinaryNumber&ltint>` : +IsPow2(int value) bool$
`IBinaryNumber&ltint>` : +Log2(int value) int$
class `IBitwiseOperators&ltint, int, int>`
<<interface>> `IBitwiseOperators&ltint, int, int>`
class `IComparable`
<<interface>> `IComparable`
`IComparable` : +CompareTo(object obj) int*
class `IComparable&ltint>`
<<interface>> `IComparable&ltint>`
`IComparable&ltint>` : +CompareTo(int other) int*
class `IComparisonOperators&ltint, int>`
<<interface>> `IComparisonOperators&ltint, int>`
class `IConvertible`
<<interface>> `IConvertible`
`IConvertible` : +GetTypeCode() TypeCode*
`IConvertible` : +ToBoolean(IFormatProvider provider) bool*
`IConvertible` : +ToByte(IFormatProvider provider) byte*
`IConvertible` : +ToChar(IFormatProvider provider) char*
`IConvertible` : +ToDateTime(IFormatProvider provider) DateTime*
`IConvertible` : +ToDecimal(IFormatProvider provider) decimal*
`IConvertible` : +ToDouble(IFormatProvider provider) double*
`IConvertible` : +ToInt16(IFormatProvider provider) short*
`IConvertible` : +ToInt32(IFormatProvider provider) int*
`IConvertible` : +ToInt64(IFormatProvider provider) long*
`IConvertible` : +ToSByte(IFormatProvider provider) sbyte*
`IConvertible` : +ToSingle(IFormatProvider provider) float*
`IConvertible` : +ToString(IFormatProvider provider) string*
`IConvertible` : +ToType(Type conversionType, IFormatProvider provider) object*
`IConvertible` : +ToUInt16(IFormatProvider provider) ushort*
`IConvertible` : +ToUInt32(IFormatProvider provider) uint*
`IConvertible` : +ToUInt64(IFormatProvider provider) ulong*
class `IDecrementOperators&ltint>`
<<interface>> `IDecrementOperators&ltint>`
class `IDivisionOperators&ltint, int, int>`
<<interface>> `IDivisionOperators&ltint, int, int>`
class `IEqualityOperators&ltint, int>`
<<interface>> `IEqualityOperators&ltint, int>`
class `IEquatable&ltint>`
<<interface>> `IEquatable&ltint>`
`IEquatable&ltint>` : +Equals(int other) bool*
class `IFormattable`
<<interface>> `IFormattable`
`IFormattable` : +ToString(string format, IFormatProvider formatProvider) string*
class `IIncrementOperators&ltint>`
<<interface>> `IIncrementOperators&ltint>`
class `IMinMaxValue&ltint>`
<<interface>> `IMinMaxValue&ltint>`
`IMinMaxValue&ltint>` : +int MaxValue$
`IMinMaxValue&ltint>` : +int MinValue$
class `IModulusOperators&ltint, int, int>`
<<interface>> `IModulusOperators&ltint, int, int>`
class `IMultiplicativeIdentity&ltint, int>`
<<interface>> `IMultiplicativeIdentity&ltint, int>`
`IMultiplicativeIdentity&ltint, int>` : +int MultiplicativeIdentity$
class `IMultiplyOperators&ltint, int, int>`
<<interface>> `IMultiplyOperators&ltint, int, int>`
class `int`
<<struct>> `int`
`int` : +int MaxValue$
`int` : +int MinValue$
`int` : -int m_value
`int` : -int System.IAdditiveIdentity<System.Int32,System.Int32>.AdditiveIdentity$
`int` : -int System.IMinMaxValue<System.Int32>.MaxValue$
`int` : -int System.IMinMaxValue<System.Int32>.MinValue$
`int` : -int System.IMultiplicativeIdentity<System.Int32,System.Int32>.MultiplicativeIdentity$
`int` : -int System.INumber<System.Int32>.One$
`int` : -int System.INumber<System.Int32>.Zero$
`int` : -int System.ISignedNumber<System.Int32>.NegativeOne$
`int` : +CompareTo(object value) int
`int` : +CompareTo(int value) int
`int` : -Create(TOther value) int$
`int` : +Equals(object obj) bool
`int` : +Equals(int obj) bool
`int` : -Finalize() void
`int` : +GetHashCode() int
`int` : +GetType() Type
`int` : +GetTypeCode() TypeCode
`int` : -MemberwiseClone() object
`int` : +Parse(string s) int$
`int` : +Parse(string s, NumberStyles style) int$
`int` : +Parse(string s, IFormatProvider provider) int$
`int` : +Parse(string s, NumberStyles style, IFormatProvider provider) int$
`int` : +Parse(ReadOnlySpan&ltchar> s, NumberStyles style, IFormatProvider provider) int$
`int` : -System.IAdditionOperators<System.Int32,System.Int32,System.Int32>.op_Addition(int left, int right) int$
`int` : -System.IBinaryInteger<System.Int32>.LeadingZeroCount(int value) int$
`int` : -System.IBinaryInteger<System.Int32>.PopCount(int value) int$
`int` : -System.IBinaryInteger<System.Int32>.RotateLeft(int value, int rotateAmount) int$
`int` : -System.IBinaryInteger<System.Int32>.RotateRight(int value, int rotateAmount) int$
`int` : -System.IBinaryInteger<System.Int32>.TrailingZeroCount(int value) int$
`int` : -System.IBinaryNumber<System.Int32>.IsPow2(int value) bool$
`int` : -System.IBinaryNumber<System.Int32>.Log2(int value) int$
`int` : -System.IBitwiseOperators<System.Int32,System.Int32,System.Int32>.op_BitwiseAnd(int left, int right) int$
`int` : -System.IBitwiseOperators<System.Int32,System.Int32,System.Int32>.op_BitwiseOr(int left, int right) int$
`int` : -System.IBitwiseOperators<System.Int32,System.Int32,System.Int32>.op_ExclusiveOr(int left, int right) int$
`int` : -System.IBitwiseOperators<System.Int32,System.Int32,System.Int32>.op_OnesComplement(int value) int$
`int` : -System.IComparisonOperators<System.Int32,System.Int32>.op_GreaterThan(int left, int right) bool$
`int` : -System.IComparisonOperators<System.Int32,System.Int32>.op_GreaterThanOrEqual(int left, int right) bool$
`int` : -System.IComparisonOperators<System.Int32,System.Int32>.op_LessThan(int left, int right) bool$
`int` : -System.IComparisonOperators<System.Int32,System.Int32>.op_LessThanOrEqual(int left, int right) bool$
`int` : -System.IConvertible.ToBoolean(IFormatProvider provider) bool
`int` : -System.IConvertible.ToByte(IFormatProvider provider) byte
`int` : -System.IConvertible.ToChar(IFormatProvider provider) char
`int` : -System.IConvertible.ToDateTime(IFormatProvider provider) DateTime
`int` : -System.IConvertible.ToDecimal(IFormatProvider provider) decimal
`int` : -System.IConvertible.ToDouble(IFormatProvider provider) double
`int` : -System.IConvertible.ToInt16(IFormatProvider provider) short
`int` : -System.IConvertible.ToInt32(IFormatProvider provider) int
`int` : -System.IConvertible.ToInt64(IFormatProvider provider) long
`int` : -System.IConvertible.ToSByte(IFormatProvider provider) sbyte
`int` : -System.IConvertible.ToSingle(IFormatProvider provider) float
`int` : -System.IConvertible.ToType(Type type, IFormatProvider provider) object
`int` : -System.IConvertible.ToUInt16(IFormatProvider provider) ushort
`int` : -System.IConvertible.ToUInt32(IFormatProvider provider) uint
`int` : -System.IConvertible.ToUInt64(IFormatProvider provider) ulong
`int` : -System.IDecrementOperators<System.Int32>.op_Decrement(int value) int$
`int` : -System.IDivisionOperators<System.Int32,System.Int32,System.Int32>.op_Division(int left, int right) int$
`int` : -System.IEqualityOperators<System.Int32,System.Int32>.op_Equality(int left, int right) bool$
`int` : -System.IEqualityOperators<System.Int32,System.Int32>.op_Inequality(int left, int right) bool$
`int` : -System.IIncrementOperators<System.Int32>.op_Increment(int value) int$
`int` : -System.IModulusOperators<System.Int32,System.Int32,System.Int32>.op_Modulus(int left, int right) int$
`int` : -System.IMultiplyOperators<System.Int32,System.Int32,System.Int32>.op_Multiply(int left, int right) int$
`int` : -System.INumber<System.Int32>.Abs(int value) int$
`int` : -System.INumber<System.Int32>.Clamp(int value, int min, int max) int$
`int` : -System.INumber<System.Int32>.Create(TOther value) int$
`int` : -System.INumber<System.Int32>.CreateSaturating(TOther value) int$
`int` : -System.INumber<System.Int32>.CreateTruncating(TOther value) int$
`int` : -System.INumber<System.Int32>.DivRem(int left, int right) (int, int)$
`int` : -System.INumber<System.Int32>.Max(int x, int y) int$
`int` : -System.INumber<System.Int32>.Min(int x, int y) int$
`int` : -System.INumber<System.Int32>.Parse(string s, NumberStyles style, IFormatProvider provider) int$
`int` : -System.INumber<System.Int32>.Parse(ReadOnlySpan&ltchar> s, NumberStyles style, IFormatProvider provider) int$
`int` : -System.INumber<System.Int32>.Sign(int value) int$
`int` : -System.INumber<System.Int32>.TryCreate(TOther value, ref int result) bool$
`int` : -System.INumber<System.Int32>.TryParse(string s, NumberStyles style, IFormatProvider provider, ref int result) bool$
`int` : -System.INumber<System.Int32>.TryParse(ReadOnlySpan&ltchar> s, NumberStyles style, IFormatProvider provider, ref int result) bool$
`int` : -System.IParseable<System.Int32>.Parse(string s, IFormatProvider provider) int$
`int` : -System.IParseable<System.Int32>.TryParse(string s, IFormatProvider provider, ref int result) bool$
`int` : -System.IShiftOperators<System.Int32,System.Int32>.op_LeftShift(int value, int shiftAmount) int$
`int` : -System.IShiftOperators<System.Int32,System.Int32>.op_RightShift(int value, int shiftAmount) int$
`int` : -System.ISpanParseable<System.Int32>.Parse(ReadOnlySpan&ltchar> s, IFormatProvider provider) int$
`int` : -System.ISpanParseable<System.Int32>.TryParse(ReadOnlySpan&ltchar> s, IFormatProvider provider, ref int result) bool$
`int` : -System.ISubtractionOperators<System.Int32,System.Int32,System.Int32>.op_Subtraction(int left, int right) int$
`int` : -System.IUnaryNegationOperators<System.Int32,System.Int32>.op_UnaryNegation(int value) int$
`int` : -System.IUnaryPlusOperators<System.Int32,System.Int32>.op_UnaryPlus(int value) int$
`int` : +ToString() string
`int` : +ToString(string format) string
`int` : +ToString(IFormatProvider provider) string
`int` : +ToString(string format, IFormatProvider provider) string
`int` : +TryFormat(Span&ltchar> destination, ref int charsWritten, ReadOnlySpan&ltchar> format, IFormatProvider provider) bool
`int` : +TryParse(string s, ref int result) bool$
`int` : +TryParse(ReadOnlySpan&ltchar> s, ref int result) bool$
`int` : +TryParse(string s, NumberStyles style, IFormatProvider provider, ref int result) bool$
`int` : +TryParse(ReadOnlySpan&ltchar> s, NumberStyles style, IFormatProvider provider, ref int result) bool$
class `INumber&ltint>`
<<interface>> `INumber&ltint>`
`INumber&ltint>` : +int One$
`INumber&ltint>` : +int Zero$
`INumber&ltint>` : +Abs(int value) int$
`INumber&ltint>` : +Clamp(int value, int min, int max) int$
`INumber&ltint>` : +Create(TOther value) int$
`INumber&ltint>` : +CreateSaturating(TOther value) int$
`INumber&ltint>` : +CreateTruncating(TOther value) int$
`INumber&ltint>` : +DivRem(int left, int right) (int, int)$
`INumber&ltint>` : +Max(int x, int y) int$
`INumber&ltint>` : +Min(int x, int y) int$
`INumber&ltint>` : +Parse(string s, NumberStyles style, IFormatProvider provider) int$
`INumber&ltint>` : +Parse(ReadOnlySpan&ltchar> s, NumberStyles style, IFormatProvider provider) int$
`INumber&ltint>` : +Sign(int value) int$
`INumber&ltint>` : +TryCreate(TOther value, ref int result) bool$
`INumber&ltint>` : +TryParse(string s, NumberStyles style, IFormatProvider provider, ref int result) bool$
`INumber&ltint>` : +TryParse(ReadOnlySpan&ltchar> s, NumberStyles style, IFormatProvider provider, ref int result) bool$
class `IParseable&ltint>`
<<interface>> `IParseable&ltint>`
`IParseable&ltint>` : +Parse(string s, IFormatProvider provider) int$
`IParseable&ltint>` : +TryParse(string s, IFormatProvider provider, ref int result) bool$
class `IShiftOperators&ltint, int>`
<<interface>> `IShiftOperators&ltint, int>`
class `ISignedNumber&ltint>`
<<interface>> `ISignedNumber&ltint>`
`ISignedNumber&ltint>` : +int NegativeOne$
class `ISpanFormattable`
<<interface>> `ISpanFormattable`
`ISpanFormattable` : +TryFormat(Span&ltchar> destination, ref int charsWritten, ReadOnlySpan&ltchar> format, IFormatProvider provider) bool*
class `ISpanParseable&ltint>`
<<interface>> `ISpanParseable&ltint>`
`ISpanParseable&ltint>` : +Parse(ReadOnlySpan&ltchar> s, IFormatProvider provider) int$
`ISpanParseable&ltint>` : +TryParse(ReadOnlySpan&ltchar> s, IFormatProvider provider, ref int result) bool$
class `ISubtractionOperators&ltint, int, int>`
<<interface>> `ISubtractionOperators&ltint, int, int>`
class `IUnaryNegationOperators&ltint, int>`
<<interface>> `IUnaryNegationOperators&ltint, int>`
class `IUnaryPlusOperators&ltint, int>`
<<interface>> `IUnaryPlusOperators&ltint, int>`
```
