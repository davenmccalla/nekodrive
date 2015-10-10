# How to use the NFS c# Library #

NekoDrive uses a Library written in C#. This library uses RemoteTea.Net ONC/RPC pure c# implementation.

## Example 1 - Connect to NFS server and get the exported devices ##

```
using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using NFSLibrary;

namespace Example1
{
   class Program
    {
        static void Main(string[] args)
        {
            NFSClient nfs = new NFSClient(NFSClient.NFSVersion.v2);
            
            nfs.Connect(IPAddress.Parse("161.55.201.250");

            foreach(string device in nfs.GetExportedDevices())
               Console.WriteLine(device);
            nfs.Disconnect();
        }
    }
}
```

## Example 2 - Connect to NFS server, mount the first exported device and get the file list ##

```
namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            NFSClient nfs = new NFSClient(NFSClient.NFSVersion.v2);
            nfs.Connect(IPAddress.Parse("161.55.201.250"));

            List<string> devices = nfs.GetExportedDevices();
            if(devices.Count > 0)
            {
               nfs.MountDevice(devices[0]);

               foreach(string item in nfs.GetItemList("."))
               {
                    NFSAttributes attrib = nfs.GetItemAttributes(item);
                    Console.WriteLine(item + " " + attrib.cdateTime.ToString() + " " + attrib.size);
               }
               nfs.UnMountDevice();
            }
            nfs.Disconnect();
        }
    }
}
```

## Example 3 - Connect to NFS server, mount the first exported device and download a file in the root folder (.) ##

```

namespace Example3
{
    class Program
    {
        static void Main(string[] args)
        {
            NFSClient nfs = new NFSClient(NFSClient.NFSVersion.v2);
            nfs.Connect(IPAddress.Parse("161.55.201.250"));

            List<string> devices = nfs.GetExportedDevices();
            if(devices.Count > 0)
            {
               nfs.MountDevice(devices[0]);
               nfs.Read("test.txt", @"c:\test.txt");
               nfs.UnMountDevice();
               nfs.Disconnect();
            }
        }
    }
}
```


## Example 4 - Connect to NFS server, mount the first exported device and upload a file in the "test/sub" subfolder ##

```
namespace Example4
{
    class Program
    {
        static void Main(string[] args)
        {
            NFSClient nfs = new NFSClient(NFSClient.NFSVersion.v2);
            nfs.Connect(IPAddress.Parse("161.55.201.250"));

            List<string> devices = nfs.GetExportedDevices();
            if(devices.Count > 0)
            {
               nfs.MountDevice(devices[0]);
               nfs.Write("test/sub/test.txt", @"c:\test.txt");
               nfs.UnMountDevice();
               nfs.Disconnect();
            }
        }
    }
}
```