# RPiCamPanTilt
.NET 5 based Pan-Tilt Sample App for a Raspberry Pi 4 using the Arducam Pan-Tilt Module (PCA9685).

This is a .NET 5+ implementation of the Arducam PCA9685 pan-tilt camera module. It
uses the all the C native driver code that was originally found on the official
repository [https://github.com/Arducam/PCA9685](https://github.com/Arducam/PCA9685).
This project exposes necessary APIs which allows the shared C# code to invoke them.

# Hardware
This project uses the Arducam PCA9685 Pan-Tilt Module and a Raspberry Pi
- [Arducam Official Documentation](https://www.arducam.com/docs/cameras-for-raspberry-pi/mini-pan-tilt-camera-kit/)

The hardware was purchased on Amazon using the link below
- [Amazon Link](https://www.amazon.com/gp/product/B0874CFBX8/ref=ppx_yo_dt_b_asin_title_o04_s00?ie=UTF8&psc=1)

# Supported Devices
This has been tested on a Raspberry Pi 4 with the full .NET 5 SDK. No guarentees it will compile on any other system.

# Getting Started
The fastest way to get started is by running the `build.sh` script from the root directory and then running the .NET sample application. If you are interested in the individual build steps, skip ahead to Building.

## Quick Start
In the root of the repository execute the `build.sh` script and then run the sample app

```
./build.sh
cd PanTiltSample
dotnet run
```

## Building
The complete build is broken into 2 main components
- Native C drivers
- .NET 5 code

The first step is to compile the native code which will be used by the .NET code.

```
cd lib
cmake .
make
```

Once the native code is compiled you can build and run the .NET code.

```
cd PanTiltSample
dotnet run
```

# Created by Andrew Hoefling
- Twitter: [@andrew_hoefling](https://twitter.com/andrew_hoefling)
- Blog: [andrewhoefling.com](https://www.andrewhoefling.com)

# License
The MIT License (MIT) see [License File](LICENSE)
