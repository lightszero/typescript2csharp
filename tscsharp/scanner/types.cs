using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tscsharp
{
    public enum SyntaxKind
    {
        Unknown,
        EndOfFileToken,
        SingleLineCommentTrivia,
        MultiLineCommentTrivia,
        NewLineTrivia,
        WhitespaceTrivia,
        // We detect and preserve #! on the first line
        ShebangTrivia,
        // We detect and provide better error recovery when we encounter a git merge marker.  This
        // allows us to edit files with git-conflict markers in them in a much more pleasant manner.
        ConflictMarkerTrivia,
        // Literals
        NumericLiteral,
        StringLiteral,
        JsxText,
        JsxTextAllWhiteSpaces,
        RegularExpressionLiteral,
        NoSubstitutionTemplateLiteral,
        // Pseudo-literals
        TemplateHead,
        TemplateMiddle,
        TemplateTail,
        // Punctuation
        OpenBraceToken,
        CloseBraceToken,
        OpenParenToken,
        CloseParenToken,
        OpenBracketToken,
        CloseBracketToken,
        DotToken,
        DotDotDotToken,
        SemicolonToken,
        CommaToken,
        LessThanToken,
        LessThanSlashToken,
        GreaterThanToken,
        LessThanEqualsToken,
        GreaterThanEqualsToken,
        EqualsEqualsToken,
        ExclamationEqualsToken,
        EqualsEqualsEqualsToken,
        ExclamationEqualsEqualsToken,
        EqualsGreaterThanToken,
        PlusToken,
        MinusToken,
        AsteriskToken,
        AsteriskAsteriskToken,
        SlashToken,
        PercentToken,
        PlusPlusToken,
        MinusMinusToken,
        LessThanLessThanToken,
        GreaterThanGreaterThanToken,
        GreaterThanGreaterThanGreaterThanToken,
        AmpersandToken,
        BarToken,
        CaretToken,
        ExclamationToken,
        TildeToken,
        AmpersandAmpersandToken,
        BarBarToken,
        QuestionToken,
        ColonToken,
        AtToken,
        // Assignments
        EqualsToken,
        PlusEqualsToken,
        MinusEqualsToken,
        AsteriskEqualsToken,
        AsteriskAsteriskEqualsToken,
        SlashEqualsToken,
        PercentEqualsToken,
        LessThanLessThanEqualsToken,
        GreaterThanGreaterThanEqualsToken,
        GreaterThanGreaterThanGreaterThanEqualsToken,
        AmpersandEqualsToken,
        BarEqualsToken,
        CaretEqualsToken,
        // Identifiers
        Identifier,
        // Reserved words
        BreakKeyword,
        CaseKeyword,
        CatchKeyword,
        ClassKeyword,
        ConstKeyword,
        ContinueKeyword,
        DebuggerKeyword,
        DefaultKeyword,
        DeleteKeyword,
        DoKeyword,
        ElseKeyword,
        EnumKeyword,
        ExportKeyword,
        ExtendsKeyword,
        FalseKeyword,
        FinallyKeyword,
        ForKeyword,
        FunctionKeyword,
        IfKeyword,
        ImportKeyword,
        InKeyword,
        InstanceOfKeyword,
        NewKeyword,
        NullKeyword,
        ReturnKeyword,
        SuperKeyword,
        SwitchKeyword,
        ThisKeyword,
        ThrowKeyword,
        TrueKeyword,
        TryKeyword,
        TypeOfKeyword,
        VarKeyword,
        VoidKeyword,
        WhileKeyword,
        WithKeyword,
        // Strict mode reserved words
        ImplementsKeyword,
        InterfaceKeyword,
        LetKeyword,
        PackageKeyword,
        PrivateKeyword,
        ProtectedKeyword,
        PublicKeyword,
        StaticKeyword,
        YieldKeyword,
        // Contextual keywords
        AbstractKeyword,
        AsKeyword,
        AnyKeyword,
        AsyncKeyword,
        AwaitKeyword,
        BooleanKeyword,
        ConstructorKeyword,
        DeclareKeyword,
        GetKeyword,
        IsKeyword,
        KeyOfKeyword,
        ModuleKeyword,
        NamespaceKeyword,
        NeverKeyword,
        ReadonlyKeyword,
        RequireKeyword,
        NumberKeyword,
        ObjectKeyword,
        SetKeyword,
        StringKeyword,
        SymbolKeyword,
        TypeKeyword,
        UndefinedKeyword,
        FromKeyword,
        GlobalKeyword,
        OfKeyword, // LastKeyword and LastToken

        // Parse tree nodes

        // Names
        QualifiedName,
        ComputedPropertyName,
        // Signature elements
        TypeParameter,
        Parameter,
        Decorator,
        // TypeMember
        PropertySignature,
        PropertyDeclaration,
        MethodSignature,
        MethodDeclaration,
        Constructor,
        GetAccessor,
        SetAccessor,
        CallSignature,
        ConstructSignature,
        IndexSignature,
        // Type
        TypePredicate,
        TypeReference,
        FunctionType,
        ConstructorType,
        TypeQuery,
        TypeLiteral,
        ArrayType,
        TupleType,
        UnionType,
        IntersectionType,
        ParenthesizedType,
        ThisType,
        TypeOperator,
        IndexedAccessType,
        MappedType,
        LiteralType,
        // Binding patterns
        ObjectBindingPattern,
        ArrayBindingPattern,
        BindingElement,
        // Expression
        ArrayLiteralExpression,
        ObjectLiteralExpression,
        PropertyAccessExpression,
        ElementAccessExpression,
        CallExpression,
        NewExpression,
        TaggedTemplateExpression,
        TypeAssertionExpression,
        ParenthesizedExpression,
        FunctionExpression,
        ArrowFunction,
        DeleteExpression,
        TypeOfExpression,
        VoidExpression,
        AwaitExpression,
        PrefixUnaryExpression,
        PostfixUnaryExpression,
        BinaryExpression,
        ConditionalExpression,
        TemplateExpression,
        YieldExpression,
        SpreadElement,
        ClassExpression,
        OmittedExpression,
        ExpressionWithTypeArguments,
        AsExpression,
        NonNullExpression,
        MetaProperty,

        // Misc
        TemplateSpan,
        SemicolonClassElement,
        // Element
        Block,
        VariableStatement,
        EmptyStatement,
        ExpressionStatement,
        IfStatement,
        DoStatement,
        WhileStatement,
        ForStatement,
        ForInStatement,
        ForOfStatement,
        ContinueStatement,
        BreakStatement,
        ReturnStatement,
        WithStatement,
        SwitchStatement,
        LabeledStatement,
        ThrowStatement,
        TryStatement,
        DebuggerStatement,
        VariableDeclaration,
        VariableDeclarationList,
        FunctionDeclaration,
        ClassDeclaration,
        InterfaceDeclaration,
        TypeAliasDeclaration,
        EnumDeclaration,
        ModuleDeclaration,
        ModuleBlock,
        CaseBlock,
        NamespaceExportDeclaration,
        ImportEqualsDeclaration,
        ImportDeclaration,
        ImportClause,
        NamespaceImport,
        NamedImports,
        ImportSpecifier,
        ExportAssignment,
        ExportDeclaration,
        NamedExports,
        ExportSpecifier,
        MissingDeclaration,

        // Module references
        ExternalModuleReference,

        // JSX
        JsxElement,
        JsxSelfClosingElement,
        JsxOpeningElement,
        JsxClosingElement,
        JsxAttribute,
        JsxAttributes,
        JsxSpreadAttribute,
        JsxExpression,

        // Clauses
        CaseClause,
        DefaultClause,
        HeritageClause,
        CatchClause,

        // Property assignments
        PropertyAssignment,
        ShorthandPropertyAssignment,
        SpreadAssignment,

        // Enum
        EnumMember,
        // Top-level nodes
        SourceFile,
        Bundle,

        // JSDoc nodes
        JSDocTypeExpression,
        // The * type
        JSDocAllType,
        // The ? type
        JSDocUnknownType,
        JSDocNullableType,
        JSDocNonNullableType,
        JSDocOptionalType,
        JSDocFunctionType,
        JSDocVariadicType,
        JSDocComment,
        JSDocTag,
        JSDocAugmentsTag,
        JSDocClassTag,
        JSDocParameterTag,
        JSDocReturnTag,
        JSDocTypeTag,
        JSDocTemplateTag,
        JSDocTypedefTag,
        JSDocPropertyTag,
        JSDocTypeLiteral,

        // Synthesized list
        SyntaxList,

        // Transformation nodes
        NotEmittedStatement,
        PartiallyEmittedExpression,
        CommaListExpression,
        MergeDeclarationMarker,
        EndOfDeclarationMarker,

        // Enum value count
        Count,

        // Markers
        FirstAssignment = EqualsToken,
        LastAssignment = CaretEqualsToken,
        FirstCompoundAssignment = PlusEqualsToken,
        LastCompoundAssignment = CaretEqualsToken,
        FirstReservedWord = BreakKeyword,
        LastReservedWord = WithKeyword,
        FirstKeyword = BreakKeyword,
        LastKeyword = OfKeyword,
        FirstFutureReservedWord = ImplementsKeyword,
        LastFutureReservedWord = YieldKeyword,
        FirstTypeNode = TypePredicate,
        LastTypeNode = LiteralType,
        FirstPunctuation = OpenBraceToken,
        LastPunctuation = CaretEqualsToken,
        FirstToken = Unknown,
        LastToken = LastKeyword,
        FirstTriviaToken = SingleLineCommentTrivia,
        LastTriviaToken = ConflictMarkerTrivia,
        FirstLiteralToken = NumericLiteral,
        LastLiteralToken = NoSubstitutionTemplateLiteral,
        FirstTemplateToken = NoSubstitutionTemplateLiteral,
        LastTemplateToken = TemplateTail,
        FirstBinaryOperator = LessThanToken,
        LastBinaryOperator = CaretEqualsToken,
        FirstNode = QualifiedName,
        FirstJSDocNode = JSDocTypeExpression,
        LastJSDocNode = JSDocTypeLiteral,
        FirstJSDocTagNode = JSDocTag,
        LastJSDocTagNode = JSDocTypeLiteral
    }
    public enum NumericLiteralFlags
    {
        None = 0,
        Scientific = 1 << 1,        // e.g. `10e2`
        Octal = 1 << 2,             // e.g. `0777`
        HexSpecifier = 1 << 3,      // e.g. `0x00000000`
        BinarySpecifier = 1 << 4,   // e.g. `0b0110010000000000`
        OctalSpecifier = 1 << 5,    // e.g. `0o777`
        BinaryOrOctalSpecifier = BinarySpecifier | OctalSpecifier,
    }
    public enum LanguageVariant
    {
        Standard,
        JSX,
    }
    public enum CharacterCodes
    {
        nullCharacter = 0,
        maxAsciiCharacter = 0x7F,

        lineFeed = 0x0A,              // \n
        carriageReturn = 0x0D,        // \r
        lineSeparator = 0x2028,
        paragraphSeparator = 0x2029,
        nextLine = 0x0085,

        // Unicode 3.0 space characters
        space = 0x0020,   // " "
        nonBreakingSpace = 0x00A0,   //
        enQuad = 0x2000,
        emQuad = 0x2001,
        enSpace = 0x2002,
        emSpace = 0x2003,
        threePerEmSpace = 0x2004,
        fourPerEmSpace = 0x2005,
        sixPerEmSpace = 0x2006,
        figureSpace = 0x2007,
        punctuationSpace = 0x2008,
        thinSpace = 0x2009,
        hairSpace = 0x200A,
        zeroWidthSpace = 0x200B,
        narrowNoBreakSpace = 0x202F,
        ideographicSpace = 0x3000,
        mathematicalSpace = 0x205F,
        ogham = 0x1680,

        _ = 0x5F,
        _doller_ = 0x24,

        _0 = 0x30,
        _1 = 0x31,
        _2 = 0x32,
        _3 = 0x33,
        _4 = 0x34,
        _5 = 0x35,
        _6 = 0x36,
        _7 = 0x37,
        _8 = 0x38,
        _9 = 0x39,

        a = 0x61,
        b = 0x62,
        c = 0x63,
        d = 0x64,
        e = 0x65,
        f = 0x66,
        g = 0x67,
        h = 0x68,
        i = 0x69,
        j = 0x6A,
        k = 0x6B,
        l = 0x6C,
        m = 0x6D,
        n = 0x6E,
        o = 0x6F,
        p = 0x70,
        q = 0x71,
        r = 0x72,
        s = 0x73,
        t = 0x74,
        u = 0x75,
        v = 0x76,
        w = 0x77,
        x = 0x78,
        y = 0x79,
        z = 0x7A,

        A = 0x41,
        B = 0x42,
        C = 0x43,
        D = 0x44,
        E = 0x45,
        F = 0x46,
        G = 0x47,
        H = 0x48,
        I = 0x49,
        J = 0x4A,
        K = 0x4B,
        L = 0x4C,
        M = 0x4D,
        N = 0x4E,
        O = 0x4F,
        P = 0x50,
        Q = 0x51,
        R = 0x52,
        S = 0x53,
        T = 0x54,
        U = 0x55,
        V = 0x56,
        W = 0x57,
        X = 0x58,
        Y = 0x59,
        Z = 0x5a,

        ampersand = 0x26,             // &
        asterisk = 0x2A,              // *
        at = 0x40,                    // @
        backslash = 0x5C,             // \
        backtick = 0x60,              // `
        bar = 0x7C,                   // |
        caret = 0x5E,                 // ^
        closeBrace = 0x7D,            // }
        closeBracket = 0x5D,          // ]
        closeParen = 0x29,            // )
        colon = 0x3A,                 // :
        comma = 0x2C,                 // ,
        dot = 0x2E,                   // .
        doubleQuote = 0x22,           // "
        equals = 0x3D,                // =
        exclamation = 0x21,           // !
        greaterThan = 0x3E,           // >
        hash = 0x23,                  // #
        lessThan = 0x3C,              // <
        minus = 0x2D,                 // -
        openBrace = 0x7B,             // {
        openBracket = 0x5B,           // [
        openParen = 0x28,             // (
        percent = 0x25,               // %
        plus = 0x2B,                  // +
        question = 0x3F,              // ?
        semicolon = 0x3B,             // ;
        singleQuote = 0x27,           // '
        slash = 0x2F,                 // /
        tilde = 0x7E,                 // ~

        backspace = 0x08,             // \b
        formFeed = 0x0C,              // \f
        byteOrderMark = 0xFEFF,
        tab = 0x09,                   // \t
        verticalTab = 0x0B,           // \v
    }
    public enum ScriptTarget
    {
        ES3 = 0,
        ES5 = 1,
        ES2015 = 2,
        ES2016 = 3,
        ES2017 = 4,
        ESNext = 5,
        Latest = ESNext,
    }
    public enum DiagnosticCategory
    {
        Warning,
        Error,
        Message
    }
    public struct DiagnosticMessage
    {
        public string key;
        public DiagnosticCategory category;
        public int code;
        public string message;
    }
    public static class Diagnostics
    {
        public static DiagnosticMessage Unterminated_regular_expression_literal
        {
            get
            {
                DiagnosticMessage msg = new DiagnosticMessage();
                msg.key = "Unterminated_regular_expression_literal";
                msg.message = "Unterminated_regular_expression_literal";
                msg.category = DiagnosticCategory.Error;
                msg.code = 0;
                return msg;
            }

        }
        public static DiagnosticMessage Invalid_character
        {
            get
            {
                DiagnosticMessage msg = new DiagnosticMessage();
                msg.key = "Invalid_character";
                msg.message = "Invalid_character";
                msg.category = DiagnosticCategory.Error;
                msg.code = 0;
                return msg;
            }

        }
        public static DiagnosticMessage Binary_digit_expected
        {
            get
            {
                DiagnosticMessage msg = new DiagnosticMessage();
                msg.key = "Binary_digit_expected";
                msg.message = "Binary_digit_expected";
                msg.category = DiagnosticCategory.Error;
                msg.code = 0;
                return msg;
            }

        }
        public static DiagnosticMessage Octal_digit_expected
        {
            get
            {
                DiagnosticMessage msg = new DiagnosticMessage();
                msg.key = "Octal_digit_expected";
                msg.message = "Octal_digit_expected";
                msg.category = DiagnosticCategory.Error;
                msg.code = 0;
                return msg;
            }

        }
        public static DiagnosticMessage Digit_expected
        {
            get
            {
                DiagnosticMessage msg = new DiagnosticMessage();
                msg.key = "Digit_expected";
                msg.message = "Digit_expected";
                msg.category = DiagnosticCategory.Error;
                msg.code = 0;
                return msg;
            }

        }
        public static DiagnosticMessage Asterisk_Slash_expected
        {
            get
            {
                DiagnosticMessage msg = new DiagnosticMessage();
                msg.key = "Asterisk_Slash_expected";
                msg.message = "Asterisk_Slash_expected";
                msg.category = DiagnosticCategory.Error;
                msg.code = 0;
                return msg;
            }

        }
        public static DiagnosticMessage Unterminated_template_literal
        {
            get
            {
                DiagnosticMessage msg = new DiagnosticMessage();
                msg.key = "Unterminated_template_literal";
                msg.message = "Unterminated_template_literal";
                msg.category = DiagnosticCategory.Error;
                msg.code = 0;
                return msg;
            }

        }
        public static DiagnosticMessage Unterminated_string_literal
        {
            get
            {
                DiagnosticMessage msg = new DiagnosticMessage();
                msg.key = "Unterminated_string_literal";
                msg.message = "Unterminated_string_literal";
                msg.category = DiagnosticCategory.Error;
                msg.code = 0;
                return msg;
            }

        }
        public static DiagnosticMessage Merge_conflict_marker_encountered
        {
            get
            {
                DiagnosticMessage msg = new DiagnosticMessage();
                msg.key = "Merge_conflict_marker_encountered";
                msg.message = "Merge_conflict_marker_encountered";
                msg.category = DiagnosticCategory.Error;
                msg.code = 0;
                return msg;
            }

        }
        public static DiagnosticMessage Hexadecimal_digit_expected
        {
            get
            {
                DiagnosticMessage msg = new DiagnosticMessage();
                msg.key = "Hexadecimal_digit_expected";
                msg.message = "Hexadecimal_digit_expected";
                msg.category = DiagnosticCategory.Error;
                msg.code = 0;
                return msg;
            }
        }
        public static DiagnosticMessage An_extended_Unicode_escape_value_must_be_between_0x0_and_0x10FFFF_inclusive
        {
            get
            {
                DiagnosticMessage msg = new DiagnosticMessage();
                msg.key = "An_extended_Unicode_escape_value_must_be_between_0x0_and_0x10FFFF_inclusive";
                msg.message = "An_extended_Unicode_escape_value_must_be_between_0x0_and_0x10FFFF_inclusive";
                msg.category = DiagnosticCategory.Error;
                msg.code = 0;
                return msg;
            }
        }
        public static DiagnosticMessage Unexpected_end_of_text
        {
            get
            {
                DiagnosticMessage msg = new DiagnosticMessage();
                msg.key = "Unexpected_end_of_text";
                msg.message = "Unexpected_end_of_text";
                msg.category = DiagnosticCategory.Error;
                msg.code = 0;
                return msg;
            }
        }
        public static DiagnosticMessage Unterminated_Unicode_escape_sequence
        {
            get
            {
                DiagnosticMessage msg = new DiagnosticMessage();
                msg.key = "Unterminated_Unicode_escape_sequence";
                msg.message = "Unterminated_Unicode_escape_sequence";
                msg.category = DiagnosticCategory.Error;
                msg.code = 0;
                return msg;
            }
        }
    }
}
