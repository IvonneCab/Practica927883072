
namespace Practica927883072;

public partial class Ejercicio5 : ContentPage
{
	public Ejercicio5()
	{
		InitializeComponent();
	}

    /// <summary>
    /// el primer evento es para realizar y calcular las operaciones de calcular el perimetro y el area de el rectangulo
    //por medio de las variables de tipo double resultado1, resultado2, Altura, y Base resultado uno calculara el perimetro del rectangulo
    // resultado2 calculara el ara del rectangulo y los resultados seran mostrados por medio de los entrys entryperimetro y entryarea
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    /// 



  
    private void Button_Clicked(object sender, EventArgs e)
    {
        double resultado1, resultado2, Altura, Base;
        Altura = Convert.ToDouble(entry1.Text);
        Base = Convert.ToDouble(entry2.Text);

        resultado1 = (Altura + Base) * 2;
        entryperimetro.Text = resultado1.ToString() + "cm";

        resultado2 = (Altura * Base);
        entryarea.Text = resultado2.ToString()+ "cm";
    }
}