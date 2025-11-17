namespace Counter;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnAddClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(NameEntry.Text))
        {
            return;
        }

        var nameLabel = new Label
        {
            Text = NameEntry.Text,
            FontSize = 20,
            HorizontalOptions = LayoutOptions.Center
        };

        var valueLabel = new Label
        {
            Text = "0",
            FontSize = 32,
            HorizontalOptions = LayoutOptions.Center
        };

        int value = 0;

        Button minus = new Button
        {
            Text = "-",
            WidthRequest = 60
        };

        Button plus = new Button
        {
            Text = "+",
            WidthRequest = 60
        };

        minus.Clicked += (o, args) =>
        {
            value--;
            valueLabel.Text = value.ToString();
        };

        plus.Clicked += (o, args) =>
        {
            value++;
            valueLabel.Text = value.ToString();
        };

        var buttonsLayout = new HorizontalStackLayout
        {
            Spacing = 15,
            HorizontalOptions = LayoutOptions.Center
        };

        buttonsLayout.Children.Add(minus);
        buttonsLayout.Children.Add(plus);

        var oneCounter = new VerticalStackLayout
        {
            Spacing = 5,
            Padding = 10
        };

        oneCounter.Children.Add(nameLabel);
        oneCounter.Children.Add(valueLabel);
        oneCounter.Children.Add(buttonsLayout);

        CountersLayout.Children.Add(oneCounter);

        NameEntry.Text = "";
    }
}
