using System.Runtime.Serialization;

namespace SchedulerJavierVA
{
    public static class Extensions
    {
        /// <summary>
        /// Extension for enums that returns the string value of its EnumMember attribute.
        /// </summary>
        /// <param name="enumValue">The source.</param>
        public static string GetEnumMemberValue<T>(this T enumValue) where T : Enum
        {
            var memberInfo = typeof(T).GetMember(enumValue.ToString());
            var enumMemberAttribute = memberInfo[0].GetCustomAttributes(typeof(EnumMemberAttribute), false).FirstOrDefault() as EnumMemberAttribute;
            return enumMemberAttribute?.Value;
        }
    }
}
