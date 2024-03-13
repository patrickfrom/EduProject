using System;
using System.Collections.Generic;
using System.Linq;
using Avalonia.Controls;
using Avalonia.Interactivity;
using RatRace.Domain;

namespace Frog.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
    }

    private void OnLoaded(object? sender, RoutedEventArgs e)
    {
        FillComboBox<DomainType>(ref DomainType);
        FillComboBox<WaterSource>(ref WaterSource);
        FillComboBox<Climate>(ref Climate);
        FillComboBox<Elevation>(ref Elevation);
    }

    private static List<ComboBoxItem> CreateComboBoxItems<T>()
    {
        return Enum.GetNames(typeof(T)).Select(name => new ComboBoxItem { Content = name }).ToList();
    }

    private static void FillComboBox<T>(ref ComboBox comboBox)
    {
        foreach (var item in CreateComboBoxItems<T>())
            comboBox.Items.Add(item);

        comboBox.SelectedIndex = 0;
    }
}