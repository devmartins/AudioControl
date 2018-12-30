# AudioControl

É uma dll para controle de volume do audio principal no Windows 10.<br>
Ela apenas disponibiliza as funcões para controle de audio de outro projeto (<a href="https://github.com/devmartins/AudioControlNative" target="_blank">AudioControlNative</a>).<br>

Nuget Packages:<br>
<a href="https://www.nuget.org/packages/AudioControl" target="_blank">AudioControl (x86)</a><br>
<a href="https://www.nuget.org/packages/AudioControl.x64" target="_blank">AudioControl.x64 (x64)</a><br>

Exemplo:
```c#
using System.Windowws.Media;

//Para obter o volume
var volume = AudioControl.GetMasterVolume(); //Retorna um float contendo o valor (variando entre 0 e 1.0f)

//Para configurar um volume
AudioControl.SetMasterVolume(1.0f); //0 Sem Volume e 1.0f volume máximo (100%)
```

Ferramentas:<br>
Visual Studio 2017 Community<br>
.Net Framework 4.6<br>
C#<br>

Dependências<br>
AudioControlNative (Biblioteca C++, já incluida nos pacotes)<br>
