# BioFormats.Net
Bio-Formats is a software tool for reading and writing image data using standardized, open formats.</br>

BioFormats.Net is software package created by Georgi Danovski and it is based on the original 
[Bio-Formats library](https://www.openmicroscopy.org/bio-formats/) for Java . The library 
was converted to .dll executable by using [IKVM](https://www.ikvm.net/).</br>
## How the project was built
1. Download and unzip [IKVM](https://www.ikvm.net/index.html) (latest release)</br>
2. Download [bio-formats library](https://www.openmicroscopy.org/bio-formats/) (latest release)</br>
3. Open the command prompt and run the following command to create <b>BioFormats.Net.dll</b></br>
```
[PATH to ikvmc]ikvmc -out:[PATH to dll]\BioFormats.Net.dll -fileversion:[VERSION] [PATH to jar]\bioformats_package.jar
```
4. Download and install [NuGet Package Explorer](https://www.microsoft.com/en-us/p/nuget-package-explorer/9wzdncrdmdm3?activetab=pivot:overviewtab)</br>
5. Build the NuGet package by using the <b>BioFormats.Net.dll</b> and NuGet Package Explorer software. <b>It is important to add IKVM as the dependency and the ikvm-native dlls as content</b>.</br>
## Examples
Due to similarity between Java and c# you can use almost directly the [examples](https://docs.openmicroscopy.org/bio-formats/6.5.0/developers/java-library.html) provided by the bio-formats team.</br>
