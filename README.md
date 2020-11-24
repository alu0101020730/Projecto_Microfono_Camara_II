# Projecto_Microfono_Camara_II

![proyecto](img/proyecto)
El proyecto resultante se ve de esta manera, los 3 botones hacen referencia a las funciones del micrófono.

El botón de Record  
![record](img/record)
  
```cs
public void Record()
{
    audioSource.clip = Microphone.Start(null, false, 10, 44100);
}
```

El botón de Stop  
![stop](img/stop)
  
```cs
public void EndRecording()
{
    Microphone.End(null);
}
```

El botón de Play  
![play](img/play)
  
```cs
public void Play()
{
    audioSource.Play();
}
```

Es posible escuchar lo que se está grabando en tiempo real, es decir que te escucharás a ti mismo y unos segundos despues el sonido de la grabación, podria haber parado de grabar cuando le das al play pero me parece que de esta manera es una funcionalidad añadida.


Respecto a la cámara, para que funcione he usado una RawImage ya que con un script no me cargaba.  
![rawimage](img/rawimage)  

El codigo de la cámara
```cs
    public RawImage rawimage;

    void Start()
    {
        WebCamTexture webcamTexture = new WebCamTexture();
        rawimage.texture = webcamTexture;
        rawimage.material.mainTexture = webcamTexture;
        webcamTexture.Play();
    }
```
