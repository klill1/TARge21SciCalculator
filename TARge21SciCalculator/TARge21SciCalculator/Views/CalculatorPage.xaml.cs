using TARge21SciCalculator.ViewModels;

namespace TARge21SciCalculator.Views;

public partial class CalculatorPage : ContentPage
{
    private CalculatorPageViewModel _calculatorViewModel;

    public CalculatorPage()
	{
		InitializeComponent();

        _calculatorViewModel = new CalculatorPageViewModel();
        this.BindingContext = _calculatorViewModel;
    }
}