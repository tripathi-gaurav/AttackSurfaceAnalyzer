﻿// Copyright (c) Microsoft Corporation. All rights reserved. Licensed under the MIT License.
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace AttackSurfaceAnalyzer.Objects
{
    public class ProcessModuleObject
    {
        public ProcessModuleObject(string FileName, string ModuleName, SerializableFileVersionInfo? FileVersionInfo)
        {
            this.FileName = FileName;
            this.ModuleName = ModuleName;
            this.FileVersionInfo = FileVersionInfo;
        }

        public string FileName { get; }

        public SerializableFileVersionInfo? FileVersionInfo { get; }
        public string ModuleName { get; }

        internal static ProcessModuleObject FromProcessModule(ProcessModule mainModule)
        {
            return new ProcessModuleObject(mainModule.FileName, mainModule.ModuleName, SerializableFileVersionInfo.FromFileVersionInfo(mainModule.FileVersionInfo));
        }

        internal static List<ProcessModuleObject> FromProcessModuleCollection(ProcessModuleCollection modules)
        {
            var output = new List<ProcessModuleObject>();
            foreach (var processModule in modules)
            {
                if (processModule is ProcessModule pm)
                    output.Add(FromProcessModule(pm));
            }
            return output;
        }
    }
}