using WPF___Application_Example_2.Core;
using System.Windows;
using System.Windows.Forms;

namespace WPF___Application_Example_2.MVVM.ViewModel
{
    class HomeViewModel : ObservableObject
    {
        private bool _initButtonEnabled;
        public bool InitButtonEnabled 
        {
            get { return _initButtonEnabled; }
            set 
            {
                _initButtonEnabled = value;
                OnPropertyChanged();
                
            }
        }
        private bool _showButtonEnabled;
        public bool ShowButtonEnabled 
        {
            get { return _showButtonEnabled; }
            set
            {
                _showButtonEnabled = value;
                OnPropertyChanged();
            }
        }
        private bool _hideButtonEnabled;

        public bool HideButtonEnabled 
        {
            get { return _hideButtonEnabled; }
            set
            {
                _hideButtonEnabled = value;
                OnPropertyChanged();
            }
        }
        private bool _disposeButtonEnabled;
        public bool DisposeButtonEnabled 
        {
            get { return _disposeButtonEnabled; }
            set
            {
                _disposeButtonEnabled = value;
                OnPropertyChanged();
            }
        }
        private string _selectedDirPathString;
        public string SelectedDirPathString 
        {
            get { return _selectedDirPathString; }
            set
            {
                _selectedDirPathString = value;
                OnPropertyChanged();
            }
        }


        public RelayCommand ButtonInit_Command { get; set; }
        public RelayCommand ButtonShow_Command { get; set; }
        public RelayCommand ButtonHide_Command { get; set; }
        public RelayCommand ButtonDispose_Command { get; set; }
        public RelayCommand ButtonOK_Command { get; set; }
        public RelayCommand ButtonBrowse_Command { get; set; }

        


        public HomeViewModel()
        {
            InitButtonEnabled = ConfigClass.ButtonInitState;
            ShowButtonEnabled = ConfigClass.ButtonShowState;
            HideButtonEnabled = ConfigClass.ButtonHideState;
            DisposeButtonEnabled = ConfigClass.ButtonDisposeState;
            SelectedDirPathString = ConfigClass.TextBoxSelectDirState;

            ButtonInit_Command = new RelayCommand(o =>
            {
                InitButtonEnabled = false;
                ShowButtonEnabled = true;
                HideButtonEnabled = false;
                DisposeButtonEnabled = true;

                ConfigClass.ButtonInitState = false;
                ConfigClass.ButtonShowState = true;
                ConfigClass.ButtonHideState = false;
                ConfigClass.ButtonDisposeState = true;
            });

            ButtonShow_Command = new RelayCommand(o =>
            {
                InitButtonEnabled = false;
                ShowButtonEnabled = false;
                HideButtonEnabled = true;
                DisposeButtonEnabled = true;

                ConfigClass.ButtonInitState = false;
                ConfigClass.ButtonShowState = false;
                ConfigClass.ButtonHideState = true;
                ConfigClass.ButtonDisposeState = true;
            });

            ButtonHide_Command = new RelayCommand(o =>
            {
                //    InitButtonEnabled = false;
                //    ShowButtonEnabled = true;
                //    HideButtonEnabled = false;
                //    DisposeButtonEnabled = true;

                //    //ConfigClass.ButtonInitState = false;
                //    //ConfigClass.ButtonShowState = true;
                //    //ConfigClass.ButtonHideState = false;
                //    //ConfigClass.ButtonDisposeState = true;
            });

            ButtonDispose_Command = new RelayCommand(o =>
            {
                InitButtonEnabled = true;
                ShowButtonEnabled = false;
                HideButtonEnabled = false;
                DisposeButtonEnabled = false;

                ConfigClass.ButtonInitState = true;
                ConfigClass.ButtonShowState = false;
                ConfigClass.ButtonHideState = false;
                ConfigClass.ButtonDisposeState = false;
            });

            ButtonBrowse_Command = new RelayCommand(o =>
            {
                using (var dialog = new System.Windows.Forms.FolderBrowserDialog())
                {
                    var res = dialog.ShowDialog();
                    if (res == System.Windows.Forms.DialogResult.OK)
                    {
                        SelectedDirPathString = dialog.SelectedPath;
                        ConfigClass.TextBoxSelectDirState = dialog.SelectedPath;
                    }
                }
            });

            ButtonOK_Command = new RelayCommand(o =>
            {
                System.Windows.MessageBox.Show(SelectedDirPathString);
                SelectedDirPathString = "Load Dir";
            });


        }


    }
}
