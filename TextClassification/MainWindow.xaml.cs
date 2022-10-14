using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TextClassification.Business;
using TextClassification.Controller;
using TextClassification.Domain;
using TextClassification.FileIO;

namespace TextClassification
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void ExecuteTraining_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = ""; //sets text to empty to prevent excesive flooding
            KnowledgeBuilder nb = new KnowledgeBuilder();

            // initiate the learning process

            long startTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();

            nb.Train();

            long duration = DateTimeOffset.Now.ToUnixTimeMilliseconds() - startTime;

            DurationDisplay.Text = $"Duration: {duration}ms ";

            // getting the (whole) knowledge found in ClassA and in ClassB
            Knowledge k = nb.GetKnowledge();
            


            // get a part of the knowledge - here just for debugging
            BagOfWords bof = k.GetBagOfWords();

            List<string> entries = bof.GetEntriesInDictionary();


            foreach (string entry in entries)
            {
                Display.Text += entry+"\n"; //adds all text to be displayed in box
            }

            DimensionDisplay.Text = $"Dimension: {entries.Count}";


        }

        private void CountTokens_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
