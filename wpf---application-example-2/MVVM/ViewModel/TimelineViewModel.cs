using WPF___Application_Example_2.Core;
using System.Collections.ObjectModel;


namespace WPF___Application_Example_2.MVVM.ViewModel
{


    class TimelineViewModel
    {

        public ObservableCollection<EntityTrack> EntitiesForComboBox { get; set; }
        public bool RadioButtonEMIsChecked { get; set; }
        public bool RadioButtonFPIsChecked { get; set; }

        public RelayCommand EMChecked_Command { get; set; }
        public RelayCommand FPChecked_Command { get; set; }





        private EntityTrack _comboBoxEntities_SelectedItem;
        public EntityTrack ComboBoxEntities_SelectedItem
        {
            get { return _comboBoxEntities_SelectedItem; }
            set
            {
                ConfigClass.ComboBoxEntitiesSelectedItemState = value;
                _comboBoxEntities_SelectedItem = value;

                if (value.NativeEntity == null) // User chose 'none'
                {

                }
                else // User chose to track after an entity
                {

                }


            }
        }


        public TimelineViewModel()
        {
            EntitiesForComboBox = MainViewModel.EntitiesForComboBox;
            RadioButtonEMIsChecked = ConfigClass.RadioButtonEMState;
            RadioButtonFPIsChecked = ConfigClass.RadioButtonFPState;
            ComboBoxEntities_SelectedItem = ConfigClass.ComboBoxEntitiesSelectedItemState;

            EMChecked_Command = new RelayCommand(o =>
            {
                RadioButtonEMIsChecked = true;
                RadioButtonFPIsChecked = false;

                ConfigClass.RadioButtonEMState = true;
                ConfigClass.RadioButtonFPState = false;

            });

            FPChecked_Command = new RelayCommand(o =>
            {
                RadioButtonEMIsChecked = false;
                RadioButtonFPIsChecked = true;

                ConfigClass.RadioButtonEMState = false;
                ConfigClass.RadioButtonFPState = true;

            });



        }

    }
}
