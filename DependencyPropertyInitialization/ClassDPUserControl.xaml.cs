using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DependencyPropertyInitialization
{
    public partial class ClassDPUserControl : UserControl
    {

        public NamedClass NamedClassDP
        {
            get { return (NamedClass)GetValue(NamedClassDPProperty); }
            set { SetValue(NamedClassDPProperty, value); }
        }

        //This Creates a Singleton
        //public static readonly DependencyProperty NamedClassDPProperty =
        //    DependencyProperty.Register("NamedClassDP", typeof(NamedClass), typeof(ClassDPUserControl), new PropertyMetadata(new NamedClass()));

        //This Does Not Create a Singleton
        public static readonly DependencyProperty NamedClassDPProperty =
        DependencyProperty.Register("NamedClassDP", typeof(NamedClass), typeof(ClassDPUserControl)) ;

        public ClassDPUserControl()
        {
            InitializeComponent();
            NamedClassDP = new NamedClass();
        }
    }
}
