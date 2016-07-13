﻿#r "Microsoft.WindowsAzure.Storage"

using System;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.WindowsAzure.Storage.Blob;

public static void Run(CloudBlockBlob blob, CloudBlockBlob output, TraceWriter log)
{
    string content = blob.DownloadText();
    log.Info($"C# Blob trigger function processed a blob. Blob={content}");

    output.UploadText(content);
}