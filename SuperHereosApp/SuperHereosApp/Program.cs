

using System.Text;
using SuperHereosApp;
using SuperHereosApp.Models;

var Imprimirinfo = new Info();

var poderVolar = new superPoder();
poderVolar.Name = "Volar";
poderVolar.Descripcion = "Capacidad de volar y planear por los aires";
poderVolar.Nivel = NivelPoder.NivelDos;

var telaraña = new superPoder();
telaraña.Name = "Telaraña";
telaraña.Descripcion = "Tira telaraña desde la muñeca";
telaraña.Nivel = NivelPoder.NivelTres;

var invisible = new superPoder();
invisible.Name = "Invisilidad";
invisible.Descripcion = "Capicidad de poder hacerse invisilidad durante un tiempo";
invisible.Nivel = NivelPoder.NivelDos;

var sentidos = new superPoder();
sentidos.Name = "Sentido  Aracnido";
sentidos.Descripcion = "estar alerta y atento a cualquier movimiento";
sentidos.Nivel = NivelPoder.NivelTres; 

var superfuerza = new superPoder();
superfuerza.Name = "Super Fuerza";
superfuerza.Descripcion = "Fuerza sobre natural";
superfuerza.Nivel = NivelPoder.NivelTres;

var sobreCarga = new superPoder();
sobreCarga.Name = "Sobre Carga";
sobreCarga.Descripcion = "Recibir impactos hasta generar energia que es lanzada";
sobreCarga.Nivel = NivelPoder.NivelDos;


var SpiderMan = new SuperHeroe();

SpiderMan.id = 1;
SpiderMan.name = "  SpiderMan  ";
SpiderMan.identidadSecreta = "Peter Paker";
SpiderMan.ciudad = "New York";
List<superPoder> poderesSpiderMan = new List<superPoder>();
poderesSpiderMan.Add(telaraña);
poderesSpiderMan.Add(invisible);
poderesSpiderMan.Add(sentidos);
SpiderMan.SuperPoderes = poderesSpiderMan;
SpiderMan.puedovolar = false;

Imprimirinfo.ImprimirInfo(SpiderMan);

string resultSuperPoderes1 = SpiderMan.usarSuperPoderes();
Console.WriteLine(resultSuperPoderes1);

string resultSalvar = SpiderMan.SalvarElMundo();
Console.WriteLine(resultSalvar);



var BlackPanther = new SuperHeroe();

BlackPanther.id = 2;
BlackPanther.name = "Black Panther";
BlackPanther.identidadSecreta = "Principe Techala";
BlackPanther.ciudad = "Wakanda";
List<superPoder> poderesPantera = new List<superPoder>();
poderesPantera.Add(superfuerza);
poderesPantera.Add(invisible);
poderesPantera.Add(sobreCarga);
BlackPanther.SuperPoderes = poderesPantera;

string resultSuperPoderes2 = BlackPanther.usarSuperPoderes();
Console.WriteLine(resultSuperPoderes2); 

string wakandaS = BlackPanther.SalvarWakanda();
Console.WriteLine(wakandaS);



var DeadPool = new Antiheroe();

DeadPool.id = 3;
DeadPool.name = "Deadpool";
DeadPool.identidadSecreta = "Ryan Reynols";
DeadPool.ciudad = "New York";

List<superPoder> poderesDeadpool = new List<superPoder>();
poderesDeadpool.Add(superfuerza);
DeadPool.SuperPoderes = poderesDeadpool;

Imprimirinfo.ImprimirInfo(DeadPool);

string resultSupoder3 = DeadPool.usarSuperPoderes();
Console.WriteLine(resultSupoder3);

string accionAntiheroe = DeadPool.acciondeAntiheroe("Atacar a la policia");
Console.WriteLine(accionAntiheroe); 



enum NivelPoder
{
    NivelUno,
    NivelDos,
    NivelTres
}


