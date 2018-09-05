using TweedeTryXamarin.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace TweedeTryXamarin.ViewModels
{
    class TaskViewModel
    {
    
            public Task Task { get; set; }

            public TaskViewModel(Task myProperty) {
                Task = myProperty;
            }

            public TaskViewModel() {
                Task = new Task(1, "Alles checken voor parijs", Categorie.PRIVATE);
            }
            private string _Beschrijving;

            public string Beschrijving {
                get {
                    if (_Beschrijving == null) {
                        _Beschrijving = Task.Beschrijving;
                    }
                    return _Beschrijving;
                }
                set {
                    _Beschrijving = value;
                    Task.Beschrijving = _Beschrijving;
                }
            }

        
    }
}
