using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Microsoft.IdentityModel.Clients.ActiveDirectory;

namespace Contacts.Android
{
    [Activity(Label = "Contacts.Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
     
        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
            AuthenticationAgentContinuationHelper.SetAuthenticationAgentContinuationEventArgs(requestCode, resultCode, data);
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it

            Button button = FindViewById<Button>(Resource.Id.searchButton);

            button.Click += async delegate
            {

              
                TextView statusResult = FindViewById<TextView>(Resource.Id.statusResult);
                TextView givenResult = FindViewById<TextView>(Resource.Id.givenResult);
                TextView surnameResult = FindViewById<TextView>(Resource.Id.surnameResult);
                TextView upnResult = FindViewById<TextView>(Resource.Id.upnResult);
                TextView phoneResult = FindViewById<TextView>(Resource.Id.phoneResult);

              

                List<ContactsLib.MyContacts> results = await ContactsLib.Contacts.GetContacts( new AuthorizationParameters(this));
                if (results.Count == 0)
                {
                    statusResult.SetText(Resource.String.UserNotFound);
                    statusResult.SetTextColor(Color.White);
                    givenResult.SetText(Resource.String.EmptyString);
                    surnameResult.SetText(Resource.String.EmptyString);
                    upnResult.SetText(Resource.String.EmptyString);
                    phoneResult.SetText(Resource.String.EmptyString);
                }
               
                else
                {
                    statusResult.SetText(Resource.String.Success);
                    statusResult.SetTextColor(Color.Green);
                    givenResult.SetText(results[0].GivenName, TextView.BufferType.Normal);
                    surnameResult.SetText(results[0].Surname, TextView.BufferType.Normal);
                    upnResult.SetText(results[0].Id, TextView.BufferType.Normal);
                    phoneResult.SetText(results[0].BusinessPhone1, TextView.BufferType.Normal);
                }
            };
        }
    }
}

