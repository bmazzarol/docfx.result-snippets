```mermaid
classDiagram
`IAdditionOperators&ltint, int, int>` <|-- `IBinaryInteger&ltint>`
`IAdditiveIdentity&ltint, int>` <|-- `IBinaryInteger&ltint>`
`IBinaryNumber&ltint>` <|-- `IBinaryInteger&ltint>`
`IBitwiseOperators&ltint, int, int>` <|-- `IBinaryInteger&ltint>`
`IComparable` <|-- `IBinaryInteger&ltint>`
`IComparable&ltint>` <|-- `IBinaryInteger&ltint>`
`IComparisonOperators&ltint, int, bool>` <|-- `IBinaryInteger&ltint>`
`IDecrementOperators&ltint>` <|-- `IBinaryInteger&ltint>`
`IDivisionOperators&ltint, int, int>` <|-- `IBinaryInteger&ltint>`
`IEqualityOperators&ltint, int, bool>` <|-- `IBinaryInteger&ltint>`
`IEquatable&ltint>` <|-- `IBinaryInteger&ltint>`
`IFormattable` <|-- `IBinaryInteger&ltint>`
`IIncrementOperators&ltint>` <|-- `IBinaryInteger&ltint>`
`IModulusOperators&ltint, int, int>` <|-- `IBinaryInteger&ltint>`
`IMultiplicativeIdentity&ltint, int>` <|-- `IBinaryInteger&ltint>`
`IMultiplyOperators&ltint, int, int>` <|-- `IBinaryInteger&ltint>`
`INumber&ltint>` <|-- `IBinaryInteger&ltint>`
`INumberBase&ltint>` <|-- `IBinaryInteger&ltint>`
`IParsable&ltint>` <|-- `IBinaryInteger&ltint>`
`IShiftOperators&ltint, int, int>` <|-- `IBinaryInteger&ltint>`
`ISpanFormattable` <|-- `IBinaryInteger&ltint>`
`ISpanParsable&ltint>` <|-- `IBinaryInteger&ltint>`
`ISubtractionOperators&ltint, int, int>` <|-- `IBinaryInteger&ltint>`
`IUnaryNegationOperators&ltint, int>` <|-- `IBinaryInteger&ltint>`
`IUnaryPlusOperators&ltint, int>` <|-- `IBinaryInteger&ltint>`
`IUtf8SpanFormattable` <|-- `IBinaryInteger&ltint>`
`IUtf8SpanParsable&ltint>` <|-- `IBinaryInteger&ltint>`
`IAdditionOperators&ltint, int, int>` <|-- `IBinaryIntegerParseAndFormatInfo&ltint>`
`IAdditiveIdentity&ltint, int>` <|-- `IBinaryIntegerParseAndFormatInfo&ltint>`
`IBinaryInteger&ltint>` <|-- `IBinaryIntegerParseAndFormatInfo&ltint>`
`IBinaryNumber&ltint>` <|-- `IBinaryIntegerParseAndFormatInfo&ltint>`
`IBitwiseOperators&ltint, int, int>` <|-- `IBinaryIntegerParseAndFormatInfo&ltint>`
`IComparable` <|-- `IBinaryIntegerParseAndFormatInfo&ltint>`
`IComparable&ltint>` <|-- `IBinaryIntegerParseAndFormatInfo&ltint>`
`IComparisonOperators&ltint, int, bool>` <|-- `IBinaryIntegerParseAndFormatInfo&ltint>`
`IDecrementOperators&ltint>` <|-- `IBinaryIntegerParseAndFormatInfo&ltint>`
`IDivisionOperators&ltint, int, int>` <|-- `IBinaryIntegerParseAndFormatInfo&ltint>`
`IEqualityOperators&ltint, int, bool>` <|-- `IBinaryIntegerParseAndFormatInfo&ltint>`
`IEquatable&ltint>` <|-- `IBinaryIntegerParseAndFormatInfo&ltint>`
`IFormattable` <|-- `IBinaryIntegerParseAndFormatInfo&ltint>`
`IIncrementOperators&ltint>` <|-- `IBinaryIntegerParseAndFormatInfo&ltint>`
`IMinMaxValue&ltint>` <|-- `IBinaryIntegerParseAndFormatInfo&ltint>`
`IModulusOperators&ltint, int, int>` <|-- `IBinaryIntegerParseAndFormatInfo&ltint>`
`IMultiplicativeIdentity&ltint, int>` <|-- `IBinaryIntegerParseAndFormatInfo&ltint>`
`IMultiplyOperators&ltint, int, int>` <|-- `IBinaryIntegerParseAndFormatInfo&ltint>`
`INumber&ltint>` <|-- `IBinaryIntegerParseAndFormatInfo&ltint>`
`INumberBase&ltint>` <|-- `IBinaryIntegerParseAndFormatInfo&ltint>`
`IParsable&ltint>` <|-- `IBinaryIntegerParseAndFormatInfo&ltint>`
`IShiftOperators&ltint, int, int>` <|-- `IBinaryIntegerParseAndFormatInfo&ltint>`
`ISpanFormattable` <|-- `IBinaryIntegerParseAndFormatInfo&ltint>`
`ISpanParsable&ltint>` <|-- `IBinaryIntegerParseAndFormatInfo&ltint>`
`ISubtractionOperators&ltint, int, int>` <|-- `IBinaryIntegerParseAndFormatInfo&ltint>`
`IUnaryNegationOperators&ltint, int>` <|-- `IBinaryIntegerParseAndFormatInfo&ltint>`
`IUnaryPlusOperators&ltint, int>` <|-- `IBinaryIntegerParseAndFormatInfo&ltint>`
`IUtf8SpanFormattable` <|-- `IBinaryIntegerParseAndFormatInfo&ltint>`
`IUtf8SpanParsable&ltint>` <|-- `IBinaryIntegerParseAndFormatInfo&ltint>`
`IAdditionOperators&ltint, int, int>` <|-- `IBinaryNumber&ltint>`
`IAdditiveIdentity&ltint, int>` <|-- `IBinaryNumber&ltint>`
`IBitwiseOperators&ltint, int, int>` <|-- `IBinaryNumber&ltint>`
`IComparable` <|-- `IBinaryNumber&ltint>`
`IComparable&ltint>` <|-- `IBinaryNumber&ltint>`
`IComparisonOperators&ltint, int, bool>` <|-- `IBinaryNumber&ltint>`
`IDecrementOperators&ltint>` <|-- `IBinaryNumber&ltint>`
`IDivisionOperators&ltint, int, int>` <|-- `IBinaryNumber&ltint>`
`IEqualityOperators&ltint, int, bool>` <|-- `IBinaryNumber&ltint>`
`IEquatable&ltint>` <|-- `IBinaryNumber&ltint>`
`IFormattable` <|-- `IBinaryNumber&ltint>`
`IIncrementOperators&ltint>` <|-- `IBinaryNumber&ltint>`
`IModulusOperators&ltint, int, int>` <|-- `IBinaryNumber&ltint>`
`IMultiplicativeIdentity&ltint, int>` <|-- `IBinaryNumber&ltint>`
`IMultiplyOperators&ltint, int, int>` <|-- `IBinaryNumber&ltint>`
`INumber&ltint>` <|-- `IBinaryNumber&ltint>`
`INumberBase&ltint>` <|-- `IBinaryNumber&ltint>`
`IParsable&ltint>` <|-- `IBinaryNumber&ltint>`
`ISpanFormattable` <|-- `IBinaryNumber&ltint>`
`ISpanParsable&ltint>` <|-- `IBinaryNumber&ltint>`
`ISubtractionOperators&ltint, int, int>` <|-- `IBinaryNumber&ltint>`
`IUnaryNegationOperators&ltint, int>` <|-- `IBinaryNumber&ltint>`
`IUnaryPlusOperators&ltint, int>` <|-- `IBinaryNumber&ltint>`
`IUtf8SpanFormattable` <|-- `IBinaryNumber&ltint>`
`IUtf8SpanParsable&ltint>` <|-- `IBinaryNumber&ltint>`
`IEqualityOperators&ltint, int, bool>` <|-- `IComparisonOperators&ltint, int, bool>`
`IBinaryIntegerParseAndFormatInfo&ltint>` <|-- `int`
`IConvertible` <|-- `int`
`ISignedNumber&ltint>` <|-- `int`
`IAdditionOperators&ltint, int, int>` <|-- `INumber&ltint>`
`IAdditiveIdentity&ltint, int>` <|-- `INumber&ltint>`
`IComparable` <|-- `INumber&ltint>`
`IComparable&ltint>` <|-- `INumber&ltint>`
`IComparisonOperators&ltint, int, bool>` <|-- `INumber&ltint>`
`IDecrementOperators&ltint>` <|-- `INumber&ltint>`
`IDivisionOperators&ltint, int, int>` <|-- `INumber&ltint>`
`IEqualityOperators&ltint, int, bool>` <|-- `INumber&ltint>`
`IEquatable&ltint>` <|-- `INumber&ltint>`
`IFormattable` <|-- `INumber&ltint>`
`IIncrementOperators&ltint>` <|-- `INumber&ltint>`
`IModulusOperators&ltint, int, int>` <|-- `INumber&ltint>`
`IMultiplicativeIdentity&ltint, int>` <|-- `INumber&ltint>`
`IMultiplyOperators&ltint, int, int>` <|-- `INumber&ltint>`
`INumberBase&ltint>` <|-- `INumber&ltint>`
`IParsable&ltint>` <|-- `INumber&ltint>`
`ISpanFormattable` <|-- `INumber&ltint>`
`ISpanParsable&ltint>` <|-- `INumber&ltint>`
`ISubtractionOperators&ltint, int, int>` <|-- `INumber&ltint>`
`IUnaryNegationOperators&ltint, int>` <|-- `INumber&ltint>`
`IUnaryPlusOperators&ltint, int>` <|-- `INumber&ltint>`
`IUtf8SpanFormattable` <|-- `INumber&ltint>`
`IUtf8SpanParsable&ltint>` <|-- `INumber&ltint>`
`IAdditionOperators&ltint, int, int>` <|-- `INumberBase&ltint>`
`IAdditiveIdentity&ltint, int>` <|-- `INumberBase&ltint>`
`IDecrementOperators&ltint>` <|-- `INumberBase&ltint>`
`IDivisionOperators&ltint, int, int>` <|-- `INumberBase&ltint>`
`IEqualityOperators&ltint, int, bool>` <|-- `INumberBase&ltint>`
`IEquatable&ltint>` <|-- `INumberBase&ltint>`
`IFormattable` <|-- `INumberBase&ltint>`
`IIncrementOperators&ltint>` <|-- `INumberBase&ltint>`
`IMultiplicativeIdentity&ltint, int>` <|-- `INumberBase&ltint>`
`IMultiplyOperators&ltint, int, int>` <|-- `INumberBase&ltint>`
`IParsable&ltint>` <|-- `INumberBase&ltint>`
`ISpanFormattable` <|-- `INumberBase&ltint>`
`ISpanParsable&ltint>` <|-- `INumberBase&ltint>`
`ISubtractionOperators&ltint, int, int>` <|-- `INumberBase&ltint>`
`IUnaryNegationOperators&ltint, int>` <|-- `INumberBase&ltint>`
`IUnaryPlusOperators&ltint, int>` <|-- `INumberBase&ltint>`
`IUtf8SpanFormattable` <|-- `INumberBase&ltint>`
`IUtf8SpanParsable&ltint>` <|-- `INumberBase&ltint>`
`IAdditionOperators&ltint, int, int>` <|-- `ISignedNumber&ltint>`
`IAdditiveIdentity&ltint, int>` <|-- `ISignedNumber&ltint>`
`IDecrementOperators&ltint>` <|-- `ISignedNumber&ltint>`
`IDivisionOperators&ltint, int, int>` <|-- `ISignedNumber&ltint>`
`IEqualityOperators&ltint, int, bool>` <|-- `ISignedNumber&ltint>`
`IEquatable&ltint>` <|-- `ISignedNumber&ltint>`
`IFormattable` <|-- `ISignedNumber&ltint>`
`IIncrementOperators&ltint>` <|-- `ISignedNumber&ltint>`
`IMultiplicativeIdentity&ltint, int>` <|-- `ISignedNumber&ltint>`
`IMultiplyOperators&ltint, int, int>` <|-- `ISignedNumber&ltint>`
`INumberBase&ltint>` <|-- `ISignedNumber&ltint>`
`IParsable&ltint>` <|-- `ISignedNumber&ltint>`
`ISpanFormattable` <|-- `ISignedNumber&ltint>`
`ISpanParsable&ltint>` <|-- `ISignedNumber&ltint>`
`ISubtractionOperators&ltint, int, int>` <|-- `ISignedNumber&ltint>`
`IUnaryNegationOperators&ltint, int>` <|-- `ISignedNumber&ltint>`
`IUnaryPlusOperators&ltint, int>` <|-- `ISignedNumber&ltint>`
`IUtf8SpanFormattable` <|-- `ISignedNumber&ltint>`
`IUtf8SpanParsable&ltint>` <|-- `ISignedNumber&ltint>`
`IFormattable` <|-- `ISpanFormattable`
`IParsable&ltint>` <|-- `ISpanParsable&ltint>`
`int` "1"  <--  "1" `IBinaryInteger&ltint>` : GetByteCount
`int` "1"  <--  "1" `IBinaryInteger&ltint>` : GetShortestBitLength
`int` "1"  <--  "1" `IBinaryInteger&ltint>` : WriteBigEndian
`int` "1"  <--  "1" `IBinaryInteger&ltint>` : WriteBigEndian
`int` "1"  <--  "1" `IBinaryInteger&ltint>` : WriteBigEndian
`int` "1"  <--  "1" `IBinaryInteger&ltint>` : WriteLittleEndian
`int` "1"  <--  "1" `IBinaryInteger&ltint>` : WriteLittleEndian
`int` "1"  <--  "1" `IBinaryInteger&ltint>` : WriteLittleEndian
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
`IBinaryInteger&ltint>` : +DivRem(int left, int right) (int, int)$
`IBinaryInteger&ltint>` : +GetByteCount() int*
`IBinaryInteger&ltint>` : +GetShortestBitLength() int*
`IBinaryInteger&ltint>` : +LeadingZeroCount(int value) int$
`IBinaryInteger&ltint>` : +PopCount(int value) int$
`IBinaryInteger&ltint>` : +ReadBigEndian(byte[] source, bool isUnsigned) int$
`IBinaryInteger&ltint>` : +ReadBigEndian(byte[] source, int startIndex, bool isUnsigned) int$
`IBinaryInteger&ltint>` : +ReadBigEndian(ReadOnlySpan&ltbyte> source, bool isUnsigned) int$
`IBinaryInteger&ltint>` : +ReadLittleEndian(byte[] source, bool isUnsigned) int$
`IBinaryInteger&ltint>` : +ReadLittleEndian(byte[] source, int startIndex, bool isUnsigned) int$
`IBinaryInteger&ltint>` : +ReadLittleEndian(ReadOnlySpan&ltbyte> source, bool isUnsigned) int$
`IBinaryInteger&ltint>` : +RotateLeft(int value, int rotateAmount) int$
`IBinaryInteger&ltint>` : +RotateRight(int value, int rotateAmount) int$
`IBinaryInteger&ltint>` : +TrailingZeroCount(int value) int$
`IBinaryInteger&ltint>` : +TryReadBigEndian(ReadOnlySpan&ltbyte> source, bool isUnsigned, ref int value) bool$
`IBinaryInteger&ltint>` : +TryReadLittleEndian(ReadOnlySpan&ltbyte> source, bool isUnsigned, ref int value) bool$
`IBinaryInteger&ltint>` : +TryWriteBigEndian(Span&ltbyte> destination, ref int bytesWritten) bool*
`IBinaryInteger&ltint>` : +TryWriteLittleEndian(Span&ltbyte> destination, ref int bytesWritten) bool*
`IBinaryInteger&ltint>` : +WriteBigEndian(byte[] destination) int
`IBinaryInteger&ltint>` : +WriteBigEndian(byte[] destination, int startIndex) int
`IBinaryInteger&ltint>` : +WriteBigEndian(Span&ltbyte> destination) int
`IBinaryInteger&ltint>` : +WriteLittleEndian(byte[] destination) int
`IBinaryInteger&ltint>` : +WriteLittleEndian(byte[] destination, int startIndex) int
`IBinaryInteger&ltint>` : +WriteLittleEndian(Span&ltbyte> destination) int
class `IBinaryIntegerParseAndFormatInfo&ltint>`
<<interface>> `IBinaryIntegerParseAndFormatInfo&ltint>`
`IBinaryIntegerParseAndFormatInfo&ltint>` : +bool IsSigned$
`IBinaryIntegerParseAndFormatInfo&ltint>` : +int MaxDigitCount$
`IBinaryIntegerParseAndFormatInfo&ltint>` : +int MaxHexDigitCount$
`IBinaryIntegerParseAndFormatInfo&ltint>` : +int MaxValueDiv10$
`IBinaryIntegerParseAndFormatInfo&ltint>` : +string OverflowMessage$
`IBinaryIntegerParseAndFormatInfo&ltint>` : +IsGreaterThanAsUnsigned(int left, int right) bool$
`IBinaryIntegerParseAndFormatInfo&ltint>` : +MultiplyBy10(int value) int$
`IBinaryIntegerParseAndFormatInfo&ltint>` : +MultiplyBy16(int value) int$
class `IBinaryNumber&ltint>`
<<interface>> `IBinaryNumber&ltint>`
`IBinaryNumber&ltint>` : +int AllBitsSet$
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
class `IComparisonOperators&ltint, int, bool>`
<<interface>> `IComparisonOperators&ltint, int, bool>`
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
class `IEqualityOperators&ltint, int, bool>`
<<interface>> `IEqualityOperators&ltint, int, bool>`
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
`int` : -bool System.IBinaryIntegerParseAndFormatInfo<System.Int32>.IsSigned$
`int` : -int System.IBinaryIntegerParseAndFormatInfo<System.Int32>.MaxDigitCount$
`int` : -int System.IBinaryIntegerParseAndFormatInfo<System.Int32>.MaxHexDigitCount$
`int` : -int System.IBinaryIntegerParseAndFormatInfo<System.Int32>.MaxValueDiv10$
`int` : -string System.IBinaryIntegerParseAndFormatInfo<System.Int32>.OverflowMessage$
`int` : -int System.Numerics.IAdditiveIdentity<System.Int32,System.Int32>.AdditiveIdentity$
`int` : -int System.Numerics.IBinaryNumber<System.Int32>.AllBitsSet$
`int` : -int System.Numerics.IMinMaxValue<System.Int32>.MaxValue$
`int` : -int System.Numerics.IMinMaxValue<System.Int32>.MinValue$
`int` : -int System.Numerics.IMultiplicativeIdentity<System.Int32,System.Int32>.MultiplicativeIdentity$
`int` : -int System.Numerics.INumberBase<System.Int32>.One$
`int` : -int System.Numerics.INumberBase<System.Int32>.Radix$
`int` : -int System.Numerics.INumberBase<System.Int32>.Zero$
`int` : -int System.Numerics.ISignedNumber<System.Int32>.NegativeOne$
`int` : +Abs(int value) int$
`int` : +Clamp(int value, int min, int max) int$
`int` : +CompareTo(object value) int
`int` : +CompareTo(int value) int
`int` : +CopySign(int value, int sign) int$
`int` : +CreateChecked(TOther value) int$
`int` : +CreateSaturating(TOther value) int$
`int` : +CreateTruncating(TOther value) int$
`int` : +DivRem(int left, int right) (int, int)$
`int` : +Equals(object obj) bool
`int` : +Equals(int obj) bool
`int` : -Finalize() void
`int` : +GetHashCode() int
`int` : +GetType() Type
`int` : +GetTypeCode() TypeCode
`int` : +IsEvenInteger(int value) bool$
`int` : +IsNegative(int value) bool$
`int` : +IsOddInteger(int value) bool$
`int` : +IsPositive(int value) bool$
`int` : +IsPow2(int value) bool$
`int` : +LeadingZeroCount(int value) int$
`int` : +Log2(int value) int$
`int` : +Max(int x, int y) int$
`int` : +MaxMagnitude(int x, int y) int$
`int` : -MemberwiseClone() object
`int` : +Min(int x, int y) int$
`int` : +MinMagnitude(int x, int y) int$
`int` : +Parse(string s) int$
`int` : +Parse(string s, NumberStyles style) int$
`int` : +Parse(string s, IFormatProvider provider) int$
`int` : +Parse(string s, NumberStyles style, IFormatProvider provider) int$
`int` : +Parse(ReadOnlySpan&ltchar> s, NumberStyles style, IFormatProvider provider) int$
`int` : +Parse(ReadOnlySpan&ltchar> s, IFormatProvider provider) int$
`int` : +Parse(ReadOnlySpan&ltbyte> utf8Text, NumberStyles style, IFormatProvider provider) int$
`int` : +Parse(ReadOnlySpan&ltbyte> utf8Text, IFormatProvider provider) int$
`int` : +PopCount(int value) int$
`int` : +RotateLeft(int value, int rotateAmount) int$
`int` : +RotateRight(int value, int rotateAmount) int$
`int` : +Sign(int value) int$
`int` : -System.IBinaryIntegerParseAndFormatInfo<System.Int32>.IsGreaterThanAsUnsigned(int left, int right) bool$
`int` : -System.IBinaryIntegerParseAndFormatInfo<System.Int32>.MultiplyBy10(int value) int$
`int` : -System.IBinaryIntegerParseAndFormatInfo<System.Int32>.MultiplyBy16(int value) int$
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
`int` : -System.Numerics.IAdditionOperators<System.Int32,System.Int32,System.Int32>.op_Addition(int left, int right) int$
`int` : -System.Numerics.IAdditionOperators<System.Int32,System.Int32,System.Int32>.op_CheckedAddition(int left, int right) int$
`int` : -System.Numerics.IBinaryInteger<System.Int32>.GetByteCount() int
`int` : -System.Numerics.IBinaryInteger<System.Int32>.GetShortestBitLength() int
`int` : -System.Numerics.IBinaryInteger<System.Int32>.TryReadBigEndian(ReadOnlySpan&ltbyte> source, bool isUnsigned, ref int value) bool$
`int` : -System.Numerics.IBinaryInteger<System.Int32>.TryReadLittleEndian(ReadOnlySpan&ltbyte> source, bool isUnsigned, ref int value) bool$
`int` : -System.Numerics.IBinaryInteger<System.Int32>.TryWriteBigEndian(Span&ltbyte> destination, ref int bytesWritten) bool
`int` : -System.Numerics.IBinaryInteger<System.Int32>.TryWriteLittleEndian(Span&ltbyte> destination, ref int bytesWritten) bool
`int` : -System.Numerics.IBitwiseOperators<System.Int32,System.Int32,System.Int32>.op_BitwiseAnd(int left, int right) int$
`int` : -System.Numerics.IBitwiseOperators<System.Int32,System.Int32,System.Int32>.op_BitwiseOr(int left, int right) int$
`int` : -System.Numerics.IBitwiseOperators<System.Int32,System.Int32,System.Int32>.op_ExclusiveOr(int left, int right) int$
`int` : -System.Numerics.IBitwiseOperators<System.Int32,System.Int32,System.Int32>.op_OnesComplement(int value) int$
`int` : -System.Numerics.IComparisonOperators<System.Int32,System.Int32,System.Boolean>.op_GreaterThan(int left, int right) bool$
`int` : -System.Numerics.IComparisonOperators<System.Int32,System.Int32,System.Boolean>.op_GreaterThanOrEqual(int left, int right) bool$
`int` : -System.Numerics.IComparisonOperators<System.Int32,System.Int32,System.Boolean>.op_LessThan(int left, int right) bool$
`int` : -System.Numerics.IComparisonOperators<System.Int32,System.Int32,System.Boolean>.op_LessThanOrEqual(int left, int right) bool$
`int` : -System.Numerics.IDecrementOperators<System.Int32>.op_CheckedDecrement(int value) int$
`int` : -System.Numerics.IDecrementOperators<System.Int32>.op_Decrement(int value) int$
`int` : -System.Numerics.IDivisionOperators<System.Int32,System.Int32,System.Int32>.op_Division(int left, int right) int$
`int` : -System.Numerics.IEqualityOperators<System.Int32,System.Int32,System.Boolean>.op_Equality(int left, int right) bool$
`int` : -System.Numerics.IEqualityOperators<System.Int32,System.Int32,System.Boolean>.op_Inequality(int left, int right) bool$
`int` : -System.Numerics.IIncrementOperators<System.Int32>.op_CheckedIncrement(int value) int$
`int` : -System.Numerics.IIncrementOperators<System.Int32>.op_Increment(int value) int$
`int` : -System.Numerics.IModulusOperators<System.Int32,System.Int32,System.Int32>.op_Modulus(int left, int right) int$
`int` : -System.Numerics.IMultiplyOperators<System.Int32,System.Int32,System.Int32>.op_CheckedMultiply(int left, int right) int$
`int` : -System.Numerics.IMultiplyOperators<System.Int32,System.Int32,System.Int32>.op_Multiply(int left, int right) int$
`int` : -System.Numerics.INumber<System.Int32>.MaxNumber(int x, int y) int$
`int` : -System.Numerics.INumber<System.Int32>.MinNumber(int x, int y) int$
`int` : -System.Numerics.INumberBase<System.Int32>.IsCanonical(int value) bool$
`int` : -System.Numerics.INumberBase<System.Int32>.IsComplexNumber(int value) bool$
`int` : -System.Numerics.INumberBase<System.Int32>.IsFinite(int value) bool$
`int` : -System.Numerics.INumberBase<System.Int32>.IsImaginaryNumber(int value) bool$
`int` : -System.Numerics.INumberBase<System.Int32>.IsInfinity(int value) bool$
`int` : -System.Numerics.INumberBase<System.Int32>.IsInteger(int value) bool$
`int` : -System.Numerics.INumberBase<System.Int32>.IsNaN(int value) bool$
`int` : -System.Numerics.INumberBase<System.Int32>.IsNegativeInfinity(int value) bool$
`int` : -System.Numerics.INumberBase<System.Int32>.IsNormal(int value) bool$
`int` : -System.Numerics.INumberBase<System.Int32>.IsPositiveInfinity(int value) bool$
`int` : -System.Numerics.INumberBase<System.Int32>.IsRealNumber(int value) bool$
`int` : -System.Numerics.INumberBase<System.Int32>.IsSubnormal(int value) bool$
`int` : -System.Numerics.INumberBase<System.Int32>.IsZero(int value) bool$
`int` : -System.Numerics.INumberBase<System.Int32>.MaxMagnitudeNumber(int x, int y) int$
`int` : -System.Numerics.INumberBase<System.Int32>.MinMagnitudeNumber(int x, int y) int$
`int` : -System.Numerics.INumberBase<System.Int32>.TryConvertFromChecked(TOther value, ref int result) bool$
`int` : -System.Numerics.INumberBase<System.Int32>.TryConvertFromSaturating(TOther value, ref int result) bool$
`int` : -System.Numerics.INumberBase<System.Int32>.TryConvertFromTruncating(TOther value, ref int result) bool$
`int` : -System.Numerics.INumberBase<System.Int32>.TryConvertToChecked(int value, ref TOther result) bool$
`int` : -System.Numerics.INumberBase<System.Int32>.TryConvertToSaturating(int value, ref TOther result) bool$
`int` : -System.Numerics.INumberBase<System.Int32>.TryConvertToTruncating(int value, ref TOther result) bool$
`int` : -System.Numerics.IShiftOperators<System.Int32,System.Int32,System.Int32>.op_LeftShift(int value, int shiftAmount) int$
`int` : -System.Numerics.IShiftOperators<System.Int32,System.Int32,System.Int32>.op_RightShift(int value, int shiftAmount) int$
`int` : -System.Numerics.IShiftOperators<System.Int32,System.Int32,System.Int32>.op_UnsignedRightShift(int value, int shiftAmount) int$
`int` : -System.Numerics.ISubtractionOperators<System.Int32,System.Int32,System.Int32>.op_CheckedSubtraction(int left, int right) int$
`int` : -System.Numerics.ISubtractionOperators<System.Int32,System.Int32,System.Int32>.op_Subtraction(int left, int right) int$
`int` : -System.Numerics.IUnaryNegationOperators<System.Int32,System.Int32>.op_CheckedUnaryNegation(int value) int$
`int` : -System.Numerics.IUnaryNegationOperators<System.Int32,System.Int32>.op_UnaryNegation(int value) int$
`int` : -System.Numerics.IUnaryPlusOperators<System.Int32,System.Int32>.op_UnaryPlus(int value) int$
`int` : +ToString() string
`int` : +ToString(string format) string
`int` : +ToString(IFormatProvider provider) string
`int` : +ToString(string format, IFormatProvider provider) string
`int` : +TrailingZeroCount(int value) int$
`int` : -TryConvertFromChecked(TOther value, ref int result) bool$
`int` : -TryConvertFromSaturating(TOther value, ref int result) bool$
`int` : -TryConvertFromTruncating(TOther value, ref int result) bool$
`int` : +TryFormat(Span&ltchar> destination, ref int charsWritten, ReadOnlySpan&ltchar> format, IFormatProvider provider) bool
`int` : +TryFormat(Span&ltbyte> utf8Destination, ref int bytesWritten, ReadOnlySpan&ltchar> format, IFormatProvider provider) bool
`int` : +TryParse(string s, ref int result) bool$
`int` : +TryParse(ReadOnlySpan&ltchar> s, ref int result) bool$
`int` : +TryParse(ReadOnlySpan&ltbyte> utf8Text, ref int result) bool$
`int` : +TryParse(string s, NumberStyles style, IFormatProvider provider, ref int result) bool$
`int` : +TryParse(ReadOnlySpan&ltchar> s, NumberStyles style, IFormatProvider provider, ref int result) bool$
`int` : +TryParse(string s, IFormatProvider provider, ref int result) bool$
`int` : +TryParse(ReadOnlySpan&ltchar> s, IFormatProvider provider, ref int result) bool$
`int` : +TryParse(ReadOnlySpan&ltbyte> utf8Text, NumberStyles style, IFormatProvider provider, ref int result) bool$
`int` : +TryParse(ReadOnlySpan&ltbyte> utf8Text, IFormatProvider provider, ref int result) bool$
class `INumber&ltint>`
<<interface>> `INumber&ltint>`
`INumber&ltint>` : +Clamp(int value, int min, int max) int$
`INumber&ltint>` : +CopySign(int value, int sign) int$
`INumber&ltint>` : +Max(int x, int y) int$
`INumber&ltint>` : +MaxNumber(int x, int y) int$
`INumber&ltint>` : +Min(int x, int y) int$
`INumber&ltint>` : +MinNumber(int x, int y) int$
`INumber&ltint>` : +Sign(int value) int$
class `INumberBase&ltint>`
<<interface>> `INumberBase&ltint>`
`INumberBase&ltint>` : +int One$
`INumberBase&ltint>` : +int Radix$
`INumberBase&ltint>` : +int Zero$
`INumberBase&ltint>` : +Abs(int value) int$
`INumberBase&ltint>` : +CreateChecked(TOther value) int$
`INumberBase&ltint>` : +CreateSaturating(TOther value) int$
`INumberBase&ltint>` : +CreateTruncating(TOther value) int$
`INumberBase&ltint>` : +IsCanonical(int value) bool$
`INumberBase&ltint>` : +IsComplexNumber(int value) bool$
`INumberBase&ltint>` : +IsEvenInteger(int value) bool$
`INumberBase&ltint>` : +IsFinite(int value) bool$
`INumberBase&ltint>` : +IsImaginaryNumber(int value) bool$
`INumberBase&ltint>` : +IsInfinity(int value) bool$
`INumberBase&ltint>` : +IsInteger(int value) bool$
`INumberBase&ltint>` : +IsNaN(int value) bool$
`INumberBase&ltint>` : +IsNegative(int value) bool$
`INumberBase&ltint>` : +IsNegativeInfinity(int value) bool$
`INumberBase&ltint>` : +IsNormal(int value) bool$
`INumberBase&ltint>` : +IsOddInteger(int value) bool$
`INumberBase&ltint>` : +IsPositive(int value) bool$
`INumberBase&ltint>` : +IsPositiveInfinity(int value) bool$
`INumberBase&ltint>` : +IsRealNumber(int value) bool$
`INumberBase&ltint>` : +IsSubnormal(int value) bool$
`INumberBase&ltint>` : +IsZero(int value) bool$
`INumberBase&ltint>` : +MaxMagnitude(int x, int y) int$
`INumberBase&ltint>` : +MaxMagnitudeNumber(int x, int y) int$
`INumberBase&ltint>` : +MinMagnitude(int x, int y) int$
`INumberBase&ltint>` : +MinMagnitudeNumber(int x, int y) int$
`INumberBase&ltint>` : +Parse(string s, NumberStyles style, IFormatProvider provider) int$
`INumberBase&ltint>` : +Parse(ReadOnlySpan&ltchar> s, NumberStyles style, IFormatProvider provider) int$
`INumberBase&ltint>` : +Parse(ReadOnlySpan&ltbyte> utf8Text, NumberStyles style, IFormatProvider provider) int$
`INumberBase&ltint>` : -System.IUtf8SpanFormattable.TryFormat(Span&ltbyte> utf8Destination, ref int bytesWritten, ReadOnlySpan&ltchar> format, IFormatProvider provider) bool
`INumberBase&ltint>` : -System.IUtf8SpanParsable<TSelf>.Parse(ReadOnlySpan&ltbyte> utf8Text, IFormatProvider provider) int$
`INumberBase&ltint>` : -System.IUtf8SpanParsable<TSelf>.TryParse(ReadOnlySpan&ltbyte> utf8Text, IFormatProvider provider, ref int result) bool$
`INumberBase&ltint>` : -TryConvertFromChecked(TOther value, ref int result) bool$
`INumberBase&ltint>` : -TryConvertFromSaturating(TOther value, ref int result) bool$
`INumberBase&ltint>` : -TryConvertFromTruncating(TOther value, ref int result) bool$
`INumberBase&ltint>` : -TryConvertToChecked(int value, ref TOther result) bool$
`INumberBase&ltint>` : -TryConvertToSaturating(int value, ref TOther result) bool$
`INumberBase&ltint>` : -TryConvertToTruncating(int value, ref TOther result) bool$
`INumberBase&ltint>` : +TryParse(string s, NumberStyles style, IFormatProvider provider, ref int result) bool$
`INumberBase&ltint>` : +TryParse(ReadOnlySpan&ltchar> s, NumberStyles style, IFormatProvider provider, ref int result) bool$
`INumberBase&ltint>` : +TryParse(ReadOnlySpan&ltbyte> utf8Text, NumberStyles style, IFormatProvider provider, ref int result) bool$
class `IParsable&ltint>`
<<interface>> `IParsable&ltint>`
`IParsable&ltint>` : +Parse(string s, IFormatProvider provider) int$
`IParsable&ltint>` : +TryParse(string s, IFormatProvider provider, ref int result) bool$
class `IShiftOperators&ltint, int, int>`
<<interface>> `IShiftOperators&ltint, int, int>`
class `ISignedNumber&ltint>`
<<interface>> `ISignedNumber&ltint>`
`ISignedNumber&ltint>` : +int NegativeOne$
class `ISpanFormattable`
<<interface>> `ISpanFormattable`
`ISpanFormattable` : +TryFormat(Span&ltchar> destination, ref int charsWritten, ReadOnlySpan&ltchar> format, IFormatProvider provider) bool*
class `ISpanParsable&ltint>`
<<interface>> `ISpanParsable&ltint>`
`ISpanParsable&ltint>` : +Parse(ReadOnlySpan&ltchar> s, IFormatProvider provider) int$
`ISpanParsable&ltint>` : +TryParse(ReadOnlySpan&ltchar> s, IFormatProvider provider, ref int result) bool$
class `ISubtractionOperators&ltint, int, int>`
<<interface>> `ISubtractionOperators&ltint, int, int>`
class `IUnaryNegationOperators&ltint, int>`
<<interface>> `IUnaryNegationOperators&ltint, int>`
class `IUnaryPlusOperators&ltint, int>`
<<interface>> `IUnaryPlusOperators&ltint, int>`
class `IUtf8SpanFormattable`
<<interface>> `IUtf8SpanFormattable`
`IUtf8SpanFormattable` : +TryFormat(Span&ltbyte> utf8Destination, ref int bytesWritten, ReadOnlySpan&ltchar> format, IFormatProvider provider) bool*
class `IUtf8SpanParsable&ltint>`
<<interface>> `IUtf8SpanParsable&ltint>`
`IUtf8SpanParsable&ltint>` : +Parse(ReadOnlySpan&ltbyte> utf8Text, IFormatProvider provider) int$
`IUtf8SpanParsable&ltint>` : +TryParse(ReadOnlySpan&ltbyte> utf8Text, IFormatProvider provider, ref int result) bool$
```
