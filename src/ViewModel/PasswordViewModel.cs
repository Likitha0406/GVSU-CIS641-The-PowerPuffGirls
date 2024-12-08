using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using nitesh_passman.ViewModel;

namespace nitesh_passman.ViewModel
{ 
    public class PasswordViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<PasswordModel> his;
        private DatabaseService db;
        private string _sample;

        public PasswordViewModel(DatabaseService historyDatabase)
        {
            his = new ObservableCollection<PasswordModel>();
            db = new DatabaseService();
            initData();
        }

        public ObservableCollection<PasswordModel> historyOut
        {
            get => his;
        }

        public void saveToHistory(String item,String pass)
        {
            PasswordModel historyModel = new PasswordModel();
            historyModel.Title = item;
            historyModel.Password = pass;
            db.SaveItemAsync(historyModel);
            //initData();
            OnPropertyChanged("historyOut");
            OnPropertyChanged();
        }
        public void initData()
        {
            var res = db.GetAllExpression();
            his = new ObservableCollection<PasswordModel>();
            res.ForEach(his.Add);
            OnPropertyChanged("historyOut");
            OnPropertyChanged();
        }

        public void update(List<PasswordModel> res)
        {
            his.Clear();
            historyOut.Clear();
            //res.ForEach(his.Add);
            res.ForEach(historyOut.Add);
            OnPropertyChanged("historyOut");
            OnPropertyChanged();
        }
        public void removeSingle(int id)
        {
            db.RemoveItem(id);
            initData();
            OnPropertyChanged("historyOut");
            OnPropertyChanged();
        }

        public void clearHistory()
        {
            db.DeleteAllAsync();
            //initData();
            OnPropertyChanged("historyOut");
            OnPropertyChanged();
        }

        public void OnPropertyChanged([CallerMemberName] string name = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

    }
}

