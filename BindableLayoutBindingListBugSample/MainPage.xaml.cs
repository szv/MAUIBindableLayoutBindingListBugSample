using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.Versioning;

namespace BindableLayoutBindingListBugSample;

public partial class MainPage : ContentPage
{
	private int _items = 0;

	public MainPage()
	{
		InitializeComponent();
		BindingContext = this;
	}

	public string FrameworkVersion { get; } = Assembly.GetEntryAssembly()?.GetCustomAttribute<TargetFrameworkAttribute>()?.FrameworkName ?? string.Empty;

	public BindingList<int> LeftItems { get; } = new();

	public ObservableCollection<int> RightItems { get; } = new();

	private void AddItemButton_Clicked(object sender, EventArgs e)
	{
		LeftItems.Add(_items);
		RightItems.Add(_items);
        _items++;
    }
}

