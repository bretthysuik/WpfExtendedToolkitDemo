using System;
using System.Windows;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;

namespace WpfApp1;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        PropertyGrid.SelectedObject = new ComplexObject();
    }
}

public class ComplexObject
{
    public Guid Id { get; } = Guid.NewGuid();
    public string Name { get; set; } = String.Empty;
    public string Dotnet { get; } = System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription;
    public int Age { get; set; }

    [ExpandableObject]
    public InnerObject Nested { get; set; } = new();
}

public class InnerObject
{
    public Guid Id { get; } = Guid.NewGuid();
    public string Name { get; set; } = String.Empty;
    public double Value { get; set; }
    public DateTime Date { get; set; }
}