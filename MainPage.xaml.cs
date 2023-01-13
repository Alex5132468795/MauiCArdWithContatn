namespace MauiApp3;

public partial class MainPage : ContentPage
{
    List<string> data = new List<string>(); 
	public MainPage()
	{
		InitializeComponent();
	}

	private void starts_Clicked(object sender, EventArgs e)
    {
        container.Children.Clear();
        for (int i = 1; i <= Int32.Parse(cont.Text); i++)
        {
            data.Add(i.ToString());
            data.Add((i + 10).ToString());
            data.Add((i + 100).ToString());
            NewContent1 n = new NewContent1(data);
            container.Add(n);
        }

        data.Clear();
    }
}

