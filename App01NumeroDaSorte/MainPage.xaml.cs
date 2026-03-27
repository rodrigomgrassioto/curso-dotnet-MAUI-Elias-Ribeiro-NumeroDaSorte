namespace App01NumeroDaSorte;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnGenerateLuckNumbers(object sender, EventArgs e)
    {
        //NameApp.IsVisible = !NameApp.IsVisible;
        //ContainerLuckNumber.IsVisible = !ContainerLuckNumber.IsVisible;
        NameApp.IsVisible = false;
        ContainerLuckNumber.IsVisible = true;

        var set = GenerateLuckNumbers();

        number1.Text = set.ElementAt(0).ToString("D2"); // D2 para 2 dígitos
        number2.Text = set.ElementAt(1).ToString("D2"); // D2 para 2 dígitos
        number3.Text = set.ElementAt(2).ToString("D2"); // D2 para 2 dígitos
        number4.Text = set.ElementAt(3).ToString("D2"); // D2 para 2 dígitos
        number5.Text = set.ElementAt(4).ToString("D2"); // D2 para 2 dígitos
        number6.Text = set.ElementAt(5).ToString("D2"); // D2 para 2 dígitos

    }

    private SortedSet<int> GenerateLuckNumbers()
    {
        // SortedSet não deixa números se repetirem
        // set tradução de conjunto
        var set = new SortedSet<int>();
        while (set.Count < 6)
        {
            var random = new Random();
            var luckNumber = random.Next(1, 60);
            set.Add(luckNumber);

        }
        return set;
    }
}