namespace Company.TeamExplorerSamplePlugin
{
    using System;
    using System.Windows;
    using System.Windows.Controls;

    using Microsoft.TeamFoundation.Controls;

    /// <summary>
    ///     Interaction logic for SampleSectionControl.xaml
    /// </summary>
    public partial class SampleSectionControl : UserControl
    {
        private readonly IServiceProvider serviceProvider;

        public SampleSectionControl(IServiceProvider serviceProvider)
        {
            this.InitializeComponent();

            this.serviceProvider = serviceProvider;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var service = this.GetService<ITeamExplorer>();
            if (service == null)
            {
                return;
            }
            service.NavigateToPage(new Guid(GuidList.sampleTeamExplorerPage), null);
        }

        public T GetService<T>()
        {
            if (this.serviceProvider != null)
            {
                return (T)this.serviceProvider.GetService(typeof(T));
            }
            return default(T);
        }
    }
}