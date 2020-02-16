using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

using grand_duc_go.Models;
using grand_duc_go.Views;

namespace grand_duc_go.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        public List<Objective> Objectives;
        public Command LoadItemsCommand { get; set; }

        public ItemsViewModel()
        {
            Title = "Duke Duke Go";
            this.Objectives = Objective.GetObjectives();
        }
    }
}