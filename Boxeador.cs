using System;
public class Boxeador
{
    public string Nombre{get;set;}
    public int potenciaGolpes{get;set;}
     public int velocidadPiernas{get;set;}
    public string Pais{get;set;}
    public double Peso{get;set;}

public Boxeador(string nom, int p_G,int v_P, string pais,double peso)
    {
        Nombre = nom;
        potenciaGolpes = p_G;
        velocidadPiernas = v_P;
        Pais = pais;
        Peso = peso;


    }
    public double ObtenerSkill()
{
    Random rd = new Random(); int rand_num = rd.Next(1,10);
return velocidadPiernas * 0.6 + potenciaGolpes * 0.8 + rand_num;
}
}