using System;
using System.Collections.Generic;
using System.Text;

namespace TweedeTryXamarin.models {
    class Task {
        public int Id { get; set; }
        public String Beschrijving { get; set; }
        public Categorie Categorie { get; set; }

        public Task(int id, string beschrijving, Categorie categorie) {
            Id = id;
            Beschrijving = beschrijving;
            Categorie = categorie;
        }
    }
}
