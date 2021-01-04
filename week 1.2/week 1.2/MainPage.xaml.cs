using MyNamespace;
using MyNamespace2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace week_1._2
{
    public partial class MainPage : ContentPage
    {
        private List<Person> persons = new List<Person>();
        private List<Animal> pets = new List<Animal>();
        //private List<Animal> pets = new List<Animal>();
        Person selectedPerson = null;

        public MainPage()
        {
            InitializeComponent();
        }
        public void AddPersonClicked(Object sender, EventArgs e)
        {
            string voor = Voornaam.Text;
            string achter = Achternaam.Text;
            int leeft = Convert.ToInt32(Leeftijd.Text);
            Person newperson = new Person (voor, achter, leeft);
            persons.Add(newperson);
            Voornaam.Text = null;
            Achternaam.Text = null;
            Leeftijd.Text = null;
            ListViewPersonen.ItemsSource = null;
            ListViewPersonen.ItemsSource = persons;
            selectedPerson = newperson;

        }
        public async void PersonSelected(Object sender, SelectedItemChangedEventArgs e)
        {
            selectedPerson = (Person)e.SelectedItem;
            if (selectedPerson != null)
                await DisplayAlert("Info", selectedPerson.Getname(), "OK");

        }
        public void AddAnimalClicked(Object sender, EventArgs e)
        {
            string naam = HuisdierNaam.Text;
            string soort = HuisdierSoort.Text;
 

            HuisdierNaam.Text = null;
            HuisdierSoort.Text = null;
            //ListViewHuisdieren.ItemsSource = null;
            //ListViewHuisdieren.ItemsSource = pets;
            //selectedAnimal = newanimal;
            
        }
    }
}
