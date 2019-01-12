# AudioControl

It is a dll for volume control of the main audio in Windows 10.<br>
It only provides the functions for audio control of another project (<a href="https://github.com/devmartins/AudioControlNative" target="_blank">AudioControlNative</a>).<br>

É uma dll para controle de volume do audio principal no Windows 10.<br>
Ela apenas disponibiliza as funcões para controle de audio de outro projeto (<a href="https://github.com/devmartins/AudioControlNative" target="_blank">AudioControlNative</a>).<br>

Nuget Packages:<br>
<a href="https://www.nuget.org/packages/AudioControl" target="_blank">AudioControl (x86) 
 <img src="https://img.shields.io/badge/Nuget-1.0.1-green.svg"/></a><br>
<a href="https://www.nuget.org/packages/AudioControl.x64" target="_blank">AudioControl.x64 (x64) 
<img src="https://img.shields.io/badge/Nuget-1.0.1-green.svg"/></a><br>

Exemplo:
```c#
using System.Windows.Media;

//Returns a float containing the value (ranging from 0 to 1.0f)
//Retorna um float contendo o valor (variando de 0 a 1.0f)
var volume = AudioControl.GetMasterVolume();

//Set the volume (use values between 0 and 1.0f)
//Define o volume (use valores entre 0 e 1.0f)
AudioControl.SetMasterVolume(1.0f);
```

Ferramentas:<br>
Visual Studio 2017 Community<br>
.Net Framework 4.6<br>
C#<br>

Dependências<br>
AudioControlNative (Biblioteca C++, já incluida nos pacotes)<br>
