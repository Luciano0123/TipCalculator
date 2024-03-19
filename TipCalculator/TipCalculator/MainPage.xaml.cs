namespace TipCalculator
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button15Percent_Clicked(System.Object sender, System.EventArgs e)
        {

        }

        private void Button30Percent_Clicked(System.Object sender, System.EventArgs e)
        {

        }

        private void ButtonRoundUp_Clicked(System.Object sender, System.EventArgs e)
        {

        }

        private void ButtonRoundDown_Clicked(System.Object sender, System.EventArgs e)
        {

        }

        private void PorcentagemSlider_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
        {
            TipPercentualLabel.Text = $"{PorcentagemSlider.Value}%";

        }
    }

}
