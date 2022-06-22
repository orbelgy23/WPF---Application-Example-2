using System.Collections.ObjectModel;
using WPF___Application_Example_2.Core;

namespace WPF___Application_Example_2.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public static EntityTrack NullEntity { get; set; } = new EntityTrack(null, "None");
        public static ObservableCollection<EntityTrack> Entities { get; set; }
        public static ObservableCollection<EntityTrack> EntitiesForComboBox { get; set; }



        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand EntityViewCommand { get; set; }
        public RelayCommand TimelineViewCommand { get; set; }



        public HomeViewModel HomeVm { get; set; }
        public EntityViewModel EntityVm { get; set; }
        public TimelineViewModel TimelineVm { get; set; }


        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }


        public MainViewModel()
        {
            HomeVm = new HomeViewModel();
            EntityVm = new EntityViewModel();
            TimelineVm = new TimelineViewModel();
            CurrentView = HomeVm; // StartUp window if you want..

            HomeViewCommand = new RelayCommand(o => { CurrentView = HomeVm; });
            EntityViewCommand = new RelayCommand(o => { CurrentView = EntityVm; });
            TimelineViewCommand = new RelayCommand(o => { CurrentView = TimelineVm; });

            Entities = new ObservableCollection<EntityTrack>();
            EntitiesForComboBox = new ObservableCollection<EntityTrack>() { NullEntity };
        }

    }
}
