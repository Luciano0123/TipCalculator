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
            PorcentagemSlider.Value = 15;
        }

        private void Button30Percent_Clicked(System.Object sender, System.EventArgs e)
        {
            PorcentagemSlider.Value = 15*2;
        }

        private void ButtonRoundUp_Clicked(System.Object sender, System.EventArgs e)
        {
            double tip = Math.Ceiling(CalculateTip());
            double valRef = Convert.ToDouble(ValorEntry.Text);
            TipLabel.Text = $"R$ {tip}";
            AllValueLabel.Text = $"R$ {tip+valRef}";
        }

        private void ButtonRoundDown_Clicked(System.Object sender, System.EventArgs e)
        {
            double tip = Math.Floor(CalculateTip());
            double valRef = Convert.ToDouble(ValorEntry.Text);
            TipLabel.Text = $"R$ {tip}";
            AllValueLabel.Text = $"R$ {tip + valRef}";
        }

        private void PorcentagemSlider_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
        {
            TipPercentualLabel.Text = $"{Math.Round(PorcentagemSlider.Value)}%";

        }
        private double CalculateTip()
        {
            double valRef = Convert.ToDouble(ValorEntry.Text);
            double valPorc = PorcentagemSlider.Value / 100;

            return valRef*valPorc;
        }

    }

}
