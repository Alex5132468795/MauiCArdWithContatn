namespace MauiApp3;

public partial class NewContent1 : ContentView
{

    public NewContent1(List<string> a) 
	{
		InitializeComponent();

			name.Text =  a[0];
            surname.Text = a[1];
            furna.Text = a[2];
        
	}
}