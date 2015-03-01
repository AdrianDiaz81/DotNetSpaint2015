using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using ContactsLib;
using Microsoft.IdentityModel.Clients.ActiveDirectory;

namespace Contacts.Universal
{
    static class UniversalHelper
    {
        public static async Task Search(object sender, RoutedEventArgs e, GridView SearchResults,  IAuthorizationParameters parent)
        {
            List<MyContacts> results = await ContactsLib.Contacts.GetContacts(parent);            
            SearchResults.ItemsSource = results;
        }
    }
}
