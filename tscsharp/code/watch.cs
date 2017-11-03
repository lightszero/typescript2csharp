using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tscsharp
{
    public class CompilerOptions
    {

    }
    public class TypeAcquisition
    {
        /* @deprecated typingOptions.enableAutoDiscovery
         * Use typeAcquisition.enable instead.
         */
        bool enableAutoDiscovery;
        bool enable;
        string[] include;
        string[] exclude;

    }
    public enum DiagnosticCategory
    {
        Warning,
        Error,
        Message
    }
    public class SourceFile
    {

    }
    public class Diagnostic
    {
        SourceFile file;
        int start;
        int length;
        string messageText;//| DiagnosticMessageChain;
        DiagnosticCategory category;
        int code;
        string source;
    }
    public enum WatchDirectoryFlags
    {
        None = 0,
        Recursive = 1 << 0,
    }
    public class ParsedCommandLine
    {
        public CompilerOptions options;
        TypeAcquisition typeAcquisition;
        public string[] fileNames;
        object raw;
        Diagnostic[] errors;
        Dictionary<string, WatchDirectoryFlags> wildcardDirectories;
        bool? compileOnSave;
    }
    public class DiagnosticReporter
    {

    }
    public class DirectoryStructureHost
    {
    }
    public class JsFileExtensionInfo
    {
    }
    public class parseJsonConfigFileContentWorker
    {
        public string[] getFileNames(string path)
        {
            //本来是需要根据config.ts的配置去读取file的
            //这里只处理一种情况
            var filenames = System.IO.Directory.GetFiles(path, "*.ts", System.IO.SearchOption.AllDirectories);
            return filenames;
        }
    }
    class watch
    {
        public static ParsedCommandLine parseJsonSourceFileConfigFileContent(object sourceFile, object host, string basePath,
            CompilerOptions existingOptions, string configFileName)
        {
            parseJsonConfigFileContentWorker pw = new parseJsonConfigFileContentWorker();
            var pcl = new ParsedCommandLine();
            pcl.fileNames = pw.getFileNames(basePath);
            return pcl;
        }

        public static object parseJsonText(string a, string b)
        {
            return null;
        }
        public static DiagnosticReporter createWatchDiagnosticReporter()
        {
            var output = DateTime.Now.ToLongTimeString() + " - ";
            return new DiagnosticReporter();
        }
        public static ParsedCommandLine parseConfigFile(string configFileName, CompilerOptions optionsToExtend,
            DirectoryStructureHost system, DiagnosticReporter reportDiagnostic, DiagnosticReporter reportWatchDiagnostic)
        {
            string configFileText = null;
            try
            {
                configFileText = System.IO.File.ReadAllText(configFileName);
            }
            catch (Exception e)
            {
                throw (new Exception("Cannot_read_file_0_Colon_1", e));
                //const error = createCompilerDiagnostic(Diagnostics.Cannot_read_file_0_Colon_1, configFileName, e.message);
                //reportWatchDiagnostic(error);
                //system.exit(ExitStatus.DiagnosticsPresent_OutputsSkipped);
                //return;
            }
            if (null == configFileText)
            {
                throw (new Exception("File_0_not_found"));
                //const error = createCompilerDiagnostic(Diagnostics.File_0_not_found, configFileName);
                //reportDiagnostics([error], reportDiagnostic);
                //system.exit(ExitStatus.DiagnosticsPresent_OutputsSkipped);
                //return;
            }

            var result = parseJsonText(configFileName, configFileText);
            //reportDiagnostics(result.parseDiagnostics, reportDiagnostic);

            //const cwd = system.getCurrentDirectory();
            //var configParseResult = new ParsedCommandLine();
            var configParseResult = parseJsonSourceFileConfigFileContent(result, system, System.IO.Path.GetDirectoryName(configFileName), optionsToExtend, configFileName);
            //reportDiagnostics(configParseResult.errors, reportDiagnostic);

            return configParseResult;
        }
    }
}
