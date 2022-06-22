using WPF___Application_Example_2.Core;
using System.Collections.ObjectModel;


namespace WPF___Application_Example_2.MVVM.ViewModel
{
    class EntityViewModel
    {

        #region PROPERTIES

        public static ObservableCollection<EntityTrack> Entities2 { get; set; }

        public RelayCommand RemoveEntityFunc { get; set; }

        #endregion


        #region METHODS

        public EntityViewModel()
        {
            Entities2 = MainViewModel.Entities;
            RemoveEntityFunc = new RelayCommand(o =>
                {
                    var model_path = "F:/Data/Toy.obj";
                    var model_name = "first";

                    //Entities2.Add(newEntityTrack); // Need to create that object
                    //MainViewModel.EntitiesForComboBox.Add(newEntityTrack);
                });

        }
        
        #endregion
    }
}
