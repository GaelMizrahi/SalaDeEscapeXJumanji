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
  respuestas.Add("sandia");
  respuestas.Add("ARVYVARAYV");
  pistas.Add("");
  pistas.Add("Escucha atentamente");
  pistas.Add("A veces tu mejor aliado es el 'Ctrl' + '-'");
  pistas.Add("Presta atención a los dos diccionarios");
  pistas.Add("Encuentra la/s diferencia/s");
  pistas.Add("Dale flaco, es un simon, no necesitas pista");
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

