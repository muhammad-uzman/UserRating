using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ShareExperince.ViewModel
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        #region Event handler

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Methods

        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private bool _isBusy;
        public bool IsBusy
        {
            get
            {
                return this._isBusy;
            }

            set
            {
                if (this._isBusy == value)
                {
                    return;
                }

                this._isBusy = value;
                this.NotifyPropertyChanged();
            }
        }
        #endregion
    }
}
