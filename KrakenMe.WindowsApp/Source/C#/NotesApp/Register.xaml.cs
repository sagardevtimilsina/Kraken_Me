using DAL.Repository;
using Helper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace KrakenMe.WindowsApp
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class Register : KrakenMe.WindowsApp.Common.LayoutAwarePage
    {
        public Register()
        {
            this.InitializeComponent();
        }

        //For navigating to a Login page    
        private void Login_Click(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                //KrakenRepo _repo = new KrakenRepo();
                //Helper.AppVariables.KrakenID = _repo.Login(txtUsername.Text, txtPassword.Text);
                                
                //if (AppVariables.IsAuthenticated())
                //{
                //    this.Frame.Navigate(typeof(HubPage));
                //}
                //else
                //{
                //    // show error message
                //    Helper.DialogHelper.ShowMessageBox("Invalid Authentication Details. Please login with proper Username and Password. !!");
                //}
            }
            catch(Exception ex)
            {
                //show exception.. 
                Helper.DialogHelper.ShowMessageBox(ex.ToString());
            }
            
        }

        // 
        private void Register_Click(object sender, TappedRoutedEventArgs e)
        {
            
        }








        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="navigationParameter">The parameter value passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested.
        /// </param>
        /// <param name="pageState">A dictionary of state preserved by this page during an earlier
        /// session.  This will be null the first time a page is visited.</param>
        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="pageState">An empty dictionary to be populated with serializable state.</param>
        protected override void SaveState(Dictionary<String, Object> pageState)
        {
        }
    }
}
