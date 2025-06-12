using Newtonsoft.Json;

public class juego{

    [JsonProperty]
    public Dictionary <int, string> respuestas {get; private set;}= new Dictionary<int, string>();
    public Dictionary <int, string> pistas {get; private set;}= new Dictionary<int, string>();
    
    [JsonProperty]
    public int sala {get; private set;}
     
     [JsonProperty]

     public string usuario {get; private set;}
     
public juego ()
{
  respuestas.Add(1,"teclado");
  respuestas.Add(2,"sara");
  respuestas.Add(3,"me encanta programar");
  respuestas.Add(4,"ARVYVARAYV");
  pistas.Add(1,"Escucha atentamente");
  pistas.Add(2,"Entrecerra los ojos");
  pistas.Add(3,"Presta atención a los dos diccionarios");
  pistas.Add(4,"Acordate hasta la decima combinación");
  sala = 1;
}

public bool compararRespuesta (string codigo, int sala){
  bool ganar = false;
  if (codigo == respuestas[sala]){
    ganar = true;
  }
  return ganar;
}

}

