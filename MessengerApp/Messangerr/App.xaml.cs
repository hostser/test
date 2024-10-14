﻿using Data.Core.Context;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Configuration;
using System.Data;
using System.Windows;


namespace Messangerr
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App() : base() 
        {
            DatabaseFacade database = new(new AppDbContext());
            database.EnsureCreated();
        }
    }

}
