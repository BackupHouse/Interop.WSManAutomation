# Interop.WSManAutomation
Compatible with .net framework3.5 and more details from WsmAuto.dll

之前项目中踩过坑，记录下。留给有需要的朋友，选择.NET3.5 直接编译即可。默认CLR版本为 2.0.
Interop.WSManAutomation是从 system32\WsmAuto.dll引用进VS项目中，然后编译器产生的可供.NET程序交互的.net assembly dll程序。
关于这部分内容参考 native interop 互操作
https://docs.microsoft.com/en-us/dotnet/standard/native-interop/
