using System.Collections.ObjectModel;
using System.Windows.Media;
using PhysXTool.Interfaces;

namespace PhysXTool.AppHomeViewModel
{
    public class AppHomeViewModel
    {
        #region Fields

        private string _searchTerm = string.Empty;

        #endregion

        #region Constructor

        public AppHomeViewModel()
        {
        }

        #endregion

        #region Properties

        public string SearchTerm
        {
            get { return _searchTerm; }
            set => _searchTerm = value;
        }

        public SolidColorBrush BackgroundColor { get; set; } = Brushes.SlateGray;

        public ObservableCollection<IPhysXTool> PhysXTools { get; set; }

        #endregion
    }
}
