// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.IO;

namespace CodeGenerator
{
    public class Program
    {
        public static int Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.Error.WriteLine("Missing path to HttpHeaders.Generated.cs");
                return 1;
            }
            else if (args.Length < 2)
            {
                Console.Error.WriteLine("Missing path to HttpProtocol.Generated.cs");
                return 1;
            }
            else if (args.Length < 3)
            {
                Console.Error.WriteLine("Missing path to HttpUtilities.Generated.cs");
                return 1;
            }
            else if (args.Length < 4)
            {
                Console.Error.WriteLine("Missing path to TransportConnectionBase.Generated.cs");
                return 1;
            }
            else if (args.Length < 5)
            {
                Console.Error.WriteLine("Missing path to TransportConnectio.Generated.cs");
                return 1;
            }
            else if (args.Length < 6)
            {
                Console.Error.WriteLine("Missing path to TransportStream.Generated.cs");
                return 1;
            }

            Run(args[0], args[1], args[2], args[3], args[4], args[5]);

            return 0;
        }

        public static void Run(
            string knownHeadersPath,
            string httpProtocolFeatureCollectionPath,
            string httpUtilitiesPath,
            string transportConnectionBaseFeatureCollectionPath,
            string transportConnectionFeatureCollectionPath,
            string transportStreamFeatureCollectionPath)
        {
            var knownHeadersContent = KnownHeaders.GeneratedFile();
            var httpProtocolFeatureCollectionContent = HttpProtocolFeatureCollection.GenerateFile();
            var httpUtilitiesContent = HttpUtilities.HttpUtilities.GeneratedFile();
            var transportConnectionBaseFeatureCollectionContent = TransportConnectionBaseFeatureCollection.GenerateFile();
            var transportConnectionFeatureCollectionContent = TransportConnectionFeatureCollection.GenerateFile();
            var transportStreamFeatureCollectionContent = TransportStreamFeatureCollection.GenerateFile();

            UpdateFile(knownHeadersPath, knownHeadersContent);
            UpdateFile(httpProtocolFeatureCollectionPath, httpProtocolFeatureCollectionContent);
            UpdateFile(httpUtilitiesPath, httpUtilitiesContent);
            UpdateFile(transportConnectionBaseFeatureCollectionPath, transportConnectionBaseFeatureCollectionContent);
            UpdateFile(transportConnectionFeatureCollectionPath, transportConnectionFeatureCollectionContent);
            UpdateFile(transportStreamFeatureCollectionPath, transportStreamFeatureCollectionContent);
        }

        public static void UpdateFile(string path, string content)
        {
            var existingContent = File.Exists(path) ? File.ReadAllText(path) : "";
            if (!string.Equals(content, existingContent))
            {
                File.WriteAllText(path, content);
            }
        }
    }
}
