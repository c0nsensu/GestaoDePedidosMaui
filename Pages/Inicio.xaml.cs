namespace GestaoDePedidosMaui.Pages;

public partial class Inicio : ContentPage
{
	public Inicio()
	{
		InitializeComponent();
	}

    private void btnNovoCliente_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new CadastroCliente());
    }

    private void btnNovoPedido_Clicked(object sender, EventArgs e)
    {

    }

    private void btnNovoPedido_Clicked_1(object sender, EventArgs e)
    {

    }
}