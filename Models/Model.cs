using Newtonsoft.Json;

public class juego{

    [JsonProperty]
    private Dictionary <int, string> respuestas = new Dictionary<int, string>();
    
    [JsonProperty]
    public int sala {get; private set;}

    [JsonProperty]
     private Dictionary <int, string> pistas = new Dictionary<int, string>();

public juego ()
{
  respuestas.Add(1,"teclado");
  respuestas.Add(2,"pelota");
  respuestas.Add(3,"me encanta programar");
  respuestas.Add(4,"ARVYVARAYV");
  pistas.Add(1,"Escucha atentamente");
  pistas.Add(2,"Entrecerra los ojos");
  pistas.Add(3,"Presta atención a los dos diccionarios");
  pistas.Add(4,"Acordate hasta la decima combinación");
  sala = 1;
  
}

}

