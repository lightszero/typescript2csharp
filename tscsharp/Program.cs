using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tscsharp
{
    class Program
    {
        delegate bool _fileExists(string filename);
        static string findConfigFile(string searchPath, string configName = "tsconfig.json")
        {
            while (true)
            {
                var fileName = System.IO.Path.Combine(searchPath, configName);
                if (System.IO.File.Exists(fileName))
                {
                    return fileName;
                }
                var parentPath = System.IO.Path.GetDirectoryName(searchPath);
                if (parentPath == searchPath)
                {
                    break;
                }
                searchPath = parentPath;
            }
            return null;
        }

        static void executeCommandLine(string[] args)
        {
            //        const commandLine = parseCommandLine(args);

            //        // Configuration file name (if any)
            string configFileName = "";
            //        if (commandLine.options.locale) {
            //            if (!isJSONSupported()) {
            //                reportDiagnostic(createCompilerDiagnostic(Diagnostics.The_current_host_does_not_support_the_0_option, "--locale"));
            //                return sys.exit(ExitStatus.DiagnosticsPresent_OutputsSkipped);
            //            }
            //            validateLocaleAndSetLanguage(commandLine.options.locale, sys, commandLine.errors);
            //}

            //        // If there are any errors due to command line parsing and/or
            //        // setting up localization, report them and quit.
            //        if (commandLine.errors.length > 0) {
            //            reportDiagnostics(commandLine.errors, reportDiagnostic);
            //            return sys.exit(ExitStatus.DiagnosticsPresent_OutputsSkipped);
            //        }

            //        if (commandLine.options.init) {
            //            writeConfigFile(commandLine.options, commandLine.fileNames);
            //            return sys.exit(ExitStatus.Success);
            //        }

            //        if (commandLine.options.version) {
            //            printVersion();
            //            return sys.exit(ExitStatus.Success);
            //        }

            //        if (commandLine.options.help || commandLine.options.all) {
            //            printVersion();
            //            printHelp(commandLine.options.all);
            //            return sys.exit(ExitStatus.Success);
            //        }

            //        if (commandLine.options.project) {
            //            if (!isJSONSupported()) {
            //                reportDiagnostic(createCompilerDiagnostic(Diagnostics.The_current_host_does_not_support_the_0_option, "--project"));
            //                return sys.exit(ExitStatus.DiagnosticsPresent_OutputsSkipped);
            //            }
            //            if (commandLine.fileNames.length !== 0) {
            //                reportDiagnostic(createCompilerDiagnostic(Diagnostics.Option_project_cannot_be_mixed_with_source_files_on_a_command_line));
            //                return sys.exit(ExitStatus.DiagnosticsPresent_OutputsSkipped);
            //            }

            //            const fileOrDirectory = normalizePath(commandLine.options.project);
            //            if (!fileOrDirectory /* current directory "." */ || sys.directoryExists(fileOrDirectory)) {
            //                configFileName = combinePaths(fileOrDirectory, "tsconfig.json");
            //                if (!sys.fileExists(configFileName)) {
            //                    reportDiagnostic(createCompilerDiagnostic(Diagnostics.Cannot_find_a_tsconfig_json_file_at_the_specified_directory_Colon_0, commandLine.options.project));
            //                    return sys.exit(ExitStatus.DiagnosticsPresent_OutputsSkipped);
            //                }
            //            }
            //            else {
            //                configFileName = fileOrDirectory;
            //                if (!sys.fileExists(configFileName)) {
            //                    reportDiagnostic(createCompilerDiagnostic(Diagnostics.The_specified_path_does_not_exist_Colon_0, commandLine.options.project));
            //                    return sys.exit(ExitStatus.DiagnosticsPresent_OutputsSkipped);
            //                }
            //            }
            //        }
            //        else if (commandLine.fileNames.length === 0 && isJSONSupported()) {
            //            const searchPath = normalizePath(sys.getCurrentDirectory());
            //            configFileName = findConfigFile(searchPath, sys.fileExists);
            var searchPath = System.IO.Directory.GetCurrentDirectory();
            configFileName = findConfigFile(searchPath);
            //        }

            //        if (commandLine.fileNames.length === 0 && !configFileName) {
            //            printVersion();
            //            printHelp(commandLine.options.all);
            //            return sys.exit(ExitStatus.Success);
            //        }

            //        const commandLineOptions = commandLine.options;
            //        if (configFileName) {
            //            const reportWatchDiagnostic = createWatchDiagnosticReporter();
            //            const configParseResult = parseConfigFile(configFileName, commandLineOptions, sys, reportDiagnostic, reportWatchDiagnostic);
            //            udpateReportDiagnostic(configParseResult.options);
            //            if (isWatchSet(configParseResult.options)) {
            //                reportWatchModeWithoutSysSupport();
            //                createWatchModeWithConfigFile(configParseResult, commandLineOptions, createWatchingSystemHost(reportWatchDiagnostic));
            //            }
            //            else {
            //                performCompilation(configParseResult.fileNames, configParseResult.options);
            //            }
            var reportWatchDiagnostic = watch.createWatchDiagnosticReporter();
            var configParseResult = watch.parseConfigFile(configFileName, null, null, null, reportWatchDiagnostic);
            //udpateReportDiagnostic(configParseResult.options);
            performCompilation(configParseResult.fileNames, configParseResult.options);
            //        }
            //        else {
            //            udpateReportDiagnostic(commandLineOptions);
            //            if (isWatchSet(commandLineOptions)) {
            //                reportWatchModeWithoutSysSupport();
            //                createWatchModeWithoutConfigFile(commandLine.fileNames, commandLineOptions, createWatchingSystemHost());
            //            }
            //            else {
            //                performCompilation(commandLine.fileNames, commandLineOptions);
            //            }
            //        }
        }
        static void performCompilation(string[] rootFileNames, CompilerOptions compilerOptions)
        {
            var compilerHost = program.createCompilerHost(compilerOptions, false);
            ////enableStatistics(compilerOptions);

            //var _program = createProgram(rootFileNames, compilerOptions, compilerHost);
            //const exitStatus = compileProgram(program);

            ////reportStatistics(program);
            ////return sys.exit(exitStatus);
        }

        static void Main(string[] args)
        {
            executeCommandLine(args);
        }
    }
}
