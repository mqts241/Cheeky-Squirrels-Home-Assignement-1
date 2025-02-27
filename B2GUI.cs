using System;
using System.Reflection.Metadata.Ecma335;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;
using Avalonia.PropertyStore;
using Avalonia.Layout;

namespace Smile;

public class B2GUI
{
    public Window win;

    public B2GUI()
    {
        win = new Window
        {
            Title = "B2Image Editor",
            Height = 600,
            Width = 400,
        };

        var stack = new StackPanel {
            Orientation = Orientation.Vertical,
            HorizontalAlignment = HorizontalAlignment.Center,
            VerticalAlignment = VerticalAlignment.Center,
            Margin = new Thickness(25),
        };

        var loadButton = new Button {
            Content = "Load File",    
        };
        loadButton.Click += LoadFile;

        var saveButton = new Button {
            Content = "Save File",
        };
        saveButton.Click += SaveFile;

        stack.Children.Add(loadButton);
        stack.Children.Add(saveButton);

        win.Content = stack;
        win.Show();
    }

    private void LoadFile(object? sender, RoutedEventArgs e)
        {
            Console.WriteLine("Load button clicked.");
            // Implement file loading logic here
        }

    private void SaveFile(object? sender, RoutedEventArgs e)
        {
            Console.WriteLine("Save button clicked.");
            // Implement file saving logic here
        }
}