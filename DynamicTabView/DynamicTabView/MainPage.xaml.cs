using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DynamicTabView
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.ItemsSource = new MainClass[] {
                new MainClass ("Tab 1",new List<Monkey>(){ new Monkey { Name = "Baboon"},new Monkey { Name = "Capuchin Monkey" } }),
                 new MainClass ("Tab 2",new List<Monkey>(){ new Monkey { Name = "Baboon"},new Monkey { Name = "Capuchin Monkey" },new Monkey { Name = "Blue Monkey", } }),
            };
        }

        class MainClass
        {
            public MainClass(string name, IList<Monkey> list)
            {
                this.Name = name;
                this.list = list;
            }

            public string Name { private set; get; }
            public IList<Monkey> list { private set; get; }

            public override string ToString()
            {
                return Name;
            }
        }

        public class Monkey
        {
            public string Name { get; set; }
           
            public override string ToString()
            {
                return Name;
            }
        }
    }
}
