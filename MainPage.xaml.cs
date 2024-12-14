using EfficiencyCalculator.ViewModels;

namespace EfficiencyCalculator
{
    public partial class MainPage : ContentPage
    {
        private StatsViewModel viewModel;

        // Dictionary to hold button states
        private Dictionary<Button, bool> statButtonStates;

        // Dictionary to track stat actions
        private Dictionary<Button, Action> statActions;

        // Bring it static resources from main page
        private readonly string ButtonDisabledColorKey = "ButtonDisabledColorKey";
        private readonly string ButtonEnabledColorKey = "ButtonEnabledColorKey";
        private readonly string TextDisabledColorKey = "TextDisabledColorKey";
        private readonly string TextEnabledColorKey = "TextEnabledColorKey";

        // Main Page constructor
        public MainPage()
        {
            InitializeComponent();
            // Initialize the StatsViewModel
            viewModel = new StatsViewModel();
            BindingContext = viewModel;

            // Initialize button states
            statButtonStates = new[]
            {
                TmFgTwoMadeBtn, TmFgTwoMissBtn, TmFgThreeMadeBtn, TmFgThreeMissBtn,
                TmOrbBtn, TmDrbBtn, TmFtMadeBtn, TmFtMissBtn, TmTovBtn,
                OppFgTwoMadeBtn, OppFgTwoMissBtn, OppFgThreeMadeBtn, OppFgThreeMissBtn,
                OppOrbBtn, OppDrbBtn, OppFtMadeBtn, OppFtMissBtn, OppTovBtn
            }.ToDictionary(button => button, _ => false);

            // Initialze stat action dictionary
            statActions = new Dictionary<Button, Action>
            {
                { TmFgTwoMadeBtn, () => viewModel.TmFgTwoMade++ },
                { TmFgTwoMissBtn, () => viewModel.TmFgTwoMiss++ },
                { TmFgThreeMadeBtn, () => viewModel.TmFgThreeMade++ },
                { TmFgThreeMissBtn, () => viewModel.TmFgThreeMiss++ },
                { TmOrbBtn, () => viewModel.TmOrb++ },
                { TmDrbBtn, () => viewModel.TmDrb++ },
                { TmFtMadeBtn, () => viewModel.TmFtMade++ },
                { TmFtMissBtn, () => viewModel.TmFtMiss++ },
                { TmTovBtn, () => viewModel.TmTov++ },
                { OppFgTwoMadeBtn, () => viewModel.OppFgTwoMade++ },
                { OppFgTwoMissBtn, () => viewModel.OppFgTwoMiss++ },
                { OppFgThreeMadeBtn, () => viewModel.OppFgThreeMade++ },
                { OppFgThreeMissBtn, () => viewModel.OppFgThreeMiss++ },
                { OppOrbBtn, () => viewModel.OppOrb++ },
                { OppDrbBtn, () => viewModel.OppDrb++ },
                { OppFtMadeBtn, () => viewModel.OppFtMade++ },
                { OppFtMissBtn, () => viewModel.OppFtMiss++ },
                { OppTovBtn, () => viewModel.OppTov++ }
            };

            // Set buttons to be default "unchecked"
            foreach (Button button in statButtonStates.Keys)
            {
                SetButtonsUnchecked(button);
            }

        }

        // Listener for stat button click
        private void OnStatButtonClicked(object sender, EventArgs e)
        {
            if (sender is Button button && statButtonStates.ContainsKey(button))
            {
                bool isChecked = statButtonStates[button];
                statButtonStates[button] = !isChecked;

                button.BackgroundColor = isChecked ?
                    (Color)this.Resources[ButtonDisabledColorKey] :
                    (Color)this.Resources[ButtonEnabledColorKey];

                button.TextColor = isChecked ?
                    (Color)this.Resources[TextDisabledColorKey] :
                    (Color)this.Resources[TextEnabledColorKey];

                button.InvalidateMeasure();
            }
        }

        // Listener for submit click
        private void OnSubmitPlayBtnClicked(object sender, EventArgs e)
        {
            // Iterate over statActions to update labels & ViewModel variables
            foreach(var kvp in statActions)
            {
                if (statButtonStates[kvp.Key])
                {
                    kvp.Value.Invoke();
                }
            }

            // Reset button states after play is entered
            foreach(var button in statButtonStates.Keys)
            {
                SetButtonsUnchecked(button);
            }
            
        }

        // Helper method to set buttons back to default unchecked state
        private void SetButtonsUnchecked(Button button)
        {
            button.BackgroundColor = (Color)this.Resources["ButtonDisabledColorKey"];
            button.TextColor = (Color)this.Resources["TextDisabledColorKey"];
            statButtonStates[button] = false;
        }
    }

}
