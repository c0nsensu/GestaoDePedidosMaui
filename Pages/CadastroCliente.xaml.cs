namespace GestaoDePedidosMaui.Pages;

public partial class CadastroCliente : ContentPage
{
	public CadastroCliente()
	{
		InitializeComponent();

        var monkeyList = new List<string>();
        monkeyList.Add("Baboon");
        monkeyList.Add("Capuchin Monkey");
        monkeyList.Add("Blue Monkey");
        monkeyList.Add("Squirrel Monkey");
        monkeyList.Add("Golden Lion Tamarin");
        monkeyList.Add("Howler Monkey");
        monkeyList.Add("Japanese Macaque");

        Picker picker = new Picker { Title = "Select a monkey" };
        picker.ItemsSource = monkeyList;
    }

    private void btnSalvar_Clicked(object sender, EventArgs e)
    {

    }
}