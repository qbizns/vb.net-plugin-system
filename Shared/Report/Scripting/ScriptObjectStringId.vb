Imports Salling.Localization

Namespace Salling.Report.Scripting
    <LocalizableString> _
    Public Enum ScriptObjectStringId
        <DefaultString("Exception from script ({0}.{1}): {2}")> _
        ExceptionFromScript
        <DefaultString("Script '{0}' has compilation error(s).")> _
        ScriptError
        <DefaultString("Script '{0}' has compilation error(s) so it will not be executed.")> _
        ScriptErrorNoExecute
    End Enum
End Namespace