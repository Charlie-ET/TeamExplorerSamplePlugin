namespace Company.TeamExplorerSamplePlugin
{
    using System;
    using System.ComponentModel;

    using Microsoft.TeamFoundation.Controls;

    [TeamExplorerSection(GuidList.sampleTeamExplorerSection, TeamExplorerPageIds.Home, 100)]
    public class SampleTeamExplorerSection : ITeamExplorerSection
    {
        private IServiceProvider serviceProvider;

        private bool isBusy;

        private bool isExpanded = true;

        private bool isVisible = true;

        public void Initialize(object sender, SectionInitializeEventArgs e)
        {
            this.serviceProvider = e.ServiceProvider;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void Cancel()
        {
        }

        public object GetExtensibilityService(Type serviceType)
        {
            return null;
        }

        public bool IsBusy
        {
            get
            {
                return this.isBusy;
            }
            private set
            {
                this.isBusy = value;
                this.FirePropertyChanged("IsBusy");
            }
        }

        public bool IsExpanded
        {
            get
            {
                return this.isExpanded;
            }
            set
            {
                this.isExpanded = value;
                this.FirePropertyChanged("IsExpanded");
            }
        }

        public bool IsVisible
        {
            get
            {
                return this.isVisible;
            }
            set
            {
                this.isVisible = value;
                this.FirePropertyChanged("IsVisible");
            }
        }

        public void Loaded(object sender, SectionLoadedEventArgs e)
        {
        }

        public void Refresh()
        {
        }

        public void SaveContext(object sender, SectionSaveContextEventArgs e)
        {
        }

        public object SectionContent
        {
            get
            {
                return new SampleSectionControl(serviceProvider);
            }
        }

        public string Title
        {
            get
            {
                return "Sample Section";
            }
        }

        public void Dispose()
        {
        }

        private void FirePropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}