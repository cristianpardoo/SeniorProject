﻿using System;
using System.Data;
using Xamarin.Forms;
using MySql.Data.MySqlClient;

namespace SeniorProject
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();

            // Gets rid of the extra blue navigation bar that occurs
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void btnRegisterAccount_Click()
        {
            // Notes:
            // Needs to redirect to RegisterAccountPage
            // 1. Create new RegisterAccountPage here
            // 2. Create function in RegisterAccountPage that allows for a redirect
        }

        private void btnLogin_Click()
        {
            try
            {
                // Notes:
                // UID & PASSWORD mapped to XAML buttons
                // 1. Create button binding in LoginPage.xaml 
                string connectionString = "SERVER=localhost;DATABASE=TeamBeach_Database;UID=root;PASSWORD=root;";

                MySqlConnection connection = new MySqlConnection(connectionString);

                MySqlCommand cmd = new MySqlCommand("select * from account", connection);

                DataTable dt = new DataTable();
                connection.Open();
                dt.Load(cmd.ExecuteReader());
                // User login failed
                if (cmd.ExecuteReader() == null)
                {
                    // Display Login Attempt failed

                    /* Consider incrementing a login attempt counter */
                }
                // User login successful
                else
                {
                    // Notes:
                    // Needs to redirect to HomePage
                    // 1. Create new HomePage here
                    // 2. Create function in HomePage that allows for a redirect
                }
                connection.Close();
            }
            catch (Exception)
            {
                
            }
        }

        private async void NavigateButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}