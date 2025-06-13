using Newtonsoft.Json;

public class juego{

    [JsonProperty]
    public List <string> respuestas {get; private set;}= new List<string>();
    public List <string> pistas {get; private set;}= new List<string>();
    
    [JsonProperty]
    public int sala {get; private set;}
     
    [JsonProperty]

    public string usuario {get; private set;}
     
public juego ()
{
  respuestas.Add("");
  respuestas.Add("teclado");
  respuestas.Add("sara");
  respuestas.Add("me encanta programar");
  respuestas.Add("ARVYVARAYV");
  pistas.Add("");
  pistas.Add("Escucha atentamente");
  pistas.Add("Entrecerra los ojos");
  pistas.Add("Presta atención a los dos diccionarios");
  pistas.Add("Encuentra la/s diferencia/s");
  sala = 1;
}

public bool compararRespuesta(string codigo){
  bool ganar = false;
  if (codigo == respuestas[sala]){
    ganar = true;
    sala++;
  }

  return ganar;
}

}

