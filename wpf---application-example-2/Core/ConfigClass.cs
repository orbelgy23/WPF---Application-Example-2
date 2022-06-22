using WPF___Application_Example_2.MVVM.ViewModel;


namespace WPF___Application_Example_2.Core
{
    public static class ConfigClass
    {

        public static bool ButtonInitState { get; set; } = true;
        public static bool ButtonShowState { get; set; } = false;
        public static bool ButtonHideState { get; set; } = false;
        public static bool ButtonDisposeState { get; set; } = false;

        public static bool RadioButtonEMState { get; set; } = true;
        public static bool RadioButtonFPState { get; set; } = false;

        public static EntityTrack ComboBoxEntitiesSelectedItemState { get; set; } = MainViewModel.NullEntity;
        public static string TextBoxSelectDirState { get; set; } = "Load Dir";
    }
}
