





#nullable enable

// Type: System.SR
// Assembly: System.Memory, Version=4.0.1.2, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// MVID: 805945F3-27B0-47AD-B8F6-389D9D8F82C3

using System.Resources;
using System.Runtime.CompilerServices;
#pragma warning disable CS0168
#pragma warning disable CS8625

namespace System.Memory
{
    internal static class SR
    {
        private static ResourceManager s_resourceManager;

        private static ResourceManager ResourceManager => SR.s_resourceManager ?? (SR.s_resourceManager = new ResourceManager(SR.ResourceType));

        [MethodImpl(MethodImplOptions.NoInlining)]
        private static bool UsingResourceKeys() => false;

        internal static string GetResourceString(string resourceKey, string defaultString)
        {
            string str = (string)null;
            try
            {
                str = ResourceManager.GetString(resourceKey);
            }
            catch (MissingManifestResourceException ex)
            {
            }
            return defaultString != null && resourceKey.Equals(str, StringComparison.Ordinal) ? defaultString : str;
        }

        internal static string Format(string resourceFormat, params object[] args)
        {
            if (args == null)
                return resourceFormat;
            return UsingResourceKeys() ? resourceFormat + string.Join(", ", args) : string.Format(resourceFormat, args);
        }

        internal static string Format(string resourceFormat, object p1)
        {
            if (!UsingResourceKeys())
                return string.Format(resourceFormat, p1);
            return string.Join(", ", (object)resourceFormat, p1);
        }

        internal static string Format(string resourceFormat, object p1, object p2)
        {
            if (!UsingResourceKeys())
                return string.Format(resourceFormat, p1, p2);
            return string.Join(", ", (object)resourceFormat, p1, p2);
        }

        internal static string Format(string resourceFormat, object p1, object p2, object p3)
        {
            if (!UsingResourceKeys())
                return string.Format(resourceFormat, p1, p2, p3);
            return string.Join(", ", (object)resourceFormat, p1, p2, p3);
        }

        internal static Type ResourceType { get; } = typeof(FxResources.System.Memory.SR);

        internal static string NotSupported_CannotCallEqualsOnSpan => GetResourceString(nameof(NotSupported_CannotCallEqualsOnSpan), (string)null);

        internal static string NotSupported_CannotCallGetHashCodeOnSpan => GetResourceString(nameof(NotSupported_CannotCallGetHashCodeOnSpan), (string)null);

        internal static string Argument_InvalidTypeWithPointersNotSupported => GetResourceString(nameof(Argument_InvalidTypeWithPointersNotSupported), (string)null);

        internal static string Argument_DestinationTooShort => GetResourceString(nameof(Argument_DestinationTooShort), (string)null);

        internal static string MemoryDisposed => GetResourceString(nameof(MemoryDisposed), (string)null);

        internal static string OutstandingReferences => GetResourceString(nameof(OutstandingReferences), (string)null);

        internal static string Argument_BadFormatSpecifier => GetResourceString(nameof(Argument_BadFormatSpecifier), (string)null);

        internal static string Argument_GWithPrecisionNotSupported => GetResourceString(nameof(Argument_GWithPrecisionNotSupported), (string)null);

        internal static string Argument_CannotParsePrecision => GetResourceString(nameof(Argument_CannotParsePrecision), (string)null);

        internal static string Argument_PrecisionTooLarge => GetResourceString(nameof(Argument_PrecisionTooLarge), (string)null);

        internal static string Argument_OverlapAlignmentMismatch => GetResourceString(nameof(Argument_OverlapAlignmentMismatch), (string)null);

        internal static string EndPositionNotReached => GetResourceString(nameof(EndPositionNotReached), (string)null);

        internal static string UnexpectedSegmentType => GetResourceString(nameof(UnexpectedSegmentType), (string)null);
    }
}
