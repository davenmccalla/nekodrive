NekoDrive Usage

It's extremely simple:

  1. download and install dokan 0.6.0 http://dokan-dev.net/en/
  1. download and install .NET Framework 4.0
  1. download and install Neko Drive (7zip is needed to extract the archive)
  1. on ubuntu server you may have to specify the uid and gid of the export as the following example:

/folder 192.168.0.14(rw,no\_subtree\_check,sync,anonuid=1000,anongid=1000)