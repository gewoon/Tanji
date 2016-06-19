using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;

namespace Tanji.Components.Pages
{
    [ToolboxItem(false)]
    [DesignerCategory("Code")]
    public class PageControl : UserControl, INotifyPropertyChanged
    {
        private readonly Dictionary<string, Binding> _bindings;

        [Browsable(false)]
        public IMaster Master { get; private set; }

        public PageControl()
        {
            _bindings = new Dictionary<string, Binding>();

            BackColor = Color.White;
        }

        public virtual void AssignMaster(IMaster master)
        {
            Master = master;
        }

        protected void RaiseOnPropertyChanged(string propertyName)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }
        protected void Bind(Control control, string propertyName, string dataMember)
        {
            Binding binding = control.DataBindings.Add(propertyName, this,
                dataMember, false, DataSourceUpdateMode.OnPropertyChanged);

            _bindings[dataMember] = binding;
        }

        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
                FindForm()?.Invoke(handler, this, e);

            if (DesignMode)
                _bindings[e.PropertyName].ReadValue();
        }
        #endregion
    }
}