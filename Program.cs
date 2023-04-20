int menu;

Boxeador boxeador1 = null;
Boxeador boxeador2 = null;
do{
Console.WriteLine("i. Cargar Datos Boxeador 1");
Console.WriteLine("ii.Cargar Datos Boxeador 2");
Console.WriteLine("iii. Pelear!");
Console.WriteLine("iv. Salir");
menu = Funciones.IngresarEnteroEnRango("Ingresa una opcion entre 1 y 4",1,4);
switch(menu)
{
case 1:
{
boxeador1 = cargarBoxeador();
boxeador1 = ObtenerBoxeador(boxeador1);
    break;
}
case 2:
{
boxeador2 = cargarBoxeador();
boxeador2 = ObtenerBoxeador(boxeador2);
    break;
}
case 3:
{
    if(boxeador1 != null && boxeador2 != null) pelea(boxeador1,boxeador2);
    else Console.WriteLine("Alguno de los 2 boxeadores, todavia no ha sido ingresado.");
    break;
}
case 4:
{
    break;
}
}
}while(menu!= 4);
Boxeador cargarBoxeador(){
string nom = Funciones.IngresarTexto("Ingrese Nombre");
int p_G = Funciones.IngresarEnteroEnRango("Ingrese la potencia de golpe (entre 1 y 100)",1,100);
int v_P= Funciones.IngresarEnteroEnRango("Ingrese la velocidad de piernas (entre 1 y 100)",1,100);
string pais = Funciones.IngresarTexto("ingrese el pais de origen del boxeador");
double peso = Funciones.IngresarEntero("ingrese el peso del boxeador");
Boxeador boxeadorX =  new Boxeador(nom,p_G,v_P,pais,peso);
return boxeadorX;
}
Boxeador ObtenerBoxeador(Boxeador boxeador1)
{
Console.WriteLine("El nombre del boxeador es: " + boxeador1.Nombre);
Console.WriteLine("La potencia de golpes del boxeador es:  " + boxeador1.potenciaGolpes);
Console.WriteLine("La velocidad de piernas del boxeador es:  " + boxeador1.velocidadPiernas);
Console.WriteLine("El pais del boxeador es:  " + boxeador1.Pais);
Console.WriteLine("El peso del boxeador es:  " + boxeador1.Peso);
return boxeador1;
}
void pelea(Boxeador boxeador1, Boxeador boxeador2)
{    
string ganador = " ";
bool empate = false;
double skillMayor = 0;
double skillMenor = 0;
double skill1 = boxeador1.ObtenerSkill();
double skill2 = boxeador2.ObtenerSkill();
if (skill1 > skill2){
    skillMayor = skill1;
    skillMenor = skill2;
    ganador = boxeador1.Nombre;
}
else if (skill2 > skill1){
    skillMayor = skill2;
    skillMenor = skill1;
    ganador = boxeador2.Nombre;
} else empate = true;
if (!empate){
if(skillMayor - skillMenor >= 30) Console.WriteLine("Ganó " + ganador + " por KO");
else if (skillMayor - skillMenor >= 10) Console.WriteLine("Ganó " + ganador + " por puntos en fallo unánime");
else Console.WriteLine("Ganó " + ganador + " por puntos en fallo dividido");
} else Console.WriteLine("Hubo empate :( ");
}
