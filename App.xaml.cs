﻿namespace SimpleCollectionView;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        UserAppTheme = AppTheme.Dark;
    }
    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new AppShell()) {Height=800, Width=400};
    }
}