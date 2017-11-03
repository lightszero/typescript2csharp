using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tscsharp
{
    public interface IModuleResolutionHost
    {
        bool fileExists(string fileName);
        // readFile function is used to read arbitrary text files on disk, i.e. when resolution procedure needs the content of 'package.json'
        // to determine location of bundled typings for node module
        string readFile(string fileName);
        void trace(string s);
        bool directoryExists(string directoryName);
        /**
         * Resolve a symbolic link.
         * @see https://nodejs.org/api/fs.html#fs_fs_realpathsync_path_options
         */
        string realpath(string path);
        string getCurrentDirectory();
        string[] getDirectories(string path);
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
    public class CancellationToken
    {

    }
    public interface ICompilerHost : IModuleResolutionHost
    {
        SourceFile getSourceFile(string fileName, ScriptTarget languageVersion, Action<string> onError = null, bool shouldCreateNewSourceFile = false);
        SourceFile getSourceFileByPath(string fileName, string path, ScriptTarget languageVersion, Action<string> onError = null, bool shouldCreateNewSourceFile = false);
        CancellationToken getCancellationToken();
        string getDefaultLibFileName(CompilerOptions options);
        string getDefaultLibLocation();

        event Action<string, string, bool, Action<string>, SourceFile[]> writeFile;

        //string getCurrentDirectory();
        //string[] getDirectories(string path);
        string getCanonicalFileName(string fileName);
        bool useCaseSensitiveFileNames();
        string getNewLine();

        /*
         * CompilerHost must either implement resolveModuleNames (in case if it wants to be completely in charge of
         * module name resolution) or provide implementation for methods from ModuleResolutionHost (in this case compiler
         * will apply built-in module resolution logic and use members of ModuleResolutionHost to ask host specific questions).
         * If resolveModuleNames is implemented then implementation for members from ModuleResolutionHost can be just
         * 'throw new Error("NotImplemented")'
         */
        ResolvedModule[] resolveModuleNames(string[] moduleNames, string containingFile, string[] reusedNames);
        /**
         * This method is a companion for 'resolveModuleNames' and is used to resolve 'types' references to actual type declaration files
         */
        ResolvedTypeReferenceDirective[] resolveTypeReferenceDirectives(string[] typeReferenceDirectiveNames, string containingFile);
        string getEnvironmentVariable(string name);
        /* @internal */
        void onReleaseOldSourceFile(SourceFile oldSourceFile, CompilerOptions oldOptions);
        /* @internal */
        HasInvalidatedResolution hasInvalidatedResolution
        {
            get;
            set;
        }
        /* @internal */
        bool hasChangedAutomaticTypeDirectiveNames
        {
            get;
            set;
        }
    }
    public class ResolvedModule
    {

    }
    public class ResolvedTypeReferenceDirective
    {

    }
    public class HasInvalidatedResolution
    {

    }
    class program
    {
        public static ICompilerHost createCompilerHost(CompilerOptions options, bool setParentNodes)
        {
            return null;
        }
    }
}
