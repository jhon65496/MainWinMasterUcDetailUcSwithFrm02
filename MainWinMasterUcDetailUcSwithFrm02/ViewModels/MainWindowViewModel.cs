using System.Collections.ObjectModel;
using System.ComponentModel;
// using MasterDetailDisplayDataListViewInDesign.Abstractions;
// using MainWinMasterUcDetailUcSwithFrm02.ViewModels
using MainWinMasterUcDetailUcSwithFrm02.Models;
using MainWinMasterUcDetailUcSwithFrm02.Repositories;

namespace MainWinMasterUcDetailUcSwithFrm02.ViewModels
{
    public class MainWindowViewModel : BaseVM
    {
        public ObservableCollection<Group> Groups { get; set; }

        public GroupsRepository groupRepository;

        private string title = "Title Windows";

        public string Title
        {
            get { return title; }
            set 
            { 
               RaisePropertyChanged(nameof(Title)); 
            }
        }


        public MainWindowViewModel()
        {
            groupRepository = new GroupsRepository();

            LoadData();
        }


        public void LoadData()
        {
            Groups = (ObservableCollection<Group>)groupRepository.GetAll();
        }   


    }
}
